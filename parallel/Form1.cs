using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace parallel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
 /*         Task T = new Task(() =>
            {
                System.Threading.Thread.Sleep(5000);
                str = "Bahman";
            });
            Task T2 = T.ContinueWith((antecedent) => textBox1.Text = str,
                TaskScheduler.FromCurrentSynchronizationContext());
            T.Start();*/

            Task T1 = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(5000);
                str = "Bahman";
            });

            Task T2 = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(7000);
                str = "Maryam";
            });

            Task T3 = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(9000);
                str = "matin";
            });
            T1.Wait();
            textBox1.Text = str;
        }
    }
}
