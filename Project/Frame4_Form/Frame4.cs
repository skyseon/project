using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Frame4_Form;
using Project.SqliteDB;
using Project.Sharing;
using System.IO;
using SamplePg_CS;

namespace Project
{
    public partial class Frame4 : UserControl
    {
        static int ERROR = 1;
        const int Create = 1 , change = 2;  //리스트 추가 화면시 버튼 설정(1 :  추가, 2 :  수정)
        Sqlite_option sqlite = new Sqlite_option();
        Print print = new Print();
        const int db_listitem = 1;  // 물품리스트 DB 
        const int db_item = 0;  //  물품  DB  

        const int item_ro = 0;  //물품명 순서
        const int card_ro = 4;  // 판매단가 순서
        const int varcode_ro = 7;   // 바코드 순서

        public static int varcode_num = 0; //바코드 횟수
        String[] select_str = {
                                  
                                  "SELECT name as \"물품명\",amount as \"수량\" ,item_code as \"제품코드\", incash as \"공급단가\","+
                                  "card as \"판매단가\", outcash as \"현금단가\","+
                                  "percent as \"퍼센트\", varcode as \"바코드\", list as \"항목\","+
                                  "file_img as \"이미지위치\",explanation as \"설명\" "+
                                  " from master" ,  //0  메인 뷰 
                                  "SELECT name as \"제품명\" FROM list ORDER BY name asc "//1  // 제품뷰
                              };

        String[] delect_str =
                            {
                                "DELETE from master where varcode = \"", 
                                "DELETE from list where name = \"" 
                            };

        int[] col_wid = { 200, 60, 90, 80, 80, 80, 52, 80, 95, 100, 100 };
        public Frame4()
        {
            InitializeComponent();
            sqlite.DB_Select(db_listitem, list_view, select_str[db_listitem]);  //리스트 불러오기
            sqlite.DB_Select(db_item, item_view, select_str[db_item] + " ORDER BY name asc;");    //물품 불러오기
            select_option(db_listitem, list_view);  //창 사이즈 설정
            select_option(db_item, item_view);  //창 사이즈 설정
        }

        private void list_in_Click(object sender, EventArgs e)  //리스트 추가
        {

            Group_Add f4_list = new Group_Add("추가 하실 항목명을 적어주세요", 0); // 텍스트 이름과 번호 설정 
            // 0번은 물품 항목 리스트 추가
            f4_list.ShowDialog();
            sqlite.DB_Select(db_listitem, list_view, select_str[db_listitem]);  //리스트 불러오기
            list_view.CurrentCell = null;   //창 선택해제
        }

        private void list_del_Click(object sender, EventArgs e) // 리스트 삭제
        {
            DB_del(list_view,db_listitem);
        }

        private void insert_bt_Click(object sender, EventArgs e)    //추가 버튼
        {
            int select = 0; // 추가,수정 정보 구분을 위한 변수
            F4_main_creat f4Creat = new F4_main_creat(select,item_view);
            f4Creat.ShowDialog();
            sqlite.DB_Select(db_item, item_view, select_str[db_item] + " ORDER BY name asc");  //리스트 불러오기
            item_view.CurrentCell = null;   //창 선택해제
        }

        private void update_bt_Click(object sender, EventArgs e)    //수정 버튼
        {
            int select = 1;

            if (item_view.CurrentCell == null)  //수정데이터가 클릭 안되 있을때
            {
                MessageBox.Show("수정할 데이터를 선택해주세요.");
                return;
            }

            F4_main_creat f4Creat = new F4_main_creat(select,item_view);
            f4Creat.ShowDialog();

            if (update_cb.Checked == false) return;
            sqlite.DB_Select(db_item, item_view, select_str[db_item] + " ORDER BY name asc");  //리스트 불러오기
            item_view.CurrentCell = null;   //창 선택해제
        }

        private void delete_bt_Click(object sender, EventArgs e)    //물품 삭제
        {
            DB_del(item_view,db_item);
        }

        private int DB_del(DataGridView view,int dbfile)   //선택 데이터 삭제 함수
        {
            int varcode = 7;    //바코드 뷰 번호순서
            try
            {
                if (view.CurrentCell == null)      //항목 선택을 안했을떄
                {
                    MessageBox.Show("항목을 선택해주세요");
                }
                else
                {
                    int rowIndex = view.CurrentRow.Index;      //현재 선택 창 가져오기
                    string str = "";
                    if(dbfile == db_listitem) str = view.Rows[rowIndex].Cells[0].Value.ToString();    //항목문자 가져오기
                    else str = view.Rows[rowIndex].Cells[varcode].Value.ToString();    //물품 문자 가져오기
                                    //뷰 테이블 추가시 cells 변경 요망(변수지정이 아니라)
                    
                    if(dbfile == db_listitem && str.Equals("기타")){
                        MessageBox.Show("기타 항목은 삭제 불가합니다.");
                        return 0;
                    }
                    DialogResult result;
                    result = MessageBox.Show(view.Rows[rowIndex].Cells[0].Value.ToString() + " 삭제하시겠습니까?", "삭제항목", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK) //삭제 확인 클릭시
                    {
                        String strSQL = delect_str[dbfile] + str + "\"";
                        int callback = sqlite.DB_Delete(dbfile, strSQL);
                        if (callback == ERROR)
                        {
                            MessageBox.Show("삭제실패");
                            return 1;
                        }
                  
                        MessageBox.Show("삭제가 완료 되었습니다.");

                        if (dbfile == db_listitem)  //리스트 항목 삭제시 삭제항목->기타 항목으로 변경
                        {
                            str = "UPDATE master set list = '기타' where list = '" + str + "';";
                            sqlite.DB_update(db_item, str);
                        }

                        ////삭제 완료한 view 새로 불러오기
                        if (dbfile == db_item) sqlite.DB_Select(db_item, view, select_str[dbfile]);  //리스트 불러오기
                        else if (dbfile == db_listitem) sqlite.DB_Select(db_listitem, view, select_str[db_listitem]);
                    }
                }
                view.CurrentCell = null;   //창 선택해제
                return 0;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return 1;
            }
        }

