using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Project
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void zapis_Click(object sender, EventArgs e)
        {
            string result = DateTime.Now + "/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/" + koment.Text;
            Check.Read(result,put.Text);
            fail.Text = (Check.Write());
        }

        private void koment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fail_TextChanged(object sender, EventArgs e)
        {

        }

        private void put_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fd = new OpenFileDialog();
            Fd.Title = "Выберите файл";
            Fd.InitialDirectory = @"D:\";
            Fd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (Fd.ShowDialog() == DialogResult.OK)
            {
                put.Text = Fd.FileName;
            }
        }
    }
}
