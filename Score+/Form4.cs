using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_
{
    public partial class Fight : Form
    {
        private Form prevForm4;
        private int akaWlevel = 0;
        private int aoWlevel = 0;

        private int akasum = 0;
        private int aosum = 0;
        private int totalSeconds = 0;
        public Fight(Form prevForm)
        {
            InitializeComponent();
            this.prevForm4 = prevForm;

            this.ologo.Image = new Bitmap(Properties.Settings.Default.organizationlogo);
            this.tname.Text = Properties.Settings.Default.tournamentname;
            this.oname.Text = Properties.Settings.Default.organizationname;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;

            ToolTip tts = new ToolTip();
            tts.SetToolTip(closebutton, "Exit application");
            tts.SetToolTip(backtostart, "Back to Previous Section");
            tts.SetToolTip(Minimizebtn, "Minimize");

            this.Timerresetbtn.Enabled = false;
            this.Timerresetbtn.Visible = false;

            this.Timerpausebtn.Enabled = false;
            this.Timerpausebtn.Visible = false;

            for (int i = 0; i < 60; i++)
            {
                this.Mininput.Items.Add(i.ToString());
                this.Secinput.Items.Add(i.ToString());
            }
            this.Mininput.SelectedIndex = 3;
            this.Secinput.SelectedIndex = 0;

            //this.Visible = false;
        }
        // private void Fight_Load(object sender, EventArgs e)
        //{
        //    this.Visible = true;
        //}
        


        private void F_Closing(object sender, EventArgs e)
        {
            try
            {
                if (!prevForm4.IsDisposed)
                {
                    prevForm4.Show();
                }
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

        private void Backtostart_Click(object sender, EventArgs e)
        {
            if (!prevForm4.IsDisposed)
            {
                prevForm4.Show();
                this.Close();
            } else
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

        private void Akasenshu_Click(object sender, EventArgs e)
        {
            if(Akasenshu.BackColor == Color.Transparent)
            {
                Akasenshu.BackColor = Color.Yellow;
                Akasenshu.FlatAppearance.BorderColor = Color.Yellow;
                Akasenshu.ForeColor = Color.Black;
                Akasenshu.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akasenshu.FlatAppearance.MouseDownBackColor = Color.YellowGreen;
                
                Aosenshu.BackColor = Color.Transparent;
                Aosenshu.FlatAppearance.BorderColor = Color.White;
                Aosenshu.ForeColor = Color.White;
                Aosenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aosenshu.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

            } else
            {
                Akasenshu.BackColor = Color.Transparent;
                Akasenshu.FlatAppearance.BorderColor = Color.White;
                Akasenshu.ForeColor = Color.White;
                Akasenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akasenshu.FlatAppearance.MouseDownBackColor = Color.Red;
            }
        }

        private void Aosenshu_Click(object sender, EventArgs e)
        {
            if (Aosenshu.BackColor == Color.Transparent)
            {
                Aosenshu.BackColor = Color.Yellow;
                Aosenshu.FlatAppearance.BorderColor = Color.Yellow;
                Aosenshu.ForeColor = Color.Black;
                Aosenshu.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aosenshu.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akasenshu.BackColor = Color.Transparent;
                Akasenshu.FlatAppearance.BorderColor = Color.White;
                Akasenshu.ForeColor = Color.White;
                Akasenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akasenshu.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                Aosenshu.BackColor = Color.Transparent;
                Aosenshu.FlatAppearance.BorderColor = Color.White;
                Aosenshu.ForeColor = Color.White;
                Aosenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aosenshu.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Akac1_Click(object sender, EventArgs e)
        {
            if(akaWlevel == 1)
            {
                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                akaWlevel = 1;
                Akac1.BackColor = Color.Yellow;
                Akac1.FlatAppearance.BorderColor = Color.Yellow;
                Akac1.ForeColor = Color.Black;
                Akac1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;
            }
        }

        private void Akac2_Click(object sender, EventArgs e)
        {
            if(akaWlevel == 2)
            {
                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                akaWlevel = 2;
                Akac1.BackColor = Color.Yellow;
                Akac1.FlatAppearance.BorderColor = Color.Yellow;
                Akac1.ForeColor = Color.Red;
                Akac1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac2.BackColor = Color.Yellow;
                Akac2.FlatAppearance.BorderColor = Color.Yellow;
                Akac2.ForeColor = Color.Red;
                Akac2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;
            }
        }

        private void Akac3_Click(object sender, EventArgs e)
        {
            if (akaWlevel == 3)
            {
                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                akaWlevel = 3;
                Akac1.BackColor = Color.Yellow;
                Akac1.FlatAppearance.BorderColor = Color.Yellow;
                Akac1.ForeColor = Color.Red;
                Akac1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac2.BackColor = Color.Yellow;
                Akac2.FlatAppearance.BorderColor = Color.Yellow;
                Akac2.ForeColor = Color.Red;
                Akac2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac3.BackColor = Color.Yellow;
                Akac3.FlatAppearance.BorderColor = Color.Yellow;
                Akac3.ForeColor = Color.Red;
                Akac3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;
            }
        }

        private void Akac4_Click(object sender, EventArgs e)
        {
            if (akaWlevel == 4)
            {
                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                akaWlevel = 4;
                Akac1.BackColor = Color.Yellow;
                Akac1.FlatAppearance.BorderColor = Color.Yellow;
                Akac1.ForeColor = Color.Red;
                Akac1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac2.BackColor = Color.Yellow;
                Akac2.FlatAppearance.BorderColor = Color.Yellow;
                Akac2.ForeColor = Color.Red;
                Akac2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac3.BackColor = Color.Yellow;
                Akac3.FlatAppearance.BorderColor = Color.Yellow;
                Akac3.ForeColor = Color.Red;
                Akac3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac4.BackColor = Color.Yellow;
                Akac4.FlatAppearance.BorderColor = Color.Yellow;
                Akac4.ForeColor = Color.Red;
                Akac4.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac4.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;
            }
        }

        private void Akac5_Click(object sender, EventArgs e)
        {
            if (akaWlevel ==5)
            {
                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;
            }
            else
            {
                akaWlevel = 5;
                Akac1.BackColor = Color.Yellow;
                Akac1.FlatAppearance.BorderColor = Color.Yellow;
                Akac1.ForeColor = Color.Red;
                Akac1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac2.BackColor = Color.Yellow;
                Akac2.FlatAppearance.BorderColor = Color.Yellow;
                Akac2.ForeColor = Color.Red;
                Akac2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac3.BackColor = Color.Yellow;
                Akac3.FlatAppearance.BorderColor = Color.Yellow;
                Akac3.ForeColor = Color.Red;
                Akac3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac4.BackColor = Color.Yellow;
                Akac4.FlatAppearance.BorderColor = Color.Yellow;
                Akac4.ForeColor = Color.Red;
                Akac4.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac4.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Akac5.BackColor = Color.Yellow;
                Akac5.FlatAppearance.BorderColor = Color.Yellow;
                Akac5.ForeColor = Color.Red;
                Akac5.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Akac5.FlatAppearance.MouseDownBackColor = Color.YellowGreen;
            }
        }

        private void Aoc1_Click(object sender, EventArgs e)
        {
            if (aoWlevel == 1)
            {
                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                aoWlevel = 1;
                Aoc1.BackColor = Color.Yellow;
                Aoc1.FlatAppearance.BorderColor = Color.Yellow;
                Aoc1.ForeColor = Color.BlueViolet;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Aoc2_Click(object sender, EventArgs e)
        {
            if (aoWlevel == 2)
            {
                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                aoWlevel = 2;
                Aoc1.BackColor = Color.Yellow;
                Aoc1.FlatAppearance.BorderColor = Color.Yellow;
                Aoc1.ForeColor = Color.BlueViolet;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc2.BackColor = Color.Yellow;
                Aoc2.FlatAppearance.BorderColor = Color.Yellow;
                Aoc2.ForeColor = Color.BlueViolet;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Aoc3_Click(object sender, EventArgs e)
        {
            if (aoWlevel == 3)
            {
                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                aoWlevel = 3;
                Aoc1.BackColor = Color.Yellow;
                Aoc1.FlatAppearance.BorderColor = Color.Yellow;
                Aoc1.ForeColor = Color.BlueViolet;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc2.BackColor = Color.Yellow;
                Aoc2.FlatAppearance.BorderColor = Color.Yellow;
                Aoc2.ForeColor = Color.BlueViolet;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc3.BackColor = Color.Yellow;
                Aoc3.FlatAppearance.BorderColor = Color.Yellow;
                Aoc3.ForeColor = Color.BlueViolet;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Aoc4_Click(object sender, EventArgs e)
        {
            if (aoWlevel == 4)
            {
                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                aoWlevel = 4;
                Aoc1.BackColor = Color.Yellow;
                Aoc1.FlatAppearance.BorderColor = Color.Yellow;
                Aoc1.ForeColor = Color.BlueViolet;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc2.BackColor = Color.Yellow;
                Aoc2.FlatAppearance.BorderColor = Color.Yellow;
                Aoc2.ForeColor = Color.BlueViolet;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc3.BackColor = Color.Yellow;
                Aoc3.FlatAppearance.BorderColor = Color.Yellow;
                Aoc3.ForeColor = Color.BlueViolet;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc4.BackColor = Color.Yellow;
                Aoc4.FlatAppearance.BorderColor = Color.Yellow;
                Aoc4.ForeColor = Color.BlueViolet;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc4.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Aoc5_Click(object sender, EventArgs e)
        {
            if (aoWlevel == 5)
            {
                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                aoWlevel = 5;
                Aoc1.BackColor = Color.Yellow;
                Aoc1.FlatAppearance.BorderColor = Color.Yellow;
                Aoc1.ForeColor = Color.BlueViolet;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc1.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc2.BackColor = Color.Yellow;
                Aoc2.FlatAppearance.BorderColor = Color.Yellow;
                Aoc2.ForeColor = Color.BlueViolet;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc2.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc3.BackColor = Color.Yellow;
                Aoc3.FlatAppearance.BorderColor = Color.Yellow;
                Aoc3.ForeColor = Color.BlueViolet;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc3.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc4.BackColor = Color.Yellow;
                Aoc4.FlatAppearance.BorderColor = Color.Yellow;
                Aoc4.ForeColor = Color.BlueViolet;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc4.FlatAppearance.MouseDownBackColor = Color.YellowGreen;

                Aoc5.BackColor = Color.Yellow;
                Aoc5.FlatAppearance.BorderColor = Color.Yellow;
                Aoc5.ForeColor = Color.BlueViolet;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
                Aoc5.FlatAppearance.MouseDownBackColor = Color.YellowGreen;
            }
        }

        private void Akap1_Click(object sender, EventArgs e)
        {
            akasum += 1;
            akascore.Text = akasum.ToString();
        }

        private void Akap2_Click(object sender, EventArgs e)
        {
            akasum += 2;
            akascore.Text = akasum.ToString();
        }

        private void Akap3_Click(object sender, EventArgs e)
        {
            akasum += 3;
            akascore.Text = akasum.ToString();
        }

        private void Akap4_Click(object sender, EventArgs e)
        {
            akasum -= 1;
            akascore.Text = akasum.ToString();
        }

        private void Aop1_Click(object sender, EventArgs e)
        {
            aosum += 1;
            aoscore.Text = aosum.ToString();
        }

        private void Aop2_Click(object sender, EventArgs e)
        {
            aosum += 2;
            aoscore.Text = aosum.ToString();
        }

        private void Aop3_Click(object sender, EventArgs e)
        {
            aosum += 3;
            aoscore.Text = aosum.ToString();
        }

        private void Aop4_Click(object sender, EventArgs e)
        {
            aosum -= 1;
            aoscore.Text = aosum.ToString();
        }

        
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //AKA operations
                Akasenshu.BackColor = Color.Transparent;
                Akasenshu.FlatAppearance.BorderColor = Color.White;
                Akasenshu.ForeColor = Color.White;
                Akasenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akasenshu.FlatAppearance.MouseDownBackColor = Color.Red;

                akaWlevel = 0;
                Akac1.BackColor = Color.Transparent;
                Akac1.FlatAppearance.BorderColor = Color.White;
                Akac1.ForeColor = Color.White;
                Akac1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac1.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac2.BackColor = Color.Transparent;
                Akac2.FlatAppearance.BorderColor = Color.White;
                Akac2.ForeColor = Color.White;
                Akac2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac2.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac3.BackColor = Color.Transparent;
                Akac3.FlatAppearance.BorderColor = Color.White;
                Akac3.ForeColor = Color.White;
                Akac3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac3.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac4.BackColor = Color.Transparent;
                Akac4.FlatAppearance.BorderColor = Color.White;
                Akac4.ForeColor = Color.White;
                Akac4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac4.FlatAppearance.MouseDownBackColor = Color.Red;

                Akac5.BackColor = Color.Transparent;
                Akac5.FlatAppearance.BorderColor = Color.White;
                Akac5.ForeColor = Color.White;
                Akac5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                Akac5.FlatAppearance.MouseDownBackColor = Color.Red;

                akasum = 0;
                akascore.Text = akasum.ToString();
                //AO operations
                Aosenshu.BackColor = Color.Transparent;
                Aosenshu.FlatAppearance.BorderColor = Color.White;
                Aosenshu.ForeColor = Color.White;
                Aosenshu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aosenshu.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                aoWlevel = 0;
                Aoc1.BackColor = Color.Transparent;
                Aoc1.FlatAppearance.BorderColor = Color.White;
                Aoc1.ForeColor = Color.White;
                Aoc1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc2.BackColor = Color.Transparent;
                Aoc2.FlatAppearance.BorderColor = Color.White;
                Aoc2.ForeColor = Color.White;
                Aoc2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc3.BackColor = Color.Transparent;
                Aoc3.FlatAppearance.BorderColor = Color.White;
                Aoc3.ForeColor = Color.White;
                Aoc3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc4.BackColor = Color.Transparent;
                Aoc4.FlatAppearance.BorderColor = Color.White;
                Aoc4.ForeColor = Color.White;
                Aoc4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                Aoc5.BackColor = Color.Transparent;
                Aoc5.FlatAppearance.BorderColor = Color.White;
                Aoc5.ForeColor = Color.White;
                Aoc5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
                Aoc5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);

                aosum = 0;
                aoscore.Text = aosum.ToString();

                //timer operations
                this.Timerresetbtn.Enabled = false;
                this.Timerresetbtn.Visible = false;

                this.Timerpausebtn.Enabled = false;
                this.Timerpausebtn.Visible = false;

                this.Timerstartbtn.Enabled = true;
                this.Timerstartbtn.Visible = true;

                this.Mininput.Enabled = true;
                this.Mininput.Visible = true;

                this.Secinput.Enabled = true;
                this.Secinput.Visible = true;

                totalSeconds = 0;

                this.Timerlabel.Text = "00 : 00";

                this.Timerfight.Enabled = false;
                
            }
            catch (Exception)
            {
                if (!prevForm4.IsDisposed)
                {
                    prevForm4.Show();
                    this.Close();
                } else
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
        }

        private void Timerstartbtn_Click(object sender, EventArgs e)
        {
            this.Timerstartbtn.Enabled = false;
            this.Timerstartbtn.Visible = false;

            this.Timerresetbtn.Enabled = true;
            this.Timerresetbtn.Visible = true;

            this.Timerpausebtn.Enabled = true;
            this.Timerpausebtn.Visible = true;

            this.Mininput.Enabled = false;
            this.Mininput.Visible = false;

            this.Secinput.Enabled = false;
            this.Secinput.Visible = false;

            int minutes = int.Parse(this.Mininput.SelectedItem.ToString());
            int seconds = int.Parse(this.Secinput.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.Timerfight.Enabled = true;

        }

        private void Timerresetbtn_Click(object sender, EventArgs e)
        {
            this.Timerresetbtn.Enabled = false;
            this.Timerresetbtn.Visible = false;

            this.Timerstartbtn.Enabled = true;
            this.Timerstartbtn.Visible = true;

            this.Timerpausebtn.Enabled = false;
            this.Timerpausebtn.Visible = false;

            this.Mininput.Enabled = true;
            this.Mininput.Visible = true;

            this.Secinput.Enabled = true;
            this.Secinput.Visible = true;

            totalSeconds = 0;
            this.Timerfight.Enabled = false;
            this.Timerlabel.Text = "00 : 00";
        }

        private void Timerpausebtn_Click(object sender, EventArgs e)
        {
            if(this.Timerpausebtn.Text == "Pause")
            {
                this.Timerpausebtn.Text = "Play";
                this.Timerfight.Enabled = false;
            } else
            {
                this.Timerpausebtn.Text = "Pause";
                this.Timerfight.Enabled = true;
            }
        }

        private void Timerfight_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds --;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;
                if(minutes < 10 && seconds <10)
                {
                    this.Timerlabel.Text = "0" + minutes.ToString() + " : 0" + seconds.ToString();
                }
                else if(minutes < 10 && seconds >= 10)
                {
                    this.Timerlabel.Text = "0" + minutes.ToString() + " : " + seconds.ToString();
                }
                else
                {
                    this.Timerlabel.Text = minutes.ToString() + " : " + seconds.ToString();
                }
            } else
            {
                this.Timerfight.Stop();
                MessageBox.Show("Time's Up...!");

                this.Timerstartbtn.Enabled = true;
                this.Timerstartbtn.Visible = true;

                this.Timerresetbtn.Enabled = false;
                this.Timerresetbtn.Visible = false;

                this.Timerpausebtn.Enabled = false;
                this.Timerpausebtn.Visible = false;

                this.Mininput.Enabled = true;
                this.Mininput.Visible = true;

                this.Secinput.Enabled = true;
                this.Secinput.Visible = true;
            }
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

    }
}
