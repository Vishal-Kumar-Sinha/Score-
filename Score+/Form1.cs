using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();
            t.SetToolTip(closebutton, "Exit application");
            t.SetToolTip(Minimizebtn, "Minimize");
        }

        private string lpath = "";
        private void Logobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;) | *.jpg;*.jpeg;*.png;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                uploadLogoPic.Image = new Bitmap(ofd.FileName);
            }
            //Console.WriteLine(ofd.FileName);
            lpath = ofd.FileName;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Console.WriteLine(lpath);
                if (tnametb.Text.Length > 0 && onametb.Text.Length > 0 && lpath.Length > 0)
                {
                    Properties.Settings.Default.tournamentname = tnametb.Text;
                    Properties.Settings.Default.organizationname = onametb.Text;
                    Properties.Settings.Default.organizationlogo = lpath;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    Form2 form2 = new Form2(this);
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fill up the form properly.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
