using SamplePg_CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Sharing
{
    class Print
    {
        public void Barcode_Print(String name, String cash, String varcode ,int num)
        {
            int nPositionX = 5;
            int nPositionY = 0;
            int nTextHeight = 0;

            Connect();  //프린터 접속
            
            // Start Document
            if (BXLAPI.Start_Doc("Print Receipt") == false)
                return;
            // Start Page
            BXLAPI.Start_Page();

            for (int i = 0; i < num; i++)
            {
                if (i > 0) nTextHeight *= 2;
                nPositionY += nTextHeight;
                nTextHeight = BXLAPI.PrintTrueFont(nPositionX, nPositionY, "맑은 고딕", 15, cash + "원", false, 0, true, false);
                nPositionY += nTextHeight;
                nTextHeight = BXLAPI.PrintTrueFont(nPositionX, nPositionY, "Korean1x1", 0, name, false, 0, true, false);

                nPositionY += nTextHeight;
                nTextHeight = BXLAPI.PrintDeviceFont(nPositionX, nPositionY, "FontControl", 0, "p");
                nPositionY += nTextHeight;
                nTextHeight = BXLAPI.PrintDeviceFont(nPositionX, nPositionY, "code128", 0, varcode);	// PRINT BARCODE
            }


            BXLAPI.End_Page();	// End Page
            BXLAPI.End_Doc();	// End Document
            Disconnect();
        }

        public void Adhesion_Print(String name, String cash, int size)
        {
            int nPositionX = 5;
            int nPositionY = 0;
            int nTextHeight = 0;

            Connect();  //프린터 접속

            // Start Document
            if (BXLAPI.Start_Doc("Print Receipt") == false)
                return;
            // Start Page
            BXLAPI.Start_Page();

            nPositionY += nTextHeight;
            nTextHeight = BXLAPI.PrintTrueFont(nPositionX, nPositionY, "맑은 고딕", size, cash + "원", false, 0, true, false);
            nPositionY += nTextHeight;
            nTextHeight = BXLAPI.PrintTrueFont(nPositionX, nPositionY, "Korean1x1", size, name, false, 0, true, false);

            BXLAPI.End_Page();	// End Page
            BXLAPI.End_Doc();	// End Document
            Disconnect();
        }


        private void Connect()
        {
            String str = "BIXOLON SRP-350III";
            BXLAPI.ConnectPrinter(str.Trim());
        }

        private void Disconnect()
        {
            BXLAPI.DisconnectPrinter();
        }

    }
}
