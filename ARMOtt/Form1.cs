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
using System.Text.RegularExpressions;

namespace ARMOtt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void BtnSearch_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.    

            Button btnSearch = (Button)sender;
            btnSearch.Enabled = false;        

            // Использую отдельный поток, чтобы можно было работать с Form1.
            await Task.Run(() =>
            {
                string[] files = Directory.GetFiles(tbSearchDirectory.Text, tbNameMask.Text, SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    this.Invoke(new Action(() =>
                    {
                        tbFileOnCheck.Text = file;
                    }));
                }    
            });
            btnSearch.Enabled = true;      

        }

    }
}
