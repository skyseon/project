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

namespace Project
{
    public partial class Frame1 : UserControl
    {
        const int MAX = 200;        //물품 추가시 최종 개수
        int db_item = 0;
        int search_view_num = 0;
        Sqlite_option sqlite = new Sqlite_option();
        String[] select_str = {
                                  "SELECT name as \"물품명\",item_code as \"제품코드\" ,amount as \"수량\" "+
                                  ",card as \"판매단가\", outcash as \"현금단가\", varcode as \"바코드\" from master"
                              };
        int[] wid_select = {160,80,45,65,1,1};

        String[] rine_Up = { " ORDER BY name asc", " ORDER BY day asc" };
        int rine_name_rm = 0;   // 정렬 name 번호

        Dictionary<String, DicImfor> dic_Infor = new Dictionary<string, DicImfor>();
        List<String> list_Var = new List<String>();
        public Frame1()
        {
            InitializeComponent();
            Search_view_Select();
            sqlite.DB_Binding(db_item, select_str[db_item], dic_Infor);
        }

        private void Search_view_Select()
        {
            sqlite.DB_Select(db_item, search_View, select_str[search_view_num] + rine_Up[rine_name_rm]);
            search_View.Columns[4].Visible = false;   // 현금 단가 컬럼 안보임
            search_View.Columns[5].Visible = false;   // 바코드 단가 컬럼 안보임
            select_option(db_item, search_View);
        }


        private void select_option(int dbfile, DataGridView view)//테이블 속성 설정
        {
            int column = view.Columns.Count;
            for (int i = 0; i < column; i++)
            {
                view.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;     //사이즈조정금지
                view.Columns[i].ReadOnly = false;    //입력금지
                if (dbfile == db_item) view.Columns[i].FillWeight = wid_select[i];    //물품 창리스트 정렬
                if (dbfile == db_item && i == 0) continue;   //0번(물품명)만 소트 되게 설정
                view.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;  //소트금지
            }
        }

        private void search_Bt_Click(object sender, EventArgs e)    //검색 버튼 클릭
        {
            search_dbb();
        }

        private void search_Tb_KeyDown(object sender, KeyEventArgs e) // 검색 텍스트 키보드 입력
        {
            if (e.KeyCode == Keys.Enter)    //검색 박스에서 엔터키를 누를시
            {
                search_dbb();
            }
        }

        private void search_dbb()   // 검색 메소드
        {
            String sqlSQL = search_Tb.Text;

            if (sqlSQL == "")   //서취 박스에 아무 문자가 없을 시 전체 검색
            {
                sqlite.DB_Select(db_item, search_View, select_str[search_view_num]);
                return;
            }
            sqlSQL = sqlSQL.Replace(" ", "%");  //스페이스봐 문자 %변경
            sqlSQL = select_str[db_item] + " where name like \"%" + sqlSQL + "%\"" + rine_Up[rine_name_rm];  // 쿼리 조합
            sqlite.DB_Select(db_item, search_View, sqlSQL);
            search_Tb.Text = "";    //검색박스 검색글 초기화
            item_view.CurrentCell = null;   //목록선택해제

        }

        private void search_View_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /**
              0 : 물품명     // 0 : 물품명
              1 : 제품코드   // 1 : 제품코드
              2 : 수량       // 2 : 수량
              3 : 단가       // 3 : 단가
              4 : 총액       // 4 : 현금
              5 : 표시       // 5 : 바코드
              item_view      // search_view
            */
            int num = 0;
            int view_Varcode = 5;
            int rowNum = 7;
            int rowIndex = search_View.CurrentRow.Index;      //현재 선택 창 가져오기
            String[] search_Str = new String[rowNum];         //기존 데이터 저장

            String varcode = search_View.Rows[rowIndex].Cells[view_Varcode].Value.ToString(); //바코드 가져오기

            if (list_Var.Contains(varcode))     //중복체크
            {
                Oerlap(varcode);
                Total_Cash();
                search_View.CurrentCell = null;
              return;
            }

            search_Str[num++] = dic_Infor[varcode].item;        //물품
            search_Str[num++] = dic_Infor[varcode].item_code;   //물품코드
            search_Str[num++] = "1";                            //수량
            search_Str[num++] = dic_Infor[varcode].cash+"";     //단가
            search_Str[num++] = dic_Infor[varcode].cash + "";   //총액
            //search_Str[num++] = "";
            search_Str[++num]   = "DEL";
            list_Var.Add(varcode);      //바코드 저장

            item_view.Rows.Add(search_Str);
            Total_Cash();
            search_View.CurrentCell = null;
        }

        private void Total_Cash()   // 뷰에 총 금액을 구함
        {
            int numRows = item_view.Rows.Count;
            int view_total = 4;     // 총액 위치
            int total = 0;          //총금액
            String total_str;       // 총액 받아오는 변수
            for (int i = 0; i < numRows; i++)
            {
                total_str = item_view.Rows[i].Cells[view_total].Value.ToString(); //총액 가져오기
                total = total + Convert.ToInt32(total_str); //총액 더하기
            }

            total_Lb.Text = string.Format("{0:n0}", total);
        }

        private void Oerlap(String varcode)
        {
            int amount_Ro = 2, cash_Ro = 3, total_Ro = 4;
            int index = list_Var.IndexOf(varcode);
            if (index == -1) index = Convert.ToInt32(varcode);

            int amount = Convert.ToInt32(item_view.Rows[index].Cells[amount_Ro].Value.ToString());  //수량 가져오기
            int cash = Convert.ToInt32(item_view.Rows[index].Cells[cash_Ro].Value.ToString());      //단가 가져오기

            if(varcode.Length > 5)
                amount += 1;
            item_view.Rows[index].Cells[amount_Ro].Value = amount + "";           // 수량 업데이트
            item_view.Rows[index].Cells[total_Ro].Value = amount * cash + "";     // 총금액 업데이트

        }

        private void item_view_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {// 편집 모드 들어갈때 (숫자만 입력 가능하게 하기 위한 함수)
            String name = item_view.CurrentCell.OwningColumn.Name;
            if (name == "amount" || name == "card") //
            {
                 e.Control.KeyPress += new KeyPressEventHandler(txtCheckNumeric_KeyPress);
            }
            else
            {
                e.Control.KeyPress -= new KeyPressEventHandler(txtCheckNumeric_KeyPress);
            }
        }
        private void txtCheckNumeric_KeyPress(object sender, KeyPressEventArgs e)   //item_view 칼럼 숫자만 입력 가능
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void item_view_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String index = item_view.CurrentCell.RowIndex + "";
            Oerlap(index);
            Total_Cash();
        }
    }
    class DicImfor
    {
       public String item;       // 0 : 물품명
       public String item_code;  // 1 : 제품코드
       public int amount;     // 2 : 수량
       public int cash;       // 3 : 단가
       public int money;      // 4 : 현금
       public String varcode;    // 5 : 바코드
    }
}
