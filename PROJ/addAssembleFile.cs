using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJ
{
    public partial class addAssembleFile : Form
    {
        public addAssembleFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = true;
            op1.ShowDialog();
            op1.Filter = "File|*.txt";
            Uploadbtn.Text = op1.FileName;
            int count = 0;
            string[] FName;
            foreach (string s in op1.FileNames)
            {
                FName
                     = s.Split('\\');
                count++;
            }
            MessageBox.Show(Convert.ToString(count) + "File(s) Copied");

        }
    }
}