        private void search_bt_Click(object sender, EventArgs e)    //검색창 버튼 입력시
        {
            sqlite_where();
        }
        private void search_tb_KeyDown(object sender, KeyEventArgs e)   //검색창에서 키를 누를시
        {
            if (e.KeyCode == Keys.Enter)    //검색 박스에서 엔터키를 누를시
            {
                sqlite_where();
            }
        }

        private void sqlite_where() // 검색한 항목 나오게 하는 함수
        {
            String sqlSQL = search_tb.Text;
            if (sqlSQL == "")
            {
                MessageBox.Show("검색할 문자를 입력해주세요");
                return;
            }
            sqlSQL = sqlSQL.Replace(" ", "%");  //스페이스봐 문자 %변경
            sqlSQL = select_str[db_item] + " where name like \"%" + sqlSQL + "%\" ORDER BY name asc;";  // 쿼리 조합
            sqlite.DB_Select(db_item, item_view, sqlSQL);
            search_tb.Text = "";    //검색박스 검색글 초기화
            item_view.CurrentCell = null;   //목록선택해제
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e) //이미지 박스 크기 변경
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void item_view_KeyUp(object sender, KeyEventArgs e) //아이템 리스트 ESC키 누를시 전체 리스트 불러오기
        {
            if (e.KeyCode == Keys.Escape)    //검색 박스에서 엔터키를 누를시
            {
                sqlite.DB_Select(db_item, item_view, select_str[db_item] + " ORDER BY name asc");  //리스트 불러오기
                item_view.CurrentCell = null;   //목록선택해제
            }
        }

        private void item_view_click(object sender, DataGridViewCellEventArgs e)    //아이템뷰 항목클릭시
        {
            int i = 0;

            if (item_view.CurrentRow == null) return;   //선택창에 아무 항목도 없을시

            int rowIndex = item_view.CurrentRow.Index;      //현재 선택 창 가져오기
            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    if (i == 1) i += 2;
                    if (i == 6) i++;
                    ctl.Text = item_view.Rows[rowIndex].Cells[i++].Value.ToString();    //문자 가져오기
                }
                if (i == 11) break;
            }
            String img = img_tb.Text;
            if (img == "")
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
                return;
            }
            img = "./Img/" + img;
            try
            {   // memorystream 으로 이미지 잠김 방지
                byte[] memimg = File.ReadAllBytes(img);
                MemoryStream ms = new MemoryStream(memimg);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Close();
               // pictureBox1.Image = Bitmap.FromFile(img);
            }
            catch (Exception)
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
 
       }

        private void list_doubleClick(object sender, DataGridViewCellEventArgs e) //리스트 항목 더블클릭시
        {
            int rowIndex = list_view.CurrentRow.Index;      //현재 선택 창 가져오기
            String list = list_view.Rows[rowIndex].Cells[0].Value.ToString();

            String strSQL = select_str[db_item] + " where list ='" + list + "';";
            sqlite.DB_Select(db_item, item_view, strSQL);
            list_view.CurrentCell = null;   //리스트선택해제
            item_view.CurrentCell = null;   //목록선택해제
        }

        private void select_option(int dbfile, DataGridView view)//테이블 속성 설정
        {
            int column = view.Columns.Count;
            for (int i = 0; i < column; i++)
            {
                view.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;     //사이즈조정금지
                view.Columns[i].ReadOnly = false;    //입력금지
                if (dbfile == db_item) view.Columns[i].FillWeight = col_wid[i];    //물품 창리스트 정렬
                if (dbfile == db_item && i == 0) continue;   //0번(물품명)만 소트 되게 설정
                view.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;  //소트금지
            }
        }

        
        private void barcode_bt_Click(object sender, EventArgs e)//바코드 버튼 클릭
        {
            if (item_view.CurrentRow == null)
            {
                MessageBox.Show("인쇄하실 제품을 클릭해주세요");
                return;   //선택창에 아무 항목도 없을시
            }
            int rowIndex = item_view.CurrentRow.Index;      //현재 선택 창 가져오기

            Group_Add f4_list = new Group_Add("바코드 생성 개수를 적어주세요.\n(1~10)", 3);
            f4_list.ShowDialog();
            if (varcode_num == -1) return;   // 개수가 0일떄 실행 안함
            String item = item_view.Rows[rowIndex].Cells[item_ro].Value.ToString();
            String cash = item_view.Rows[rowIndex].Cells[card_ro].Value.ToString();
            String varcode = item_view.Rows[rowIndex].Cells[varcode_ro].Value.ToString();
            cash = string.Format("{0:n0}", Convert.ToInt32(cash));
            print.Barcode_Print(item, cash, varcode, varcode_num);
            varcode_num = -1; //바코드 생성 숫자 초기화
        }
    }
}
