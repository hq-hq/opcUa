using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcAsp.Opc;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcClient client = new OpcClient(new Uri("opc.tcp://192.168.130.142:49320"));
            if (client.Connect == OpcStatus.Connected)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("false");
            }
        }
    }
}
