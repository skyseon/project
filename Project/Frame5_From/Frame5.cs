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

        static String varcode_Key = "";
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

            
            if (sender.Equals(button2))
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }
    }
}
