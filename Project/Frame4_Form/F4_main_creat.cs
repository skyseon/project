using Project.SqliteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Frame4_Form
{
    public partial class F4_main_creat : Form
    {
        int DB_itemlist = 1;
        int DB_item = 0;
        const int ERORR = 1;
        String varcode_tempo = "";     //수정시 업데이트할 바코드저장
        int insert = 0, update = 1;
        public F4_main_creat(int select,DataGridView view)
        {
            InitializeComponent();
            int callback = combo_select();
            if (select == update) updata_view(view);    //수정버튼 클릭시
            
        }

        private int updata_view(DataGridView view)
        {

            int i = 0;

            int rowIndex = view.CurrentRow.Index;      //현재 선택 창 가져오기

            foreach (Control ctl in this.Controls)  // 수정 뷰에서 문자 가져오기
            {
                if(ctl is TextBox)
                {
                    ctl.Text = view.Rows[rowIndex].Cells[i++].Value.ToString();    //문자 가져오기
                    if (i == 6 || i == 8) i++;
                }
            }
            if (cash_Tb.Text.Equals(card_Tb.Text)) cash_Tb.Text = "";
            combo_Bx.SelectedIndex = combo_Bx.FindStringExact(view.Rows[rowIndex].Cells[8].Value.ToString());
            //FindStringExact 콤보박스에 ()해당 문자열을 찾는다.
            add_bt.Visible = false; //계속 입력 버튼 없애기
            input_bt.Text = "수정";
            input_bt.Location = new System.Drawing.Point(49, 433);
            varcode_tempo = varcode_Tb.Text;        //수정시 바코드를 저장
            amount_tb.ReadOnly = false;     // 수정 허가
            varcode_bt.Visible = false;     //바코드 수정 불가
            return 0;
        }

        private int combo_select()
        {
            Sqlite_option sqlite = new Sqlite_option();

            sqlite.ComboDB_select(DB_itemlist, combo_Bx);
            combo_Bx.SelectedIndex = 0;
            return 0;
        }
        private void KeyPress(object sender, KeyPressEventArgs e)   //키보드 입력시 숫자만 가능
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void varcode_Click(object sender, EventArgs e)  //바코드 생성 버튼
        {
            String tb2_text = inputCash_Tb.Text;     //들어오는 가격
            String tb3_text = card_Tb.Text;     //판매 가격
            String text = "";               //바코드 변수
            Random random = new Random();

            if (tb2_text.Equals("") || tb3_text.Equals("")) //금액을 입력 안했을시
            {
                MessageBox.Show("들어온 금액 이나 판매 금액 입력해주세요");
                return;
            }
            varcode_Tb.Clear();     //바코드 창 초기화
            text = "X" + tb3_text;      //판매가격 추가
            
            //바코드 len을 10을 만들기위한 작업
            int len = 10 - text.Length;

            len = (int) Math.Pow(10, len);  //제곱
           
                len = random.Next(len/10, len);   //랜덤
                text = len + text;


            varcode_Tb.Text = text;     // 바코드 텍스트 창에 입력
        }

        private void cancle_bt_Click(object sender, EventArgs e)    //취소 버튼 클릭시
        {
            this.Hide();
        }

        private void input_bt_Click(object sender, EventArgs e) //추가,수정 버튼
        {
            int call_back = 0;
            if (input_bt.Text.Equals("추가"))
            {
                call_back = input(insert);
            }
            else if (input_bt.Text.Equals("수정"))
            {
                call_back = input(update);
            }

            if(call_back == 0) this.Hide();

        }

        private void add_bt_Click(object sender, EventArgs e)   //추가(계속) 버튼
        {
            int callback = input(insert);
            if (callback == ERORR) return;

            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = null;
                }
            }
            combo_Bx.SelectedIndex = 0;
        }
        private int input(int select)        //입력 정보 추가 클래스
        {
            Sqlite_option sqlite = new Sqlite_option();
            String name = item_Tb.Text;             //물품명
            String inputcash = inputCash_Tb.Text;   //들어오는 금액
            String cash = cash_Tb.Text;             //현금 금액
            String card = card_Tb.Text;             //판매 금액
            String varcode = varcode_Tb.Text;       //바코드
            String combo = combo_Bx.Text;           //콤보박스 선택
            String explain = tb5.Text;              //설명
            String img = img_Tb.Text;            //이미지위치
            String item_code = itemcode_Tb.Text;    //제품코드 
            String amount_str = amount_tb.Text;         //수량
            int amount = 0;                         //수량

            if (card == "" || inputcash == "" || name == "" || varcode == "")
            {
                MessageBox.Show("중요 정보를 입력해주세요");
                return 1;
            }
            if (cash == "")
            {
                cash = card;
            }
            String percent = (int)((double.Parse(card) * 100) / double.Parse(inputcash)) - 100 + "%";//퍼센트 계산

            if (select == insert)   //입력시 0
            {
                String query = "INSERT INTO master VALUES('" + varcode + "','" + name + "'," + int.Parse(inputcash) +
                                                            "," + int.Parse(card) + "," + int.Parse(cash) + ",'" +
                                                            percent + "', '" + combo +
                                                            "','" + img + "','" + explain + "','" + item_code + "',"+amount+");"; //디피바일
                int callback = sqlite.DB_Insert(DB_item, query);
                if (callback == 1)
                {
                    MessageBox.Show("물품명 추가 오류입니다.\n (바코드 중복 확인)");
                    //this.Hide();
                    return 1;
                }
                MessageBox.Show(name + " 입력 완료");
            }
            else           // 수정시 1
            {
                String query = "UPDATE master set " +
                     "varcode        = \"" + varcode               + "\"" +
                     ",amount        =   " + int.Parse(amount_str) +
                     ",name          = \"" + name                  + "\"" +
                     ",incash        =   " + int.Parse(inputcash)  +
                     ",card          =   " + int.Parse(card)       +
                     ",outcash       =   " + int.Parse(cash)       +
                     ",percent       = \"" + percent               + "\"" +
                     ",list          = \"" + combo                 + "\"" +
                     ",file_img      = \"" + img                   + "\"" +
                     ",explanation   = \"" + explain               + "\"" +
                     ",item_code     = \"" + item_code             + "\"" +
                     " where varcode = \"" + varcode_tempo         + "\";";

                int callback = sqlite.DB_update(DB_item, query);
                if (callback == 1)
                {
                    MessageBox.Show("물품명 추가 오류입니다.");
                    this.Hide();
                    return 1;
                }
                MessageBox.Show(name + " 수정 완료");
            }
            return 0;
        }

        private void search_Bt_Click(object sender, EventArgs e)    //이미지 찾기 버튼 클릭
        {
            
            String str = Environment.CurrentDirectory +@"\img"; //현재 오픈하고 있는 창에 img 파일 오픈
            openFile.InitialDirectory = str;   //현재디렉토리 오픈
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)  //파일 이름이 0보다 커야 됨
            {
                this.img_Tb.Text = openFile.SafeFileName;        //파일.확장자 명만 가져오기
            }
        }
    }
}
