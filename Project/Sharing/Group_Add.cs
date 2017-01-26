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

namespace Project.Sharing
{
    public partial class Group_Add : Form
    {
        int choice;
        int DB_itemlist = 1;     //list 파일 db
        String[] count_str =    {   
                                "SELECT COUNT(*) FROM list where name =\"{0}\"",  // 물품항목
                                "SELECT COUNT(*) FROM WHOLESALE where  name = \"{0}\"" //도매처 이름
                                };

        String[] insert_str = {   
                                  "insert into list (name) VALUES(\"{0}\")"  ,     // 물품항목
                                  "insert into WHOLESALE (name,total_cash) VALUES(\"{0}\",{1})"// 도매처 이름
                              };

        int[] dbfile = { 1, 1 };

        /**
         *  choice  
         *  0 == 프레임 4 물품 항목 추가
         *  1 == 프레임 3 도매 리스트 추가 
         *  2 == 프레임 3 돈 입금
         *  3 == 프레임 4 바코드 인쇄
         *  4 == 프레임 3 반품 개수
         * */

        public Group_Add(String str, int choice)
        {
            InitializeComponent();
            label1.Text = str;      //라벨에 문자 추가
            textBox.MaxLength = 8;
            this.choice = choice;       //frame4,frame3 에서 물품항목,거래처 등록시 사용하기 위함 스위치
        }
        private void btn2_Click(object sender, EventArgs e) //취소시 삭제
        {
            Frame3.payment_re = -1; //취소시 실행 안됨
            Frame4.varcode_num = -1; //바코드 실행을 안함
            Frame3.back_item = -1;
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e) //확인시 항목 추가
        {
            String strSQL;
            int callback = 0;
            Sqlite_option sqlite = new Sqlite_option();

            textBox.Text = textBox.Text.Replace(" ", "");   //스페이스바 삭제

            if (textBox.Text == "")  //텍스트상자에 아무런 문자가 입력 안되있을시
            {
                MessageBox.Show("단어를 입력해주세요");
                return;
            }

            String list = textBox.Text; //텍스트박스 안 문자 가져오기

            if (choice == 2)    // 프레임 3의 입금이 들어온다면
            {
                f3_input(list);
                this.Hide();
                return;
            }
            else if( choice == 3) //바코드 인쇄
            {
                try
                {
                    int number = Convert.ToInt32(list);
                    if (number > 10 || number < 1)
                    {
                        MessageBox.Show("1 에서 10까지 입력 가능 합니다.");
                        textBox.Text = "";
                        return;
                    }
                    Frame4.varcode_num = number;
                }
                catch (Exception)
                {
                    MessageBox.Show("숫자를 입력해주세요.");
                    textBox.Text = "";
                    return;
                }
                this.Hide();
                return;
            }
            else if (choice == 4)
            {
                try
                {
                    Frame3.back_item = Convert.ToInt32(list);
                    this.Hide();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("정확한 갯수를 입력해주세요");
                    textBox.Text = "";
                    return;
                }
            }
            strSQL = String.Format( count_str[choice] , list);  // 카운트 쿼리 생성
            callback = sqlite.Select_Count_List(DB_itemlist, strSQL);    // 기존리스트에서 추가 리스트 등록여부 확인

            if (callback == 1)
            {
                MessageBox.Show("기존항목이 존재 합니다.");
                this.Hide();    //끝
                return;
            }

           strSQL = String.Format(insert_str[choice], list,0);

            callback = sqlite.DB_Insert(DB_itemlist, strSQL);  //리스트 항목 추가
            if (callback == 1)
            {
                this.Hide();    //끝
                return;
            }

            MessageBox.Show(list + " 추가되었습니다.");        //정상 동작
            this.Hide();
        }
        private void f3_input(String str)
        {
            try
            {
                Frame3.incash = Convert.ToInt32(str);   //숫자만 있다면
                if (Frame3.incash < 0) Frame3.incash = 0;   // 0 보다 작은 값이 들어오면 오류
            }
            catch (Exception)
            {
                Frame3.incash = 0;  
            }
        }

    }
}
