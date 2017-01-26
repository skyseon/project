using Project.SqliteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Frame3_Form
{
    public partial class F3_ImforAdd : Form
    {
        List<Panel> list = new List<Panel>();
        int panel_cnt = 1;  //판넬의 개수 확인
        int weight = 223,height = 87;
        int db_item = 0,db_list = 1,db_imfor = 2;
        Sqlite_option sqlite = new Sqlite_option();
        int[] item_wid = { 120, 60,30,60, 50,1};       //물품명 뷰
        String[] select_SQL = { "SELECT name as \"물품명\",item_code as \"제품코드\",amount as \"수량\","  +
                                "incash as \"공급단가\", varcode as \"바코드\", card as \"판매금액\" from master",
                            };
        String[] varcode_list;  //바코드 리스트
        String[] code_list; //아이템코드 리스트
        String[] amount;    //수량 리스트
        String[] card_list;
        string wholesale_str;   //도매상 이름
        int total_sum;      //도매상 금액

        int input_cnt = 1;

        String query = "INSERT INTO imformation VALUES(\"{0}\",\"{1}\",{2},{3},{4},\"{5}\",\"{6}\",\"{7}\");";
        String[] total_query = {"UPDATE WHOLESALE set total_cash =\"{0}\" where name == \"{1}\"",
                              "UPDATE master set amount = {0} where varcode == \"{1}\""
                             };               
                     
        public F3_ImforAdd(DataGridView view)
        {
            int rowIndex = view.CurrentRow.Index;      //아이템 현재 선택 인덱스 가져오기
            wholesale_str = view.Rows[rowIndex].Cells[0].Value.ToString();  //도매상
            total_sum = Int32.Parse(view.Rows[rowIndex].Cells[1].Value.ToString()); //현재 금액

            InitializeComponent();
            down_Bt.Location = new System.Drawing.Point(weight, height);
            up_Bt.Location = new System.Drawing.Point(weight+44, height);
            sql_select();
            item_view.Columns[5].Visible = false;   //입력 수정시 이익률 수정을 위한 임시컬럼
            select_option(db_item,item_view);      //아이템뷰 칼럼 사이즈 지정

            panel_OnOff();  //전체 도매상 창에 도매넣기

            varcode_list = new String[10];   // 중복확인 varcode 초기화
            code_list = new String[10];      // 제품코드 초기화
            amount = new String[10];         // 수량 초기화
            card_list = new String[10];           // 판매금액 초기화
            //////////리스트에 전체 판넬 추가

            foreach (Control ctl in this.Controls)  // 전체 창에 form 가져오기
            {
                if (ctl is Panel)
                {
                    list.Add((Panel)ctl);
                }
            }
        }

        private void down_Bt_Click(object sender, EventArgs e)  //다운 버튼 클릭시
        {
            if (panel_cnt == 10) return;        //10개 이상이면 작동 안함

            height += 40;
            down_Bt.Location = new System.Drawing.Point(weight, height);
            up_Bt.Location = new System.Drawing.Point(weight + 44, height);
            panel_cnt++;
            panel_OnOff();
        }

        private void up_Bt_Click(object sender, EventArgs e)    //업버튼 클릭시
        {
            if (panel_cnt == 1) return;     //1개 이하면 작동 안함
            height -= 40;
            down_Bt.Location = new System.Drawing.Point(weight, height);
            up_Bt.Location = new System.Drawing.Point(weight + 44, height);
            panel_cnt--;
            panel_OnOff();
        }

        private void panel_OnOff()  //panel 업,다운시 활성,비활성 정리
        {
            if (input_cnt > panel_cnt) input_cnt = panel_cnt+1; // +1은 input 넣었던 창에 중복 방지
            for (int i = 1; i < list.Count; i++)
            {
                if (i < panel_cnt) list[i].Visible = true;
                else
                {
                    foreach (Control ctl in list[i].Controls)   //업 버튼 클릭시 들어있는 데이터 초기화
                    {
                        ctl.Text = "";
                    }
                    list[i].Visible = false;
                }
            }
        }

        private void sql_select()
        {
            sqlite.DB_Select(db_item, item_view, select_SQL[db_item] + " ORDER BY name asc;");  //리스트 불러오기
        }

        private void select_option(int dbfile,DataGridView view)//테이블 속성 설정
        {
            int column = view.Columns.Count;
            for (int i = 0; i < column; i++)
            {
                view.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;     //사이즈조정금지
                view.Columns[i].ReadOnly = false;    //입력금지
                if (db_item == dbfile) view.Columns[i].FillWeight = item_wid[i];    //물품 창리스트 정렬
                view.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;  //소트금지
            }
        }

        private void item_view_doubleClick(object sender, MouseEventArgs e)// view 더블클릭시
        {
            int cnt = 0, item = 0, varcode = 4 , item_code = 1, amount_cnt = 2, card_cnt = 5;
            if (input_cnt > panel_cnt) input_cnt = panel_cnt;
            int item_rowIndex = item_view.CurrentRow.Index;      //아이템 현재 선택 인덱스 가져오기
            String item_str = item_view.Rows[item_rowIndex].Cells[item].Value.ToString();    //문자 가져오기
            String varcode_str = item_view.Rows[item_rowIndex].Cells[varcode].Value.ToString();    //바코드 가져오기
            String code_str = item_view.Rows[item_rowIndex].Cells[item_code].Value.ToString(); //물품코드 가져오기
            String amount_str = item_view.Rows[item_rowIndex].Cells[amount_cnt].Value.ToString(); //수량 가져오기
            String card_str = item_view.Rows[item_rowIndex].Cells[card_cnt].Value.ToString();// 판매금액 가져오기
           for (int i = 0; i < input_cnt-1; i++)
           {
                if (varcode_list[i].Equals(varcode_str))    //데이터 중복 확인
                {
                    MessageBox.Show("동일 데이터가 있습니다.");
                    return;
                }
           }

            varcode_list[input_cnt - 1] = varcode_str;  //중복 데이터 확인을 위한 데이터 저장
            code_list[input_cnt - 1] = code_str;    //아이템 코드 넣기
            amount[input_cnt - 1] = amount_str;     //현재 수량 저장
            card_list[input_cnt - 1] = card_str;    //판매 금액 저장

            foreach (Control ctl in list[input_cnt-1].Controls)
            {
                if (cnt == 4) ctl.Text = wholesale_str; // 도매상 tb에 도매상 넣기
                else if (cnt++ == 0)
                    ctl.Text = item_str;    //물품명에 더블클릭 물품 넣기
                else continue;
            }
            input_cnt++;
        }

        private void KeyPress(object sender, KeyPressEventArgs e)   //키보드 입력시 숫자만 가능
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void KeyUp(object sender, KeyEventArgs e)   // 금액,수량 입력시 총금액 넣기
        {
            int incash = 0, amount = 0;
            TextBox tb = (TextBox)sender;
            Control panel = tb.Parent;
            int cnt = 0;
            try
            {
                foreach (Control ctl in panel.Controls)
                {
                    cnt++;
                    if (cnt == 2)   // 공급단가
                    {
                        if (ctl.Text == "") incash = 0;
                        else incash = Convert.ToInt32(ctl.Text);
                    }
                    else if (cnt == 3)  //수량
                    {
                        if (ctl.Text == "") amount = 0;
                        else amount = Convert.ToInt32(ctl.Text);
                    }
                    else if (cnt == 4)  //총 금액
                    {
                        ctl.Text = incash * amount + "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("해당 텍스트에는 문자입력이 금지");
            }
        }

        private void cancel_bt_Click(object sender, EventArgs e)    //취소 눌렀을때
        {
            this.Hide();
        }

        private void search_bt_Click(object sender, EventArgs e) // search버튼 클릭시
        {
            sqlite_where();
        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e)   // 키보드가 눌렸을때 엔터일경우 
        {
            if (e.KeyCode == Keys.Enter)    //검색 박스에서 엔터키를 누를시
            {
                sqlite_where();
            }
        }

        private void sqlite_where() // 찾기 텍스트에서 물품을 찾음
        {
            String search_str = search_tb.Text; //텍스트 가져오기
            search_tb.Text = "";    //텍스트 초기화

            if (search_str.Equals(" ")) // 텍스트가 널일시
            {
                sql_select();
                return;
            }
            search_str = search_str.Replace(" ", "%");  //스페이스봐 문자 %변경
            String sqlSQL = select_SQL[db_item] + " where name like \"%" + search_str + "%\" ORDER BY name asc;";  // 쿼리 조합
            sqlite.DB_Select(db_item, item_view, sqlSQL);  //리스트 불러오기
        }

        private void input_bt_Click(object sender, EventArgs e) //추가 버튼 클릭시
        {
            int query_cnt = 0;
            int total_cnt = 0;
            int day = 0;
            String[][] total_data = new String[10][];
            int inTotal = 0;
            int tax = 0;
            /*
             * 날짜, 물품명, 금액,수량,총금액,도매상,바코드,아이템코드
                0       1     2   3    4      5     6        7
             * */

            for (int i = 0; i < input_cnt-1; i++) //판넬 갯수 만큼 돌림 (데이터 하나 넣을시 +2 차이)
            {
                int cnt = 1;
                String[] data = new String[8];
         
                data[day] = MainForm.dt.ToString("yyyy/MM/dd HH:mm:ss");
                data[day] = data[day].Replace("-", "/");  //-문자 /변경

                foreach (Control ctl in list[i].Controls) // 판넬 데이터 가져오기
                {
                    if (ctl.Text.Equals("")) break; //텍스트박스가 아무것도 없을떄
                    data[cnt] = ctl.Text;     //data 배열에 텍스트 문자 넣기
                    cnt++;
                }
                if (cnt == 6)   //이상없이 전부 데이터를 가져 왔을시
                {
                    if (data[2].Equals("0") || data[3].Equals("0")) continue;   //매입단가, 수량이 0일경우 저장x
                            //3 번은 매입금액 4번은 수량
                    data[6] = varcode_list[i];  //바코드 저장
                    data[7] = code_list[i]; //  아이템 코드 저장
                    total_data[total_cnt] = data;   //데이터 넣기
                    total_cnt++;    //최종 배열 갯수 확인
                    
                 //   total_sum += Convert.ToInt32(data[4]);  //전체 매입 금액 계샨
                    inTotal += Convert.ToInt32(data[4]); // 최종 입금 금액을 알기위해
                }
            }
            if (tax_rb1.Checked == true)    //세금 포함 체크시
            {
                tax = inTotal * 10 / 100;
                inTotal += tax;

               /// VAT(부가세) 포함시 부가세 디비 저장
                String[] str_query = { total_data[0][0], "VAT(부가세)", "0", "0", tax + "", wholesale_str, "-", "-" };
                String str;
                str = String.Format(query, str_query);
                MessageBox.Show(str);
                sqlite.DB_Insert(db_imfor, str);
            }

            total_sum += inTotal;   // 현재 잔액과 입금 금액 합산
            sqlite.DB_Insert_Many(db_imfor, query, total_data, total_cnt);  //데이터 db 저장
            String total_sql = String.Format(total_query[query_cnt++], total_sum, wholesale_str); //데이터 업데이트 쿼리 생성
            sqlite.DB_update(db_list, total_sql);   //토탈값만 업데이트

            for (int i = 0; i < total_cnt; i++) //토탈 수량 저장
            {
               int count =  Convert.ToInt32(amount[i]) + Convert.ToInt32(total_data[i][3]);
               String amount_sql = String.Format(total_query[query_cnt],count,total_data[i][6]);
               sqlite.DB_update(db_item, amount_sql);
            }

            if (input_cb.Checked == true)   //들어온 가격 최신으로 수정
            {
                String query1 = "UPDATE master set incash  = {0}, percent = \"{1}\" where varcode == \"{2}\"";

                for (int i = 0; i < total_cnt; i++) //
                {
                    String percent = (int)((double.Parse(card_list[i]) * 100) / double.Parse(total_data[i][2])) - 100 + "%";

                    String str = String.Format(query1, total_data[i][2], percent, total_data[i][6]);
                    sqlite.DB_update(db_item, str);
                }

            }
            
            this.Hide();    //창 삭제
        }


    }
}
