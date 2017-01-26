using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.SqliteDB;
using Project.Sharing;
using Project.Frame3_Form;

namespace Project
{
    public partial class Frame3 : UserControl
    {
        Sqlite_option sqlite = new Sqlite_option();
        int db_item = 0, db_list = 1, db_imfromation = 2 , look_item = 3;
        int ERROR = 1;
        public static int incash = 0;   //입금 금액정보
        public static int payment_re = 0;
        public static int back_item = 0;

        String[] select_SQL = {//" SELECT name as \"물품명\", incash as \"매입단가\", amount as \"수량\""+
                               //",varcode as \"바코드\" from master"
                               ""
                               ,///////////////////0
                         "SELECT name as \"도매상\" ,total_cash as \"금액\" FROM WHOLESALE ORDER BY name asc"
                        , ///////////////////1
                         "SELECT day as \"날짜\", item as \"물품명\", item_code as \"물품코드\",incash as \"매입단가\","+ 
                         "quantity as \"수량\",total_cash as \"합계금액\",wholesale as \"도매상\", "+
                         "varcode as \"바코드\""+
                         " FROM imformation"
                         ,//////////////////2
                         "SELECT name as \"물품명\", item_code as \"물품 코드\", varcode as \"바코드\" FROM master"
                         /////////////////3
                     };
        String[] delect_SQL ={  "",
                                 "DELETE from WHOLESALE where name = \""
                              };
        String[] update_SQL = {
                                  "UPDATE WHOLESALE SET total_cash = {1} where name =\'{0}\'"
                              };
        String insert_query = "INSERT INTO imformation VALUES(\"{0}\",\"{1}\",{2},{3},{4},\"{5}\",\"{6}\",\"{7}\" );";
        
        String[] sql_str = {" where varcode like \"{0}\" and day like \"{1}%\";"
                                   ,
                                " where wholesale like \"{0}\" and day like \"{1}%\"" };
        String where = " where day like \"" + MainForm.dt.ToString("yyyy\\/MM") + "%\"";
        String[] rine_Up = { " ORDER BY name asc", " ORDER BY day asc" };
        int rine_name_rm = 0;   // 정렬 name 번호
        int count = 0;
        int[] col_wid = { 160, 200,80, 80, 80, 110, 100, 98};
        int[] list_wid = { 100, 69};
        int[] search_wid = {135,60,1 };

        public Frame3()
        {
            InitializeComponent();
            search_combo.SelectedIndex = 0;
            sqlite.DB_Select(db_list, list_view, select_SQL[db_list]);  //리스트 불러오기
            //해당 월에만 검색 하도록 설정
            sqlite.DB_Select(db_imfromation,item_view, select_SQL[db_imfromation]+where);
            sqlite.DB_Select(db_item, search_view, select_SQL[look_item] + rine_Up[rine_name_rm]);
            month_combo.SelectedIndex = 0;  // 월 콤보 박스
            year_combo.Hide();
            month_combo.Hide(); 

            select_option(db_list,list_view);
            select_option(db_imfromation,item_view);
            select_option(look_item, search_view);
        }

        private void wholesale_in_Click(object sender, EventArgs e) //도매상 추가
        {
            Group_Add f4_list = new Group_Add("도매상 상호명을 적어주세요.", 1);
            f4_list.ShowDialog();
            sqlite.DB_Select(db_list, list_view, select_SQL[db_list]);  //리스트 불러오기
        }

