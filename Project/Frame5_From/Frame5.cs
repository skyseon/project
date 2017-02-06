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

namespace Project.Frame5_From
{
    public partial class Frame5 : UserControl
    {
        InputDevice id;
        int NumberOfKeyboards;

        public Frame5()
        {
            InitializeComponent();
            id = new InputDevice(Handle);
            NumberOfKeyboards = id.EnumerateDevices();
            id.KeyPressed += new InputDevice.DeviceEventHandler(m_KeyPressed);
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
            MessageBox.Show("Dd");
            
        }

        private void Panel1_Bt_Click(object sender, EventArgs e)
        {
            
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
