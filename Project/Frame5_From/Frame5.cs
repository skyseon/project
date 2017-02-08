using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawInput;
using Project.Sharing;

namespace Project.Frame5_From
{
    public partial class Frame5 : UserControl
    {
        InputDevice id;
        int NumberOfKeyboards;

        public Frame5()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message message)
        {
            if (id != null)
            {
                id.ProcessMessage(message);
            }
            base.WndProc(ref message);
        }

        private void m_KeyPressed(object sender, InputDevice.KeyControlEventArgs e)
        {
            usb_Tb.Text = e.Keyboard.deviceName.Replace("&", "&&");
            usb_Lb.Focus();
        }

        private void Panel1_Bt_Click(object sender, EventArgs e)
        {
            
            if (sender.Equals(button2))
            {
                usb_Tb.Text = "";
                usb_Tb.ReadOnly = false;
                id = new InputDevice(Handle);
                NumberOfKeyboards = id.EnumerateDevices();
                id.KeyPressed += new InputDevice.DeviceEventHandler(m_KeyPressed);
            }
            else
            {
                usb_Tb.ReadOnly = true;
                id = null;
            }
        }

        private void P16_print_Bt_Click(object sender, EventArgs e) // 판넬 16 버튼 클릭시
        {
            Print pt = new Print();
            String name = P16_name_Tb.Text;
            String cash = P16_cash_Tb.Text;
            int size = Convert.ToInt32( P16_size_Tb.Text);

            if (size < 15 )
            {
                size = 15;
            }

            if (name == "" || cash == "")
            {
                MessageBox.Show("글자를 입력하세요");
            }
            else
                pt.Adhesion_Print(name, cash, size);
            
            P16_name_Tb.Text = "";
            P16_cash_Tb.Text = "";
            P16_size_Tb.Text = "15";
        }
    }
}