        private void wholesale_del_click(object sender, EventArgs e)    //도매상 삭제
        {
            try
            {
                if (list_view.CurrentCell == null)      //도매상 항목 선택을 안했을떄
                {
                    MessageBox.Show("삭제 할 항목을 선택해주세요");
                    return;
                }
                int rowIndex = list_view.CurrentRow.Index;      //현재 선택 창 가져오기
                String str = list_view.Rows[rowIndex].Cells[0].Value.ToString();    //문자 가져오기

                DialogResult result = MessageBox.Show(list_view.Rows[rowIndex].Cells[0].Value.ToString() + " 삭제하시겠습니까?", "삭제항목", MessageBoxButtons.OKCancel);
                 if (result == System.Windows.Forms.DialogResult.OK) //삭제 확인 클릭시
                 {
                     String strSQL = delect_SQL[db_list] + str + "\"";
                     int callback = sqlite.DB_Delete(db_list, strSQL);
                     if (callback == ERROR)
                     {
                         MessageBox.Show("삭제실패");
                         return;
                     }
                     sqlite.DB_Select(db_list, list_view, select_SQL[db_list]); // 도매상 리스트 불러오기

                     MessageBox.Show("삭제가 완료 되었습니다.");
                 }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void SelectedIndexchanged(object sender, EventArgs e)   //아이템 search 박스 변경시
        {

            if (count++ == 0)   //한번만 실행  
            {
                int year = int.Parse(MainForm.year_str);    // 현재 몇년도인지 가져오기
                for (int i = year; i >= 2016; i--)  // 2016 - 가져온 몇도  부터 생성
                {
                    year_combo.Items.Add(i + "");
                }
                year_combo.SelectedIndex = 0;
                    return;
            }
           String combo_str = search_combo.SelectedItem.ToString();

           if (combo_str.Equals("일별"))  //
           {
               year_combo.Hide();
               month_combo.Hide();
               dateTimePicker1.Show();
           }
           else if (combo_str.Equals("월별"))
           {
               dateTimePicker1.Hide();
               month_combo.Show();
               month_combo.SelectedIndex = month_combo.FindStringExact(MainForm.dt.Month+"월");
               year_combo.Show();
           }
           else //기간별
           {
               dateTimePicker1.Hide();
               month_combo.Hide();
               year_combo.Show();
           }
         
        }

        private void select_option(int dbfile, DataGridView view)//테이블 속성 설정
        {
            int column = view.Columns.Count;
            
            for (int i = 0; i < column; i++)
            {
                view.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;     //사이즈조정금지
                view.Columns[i].ReadOnly = false;    //입력금지
                if (dbfile == db_imfromation) view.Columns[i].FillWeight = col_wid[i];    //물품 창리스트 정렬
                else if (dbfile == db_list) view.Columns[i].FillWeight = list_wid[i];
                else view.Columns[i].FillWeight = search_wid[i];
                if (i == 0 && dbfile == db_imfromation) continue;
                view.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;  //소트금지
            }
            if (dbfile == look_item) view.Columns[2].Visible = false;   // 바코드 단가 안보이게
            
        }

        private void imfor_Bt_Click(object sender, EventArgs e) //추가 버튼 클릭
        {
           
            if (list_view.CurrentCell == null)// 도매상을 클릭 안했을때
            {
                MessageBox.Show("도매상 정보를 클릭해주세요.");
                return;
            }
            F3_ImforAdd f3 = new F3_ImforAdd(list_view);
            f3.ShowDialog();
            sqlite.DB_Select(db_imfromation, item_view, select_SQL[db_imfromation] + where); // 아이템 정보 불러오기
            sqlite.DB_Select(db_list, list_view, select_SQL[db_list]);  //도매상 리스트 불러오기
        }



        private void full_payment_Click(object sender, EventArgs e) // 완불 버튼 클릭
        {
            
            int all_input = 1; //전부 입금 숫자
            String[] str = new String[2];
            int callback = search(str);
            if (callback == 1) return;

            ///////// 완불 여유 확인
            DialogResult result;
            result = MessageBox.Show("완불 하시겠습니까?", "완불결정", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.Cancel) //완불 취소 클릭시
            {
                return;
            }
            //////////
            input_cash(str, all_input);

        }

        private void payment_Click(object sender, EventArgs e)
        {
            int choice = 2;
            Group_Add group = new Group_Add("입금 하신 금액을 입력해주세요", choice);
           
            String[] str = new String[2];   //도매상이름, 금액
            int callback = search(str);   //오류 검색
            if (callback == 1) return;

            group.ShowDialog();

            if (payment_re++ == -1)
            {
                return;
            }
            input_cash(str, choice);
        }

        private int search(String[] str)    //오류 검색
        {
            if (list_view.CurrentCell == null)// 도매상을 클릭 안했을때
            {
                MessageBox.Show("도매상 정보를 클릭해주세요.");
                return 1;
            }
            int rowIndex = list_view.CurrentRow.Index;      //현재 선택 창 가져오기
            for (int i = 0; i < 2; i++)
            {
                str[i] = list_view.Rows[rowIndex].Cells[i].Value.ToString();    //문자 가져오기
            }
            if (str[1].Equals("0"))     //입금할 금액이 0이면
            {
                MessageBox.Show("입금할 금액이 없습니다.");
                return 1;
            }

            return 0;
        }

        private void input_cash(String[] str,int choice)
        {
            int update = 0;
            int total_cash = Convert.ToInt32(str[1]);   //도매상 현재 금액 가져오기
            int total_rm = 4 , incash_rm = 3,  cash_rm = 2;


            String day = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");   //현재 시간 가져오기
            day = day.Replace("-", "/");    // "-" -> "/"  변경
            String[] str_query = { day, "입금", "0", "0", "0", str[0], "-", "-" };
            if (choice == 2)    // 입금 버튼 클릭시 
            {
                if (total_cash - incash < 0) str_query[total_rm] = "0";    //기존금액 - 입금 금액이 -면 0으로 입력
                else str_query[total_rm] = total_cash - incash + "";    //합계금액 - 입력 금액
                str_query[incash_rm] = incash * -1 + "";    // 정수 -로 바꾸기
            }
            else //완불 버튼 클릭시
            {
                
                str_query[incash_rm] = total_cash * -1 + "";    //정수를 음수로 변경
                str_query[total_rm] = "0";  //완불이기 떄문에 합계금액 창에 0으로 표시
            }
            str_query[cash_rm] = total_cash + "";
            String query = String.Format(insert_query, str_query); //insert 쿼리 생성\
            sqlite.DB_Insert(db_imfromation, query); //입력

            str[1] = str_query[total_rm]; //str (도매상 금액) <- 계산된 토탈 금액

            query = String.Format(update_SQL[update], str);  //업데이트 쿼리 생성 
            sqlite.DB_update(db_list, query);       //업데이트

            sqlite.DB_Select(db_imfromation, item_view, select_SQL[db_imfromation] + where);    //입력 리스트 불러오기
            sqlite.DB_Select(db_list, list_view, select_SQL[db_list]);  //도매상 리스트 불러오기
            MessageBox.Show("금액 정산이 완료되었습니다");
        }

        private void item_search_Click(object sender, EventArgs e)  //검색 클릭시
        {
            int radio;
            String select_str = "";
            String sum = "select sum(total_cash) from imformation"; // 검색 전체 합계 금액 조회
            String query = select_SQL[db_imfromation];
            String day = "";
            int total_sum;
            int db_file = db_imfromation;   //검색 db 파일이 변경 될수 있음
            int varcode = 2, whosale = 0;

            //////////라디오 버튼 확인///////////
            if (radio_bt1.Checked)  // 물품
            {
                int rowIndex = search_view.CurrentRow.Index;      //현재 선택 창 가져오기
                select_str = search_view.Rows[rowIndex].Cells[varcode].Value.ToString();     //문자 가져오기
                radio = 0; //물품
            }
            else //도매상
            {
                int rowIndex = list_view.CurrentRow.Index;      //현재 선택 창 가져오기
                select_str = list_view.Rows[rowIndex].Cells[whosale].Value.ToString();    //문자 가져오기
                radio = 1;   //도매상
            }
            //////////////////////////////////    
 
            if (search_combo.Text.Equals("일별"))
            {
                day = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                day = day.Replace("-", "/");    // "-" -> "/"  변경

                int year = Convert.ToInt32( dateTimePicker1.Value.ToString("yyyy"));
                if(year < 2016 || year >Convert.ToInt32(MainForm.year_str) )
                {/// 2016 보다 작으면 검색 결과 없으므로 리턴시킴
                    MessageBox.Show("해당 데이터는 없습니다.");
                    return;
                }
            }
            else if (search_combo.Text.Equals("월별"))
            {
                day = year_combo.Text + "/" + month_combo.Text;
                day = day.Replace("월", "");    // "-" -> "/"  변경
            }
            else if (search_combo.Text.Equals("연도별"))
            {
                day = year_combo.Text ;
            }
            else
            {

            }
            query += String.Format(sql_str[radio], select_str, day);
            sum += String.Format(sql_str[radio], select_str, day);

            if (!(day.Substring(0, 4).Equals(MainForm.year_str)))   //해당연도와 틀리면
            {
                db_file = 3;
                sqlite.DB_Select_setting(day.Substring(0, 4));  //디비 파일설정
            }

            sqlite.DB_Select(db_file, item_view, query); // 아이템 정보 불러오기
            sum += " and item != \"입금\"";   //입금항목이 토탈 금액에 추가 되는 부분 방지
            total_sum = sqlite.DB_Sum(db_file, sum); //검색어 토탈 금액 불러오기
            if (total_sum == -1)
            {
                MessageBox.Show("검색 결과가 없습니다.");
                sum_Tb.Text = "";
                return;
            }
            sum_Tb.Text = string.Format("{0:n0}", total_sum);
        }

        private void button1_Click(object sender, EventArgs e)  //검색 클릭
        {
            item_select(search_tb.Text);
            search_tb.Text = "";
        }

        private void item_select(String text)   // 물품 검색 텍스트
        {
            text = text.Replace(" ", "%");  //스페이스봐 문자 %변경
            String sql = " where name like \"%{0}%\" ORDER BY name asc";
            sql = string.Format(select_SQL[look_item] + sql, text);
            sqlite.DB_Select(db_item, search_view, sql);
            search_tb.Text = "";
        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e) //엔터키 누를시
        {
            if (e.KeyCode == Keys.Enter)    //검색 박스에서 엔터키를 누를시
            {
                item_select(search_tb.Text);
                
            }
        }

        private void tBack_bt_Click(object sender, EventArgs e) //반품 버튼 클릭시
        {
            int varcode = 7, count = 4;
            int rowIndex = item_view.CurrentRow.Index;      //현재 선택 창 가져오기
            String str = item_view.Rows[rowIndex].Cells[varcode].Value.ToString();    //문자 가져오기
            int amount = Convert.ToInt32(item_view.Rows[rowIndex].Cells[count].Value.ToString());

            if (str.Equals("-"))    //바코드 입금을 확인
            {
                MessageBox.Show("입금은 반품이 불가능 합니다");
                return;
            }
            Group_Add group = new Group_Add("반품하실 개수를 입력해주세요",4);
            group.ShowDialog();

            if (back_item == -1)  return;   //취소 눌렀을시
            
            if(back_item <= 0 || back_item > amount)  // 0보다 작거나 현재 수량보다 크면
            {
                MessageBox.Show("정확한 수량을 확인해주세요");
                return;
            }
            

        }
    }
}
