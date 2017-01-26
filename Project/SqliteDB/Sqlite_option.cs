using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace Project.SqliteDB
{
    
    class Sqlite_option
    {
        String main_dbFile = ".\\posdb\\";    //디비파일 위치
        String[] db_serch = { "all.dbb","list.dbb",MainForm.year_str+".dbb",  "" };
                             //물품리스트,  물품           현재 년 디비       선택디비
                             //    0        1               2                  3
        String[] dbtable = {    
                               "CREATE TABLE master(    "+
		                       "varcode 		TEXT PRIMARY KEY,  "+	//바코드
		                       "name			TEXT,"              +	//물품명
		                       "incash		 	INTEGER,  "         +	//공급단가
		                       "card 			INTEGER,  "         +	//판매단가
		                       "outcash         INTEGER,  "         +	//현금단가
		                       "percent		    TEXT,  	  "         +	//이익율
		                       "list			TEXT,	  "         +	//항목
		                       "file_img    	TEXT,     "         +	//파일 이미지 위치
		                       "explanation 	TEXT,     "         +	//설명
                               "item_code       TEXT,     "         +   //제품코드 
                               "amount          INTEGER   "         +   //수량
		                       ");",
                               /////////////////////////////////
                               "CREATE TABLE LIST (name TEXT PRIMARY KEY);" + 
                               "INSERT INTO LIST VALUES ('기타');" +
                               "CREATE TABLE WHOLESALE ("+
                               "name TEXT PRIMARY KEY,  "+
                               "total_cash INTEGER);"
                               ,
                               ///////////////////////////  
                               "CREATE TABLE imformation( "+
		                       "day 			TEXT     ,"+	//날짜
		                       "item			TEXT     ,"+	//물품명
		                       "incash		 	INTEGER  ,"+	//공급단가
                               "quantity        INTEGER  ,"+	//수량
                               "total_cash      INTEGER  ,"+    //매입금액
		                       "wholesale 		TEXT     ,"+	//도매상
                               "varcode		    TEXT     ,"+	//바코드
                               "item_code       TEXT       "+    //제품코드
		                       ");",
                               ///////////////////////////
                           };

        String[] select_str = {
                                  "SELECT name as \"제품명\" FROM list",//1
                                  "SELECT name as \"물품명\", item_code as \"제품코드\", incash as \"공급단가\","+
                                  "card as \"판매단가\", outcash as \"현금단가\","+
                                  "percent as \"퍼센트\", varcode as \"바코드\", list as \"항목\","+
                                  "file_img as \"이미지위치\",explanation as \"설명\" "+
                                  " from master"//2
                              };

        Sqlitedbfile sqlifi = new Sqlitedbfile();   //디비,파일 생성클래스

        //물품명,제품코드,공급, 판매, 현금,% ,바코드, 항목,  img,  설명

       private int Create_Tabledb(int num)   //테이블 생성
       {
           
            String confile = main_dbFile + db_serch[num];    //해당 위치/파일이름
            if (num == 3) num -= 1; //db 생성시 3은 없기 떄문에 똑같은 imformation db로 생성 하기위해
            int callback = sqlifi.File_Create(confile); //파일 생성
           
            if (callback == 1)  return 1; //파일 생성 오류 
            if (callback == -1) return 0; //파일 생성되어있을떄

            confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
   
            try
            {
                SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
                   
                conn.Open();        //db오픈
                SQLiteCommand sqlcmd = new SQLiteCommand(dbtable[num], conn);   //명령어 실행
                sqlcmd.ExecuteNonQuery();
                
                sqlcmd.Dispose();
                conn.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 1;
            }

            return 0;
       }
       public int Select_Count_List(int dbfile, String strSQL)      //추가할 항목(리스트) 검색
       {
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
            int callback= Create_Tabledb(dbfile);

            if (callback == 1) return 1;

            confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
            try
            {
                SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결

                conn.Open();        //db오픈
                SQLiteCommand sqlcmd = new SQLiteCommand(strSQL,conn);   //명령어 실행
                Int32 count = Convert.ToInt32(sqlcmd.ExecuteScalar());   //명령어 실행 count값 가져오기
                
                sqlcmd.Dispose();
                conn.Close();
                if (count == 0) return 0;       //없으면 0 
                 return 1;                      //있으면 1
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 1;
            }
       }
       public int DB_Insert(int dbfile, String strSQL)  //db 추가(디비파일,데이터)
       {
            String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
            int callback= Create_Tabledb(dbfile);

            if (callback == 1) return 1;

            confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
            try
            {
                SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
                conn.Open();        //db오픈
                SQLiteCommand sqlcmd = new SQLiteCommand(strSQL, conn);   //명령어 실행
                sqlcmd.ExecuteNonQuery();

                sqlcmd.Dispose();
                conn.Close();
                return 0;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
                return 1;
            }
            
       }
       public int DB_Insert_Many(int dbfile, String sql_str,String[][] imfor,int sqlcnt)  //db 추가(디비파일,데이터)
       {
           String str_sql;
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);   //생성

           if (callback == 1) return 1;

           confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
               conn.Open();        //db오픈
               for (int i = 0; i < sqlcnt; i++)
               {
                    str_sql= String.Format(sql_str, imfor[i]);
                    SQLiteCommand sqlcmd = new SQLiteCommand(str_sql, conn);   //명령어 실행
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Dispose();
               }
               conn.Close();
               return 0;

           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return 1;
           }

       }
       public int DB_Select(int dbfile, DataGridView view, String strSQL)   
       {
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);       //DB테이블 생성
           if (callback == 1) return 1;

           confile = @"Data Source=" + confile;    //접속 파일 위치 설정
           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
               conn.Open();        //db오픈
               SQLiteDataAdapter adapter = new SQLiteDataAdapter(strSQL, conn);
               SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
               DataTable dt = new DataTable();

               adapter.Fill(dt);

               view.DataSource = dt;

               conn.Close();
               
               return 0;

           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return 1;
           }
       }    //DB 검색

       public void DB_Select_setting(String db_year)
       //db 셀렉트시 다른 db를 검색하기 위해서 초기설정 필요
       {
           int room = 3;
           db_serch[room] = db_year + ".dbb";
       }
       public int DB_Delete(int dbfile, String strSQL)
       {
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);       //DB테이블 생성

           if (callback == 1) return 1;

           confile = @"Data Source=" + confile;    //접속 파일 위치 설정

           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
               conn.Open();        //db오픈
               SQLiteCommand sqlcmd = new SQLiteCommand(strSQL, conn);   //명령어 실행
               sqlcmd.ExecuteNonQuery();

               sqlcmd.Dispose();
               conn.Close();
               return 0;
           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return 1;
           }
       }//DB 리스트 삭제
       public int DB_update(int dbfile, String update_str)
       {
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);

           if (callback == 1) return 1;
           confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
               conn.Open();        //db오픈
               SQLiteCommand sqlcmd = new SQLiteCommand(update_str, conn);   //명령어 실행
               sqlcmd.ExecuteNonQuery();

               sqlcmd.Dispose();
               conn.Close();
               return 0;

           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return 1;
           }
          
       }//DB 수정

       public int ComboDB_select(int dbfile, ComboBox cbox)  // 제품명 항목리스트 불러오기
       {
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);       //DB테이블 생성

           if (callback == 1) return 1;

           String strSQL = "SELECT * FROM list";
           confile = @"Data Source=" + confile;    //접속 파일 위치 설정 
           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결

               conn.Open();        //db오픈
               SQLiteCommand sqlcmd = new SQLiteCommand(strSQL, conn);   //명령어 실행

               SQLiteDataReader rdr = sqlcmd.ExecuteReader();
               while (rdr.Read())       //리스트 컬럼 읽어오기
               {
                   cbox.Items.Add(rdr["name"]);     //NAME 값 가져오기
               }
               rdr.Close();
               return 0;
           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return 1;
           }


       }

       public int DB_Sum(int dbfile, String sum_str)    //추가
       {
           int total_sum = 0;
           String confile = main_dbFile + db_serch[dbfile];    //해당 위치/파일이름
           int callback = Create_Tabledb(dbfile);       //DB테이블 생성
           if (callback == 1) return 1;
           confile = @"Data Source=" + confile;    //접속 파일 위치 설정

           try
           {
               SQLiteConnection conn = new SQLiteConnection(confile);   //db파일 연결
               conn.Open();        //db오픈

               //SQLiteDataReader를 이용하여 연결 모드로 데이타 읽기
               SQLiteCommand cmd = new SQLiteCommand(sum_str, conn);
               SQLiteDataReader rdr = cmd.ExecuteReader();
               while (rdr.Read())
               {
                   total_sum = Convert.ToInt32(rdr[0]);
               }
               
               rdr.Close();
           }
           catch (Exception e)
           {
               return -1;
           }

           return total_sum;
       }
    }
}
