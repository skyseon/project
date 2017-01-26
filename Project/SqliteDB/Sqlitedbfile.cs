using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Project.SqliteDB
{
    
    class Sqlitedbfile
    {

 
        public int File_Create(String file)
        {
            try
            {
                Folder_Create();
                if (System.IO.File.Exists(file) == false)   //파일생성 유무 확인 거짓일 경우
                {
                    System.IO.File.Create(file).Close();    //파일생성
                    return 0;
                }
                
                return -1;   //파일이 있을 경우
            }
            catch(Exception)
            {
                MessageBox.Show("File_Create error");
                return 1;
            }
        }
        public void Folder_Create()    //메인 폴더 생성
        {
            String[] posdb = {"./posdb","./Img"};

            for (int i = 0; i < posdb.Length; i++)
            {
                DirectoryInfo di = new DirectoryInfo(posdb[i]);
                if (di.Exists == false)
                {
                    di.Create();
                }
            }
        }  

    }
}
