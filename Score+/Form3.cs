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
    public partial class Kata : Form
    {
        private Form prevForm2;
        private int sm = 0;
        private int r1 = 0;
        private int r2 = 0;

        public Kata(Form callingForm)
        {
            InitializeComponent();
            prevForm2 = callingForm;

            this.ologo.Image = new Bitmap(Properties.Settings.Default.organizationlogo);
            this.tname.Text = Properties.Settings.Default.tournamentname;
            this.oname.Text = Properties.Settings.Default.organizationname;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;

            ToolTip t = new ToolTip();
            t.SetToolTip(closebutton, "Exit application");
            t.SetToolTip(backtostart, "Bck to Previous Section");
            t.SetToolTip(Minimizebtn, "Minimize");

            J7btn.Checked = true;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            foreach (Form openf in Application.OpenForms)
            {
                if (openf.Name != "Form1")
                {
                    openf.Close();
                }
            }
            Application.Exit();
        }

        private void Backtostart_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm2.Show();
        }

        private void J7btn_CheckedChanged(object sender, EventArgs e)
        {
            if(J7btn.Checked)
            {
                J6.Enabled = true;
                J7.Enabled = true;
                J6.Visible = true;
                J7.Visible = true;

                J6l.Visible = true;
                J7l.Visible = true;
            } else
            {
                J6.Enabled = false;
                J7.Enabled = false;
                J6.Visible = false;
                J7.Visible = false;

                J6l.Visible = false;
                J7l.Visible = false;
            }
        }

        private void J5btn_CheckedChanged(object sender, EventArgs e)
        {
            if (J5btn.Checked)
            {
                J6.Enabled = false;
                J7.Enabled = false;
                J6.Visible = false;
                J7.Visible = false;

                J6l.Visible = false;
                J7l.Visible = false;
            } else
            {
                J6.Enabled=true;
                J7.Enabled=true;
                J6.Visible=true;
                J7.Visible=true;

                J6l.Visible=true;
                J7l.Visible=true;
            }
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int n1=int.Parse(J1.Text);
                int n2=int.Parse(J2.Text);
                int n3=int.Parse(J3.Text);
                int n4=int.Parse(J4.Text);
                int n5=int.Parse(J5.Text);
                r1=Math.Min(n1, Math.Min(n2, Math.Min(n3, Math.Min(n4,n5))));
                r2=Math.Max(n1, Math.Max(n2, Math.Max(n3, Math.Max(n4, n5))));
                sm=n1+n2+n3+n4+n5;
                if (J7btn.Checked)
                {
                    int n6 = int.Parse(J6.Text);
                    int n7 = int.Parse(J7.Text);
                    sm += n6 + n7;
                    r1 = Math.Min(r1, Math.Min(n6, n7));
                    r2 = Math.Max(r2, Math.Max(n6, n7));
                }
                sm=sm-r1-r2;

                fscore.Text = sm.ToString();
                r1score.Text = r1.ToString();
                r2score.Text = r2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter Numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            J1.Text = string.Empty;
            J2.Text = string.Empty;
            J3.Text = string.Empty;
            J4.Text = string.Empty;
            J5.Text = string.Empty;
            J6.Text = string.Empty;
            J7.Text = string.Empty;

            fscore.Text = string.Empty;
            r1score.Text = string.Empty;
            r2score.Text = string.Empty;
        }

        private void F_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                prevForm2.Show();
            }
            catch (Exception)
            {
                foreach (Form openf in Application.OpenForms)
                {
                    if (openf.Name != "Form1")
                    {
                        openf.Close();
                    }
                }
                Application.Exit();
            }
            
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
