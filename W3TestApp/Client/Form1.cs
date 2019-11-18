using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        srv.TestContractClient proxy = new srv.TestContractClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srv.User u = proxy.GetNumberOfExecutionTimes(int.Parse(textBox1.Text));

            lbName.Text = u.Name;
            lbCounter.Text = u.Count.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Close();
        }
    }
}
