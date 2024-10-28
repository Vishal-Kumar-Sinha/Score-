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
    public partial class Form2 : Form
    {
        private Form prevForm1;
        public Form2(Form callingForm)
        {
            InitializeComponent();
            prevForm1 = callingForm;

            this.tname.Text = Properties.Settings.Default.tournamentname;
            this.oname.Text = Properties.Settings.Default.organizationname;
            this.logobox.Image = new Bitmap(Properties.Settings.Default.organizationlogo);

            ToolTip t = new ToolTip();
            t.SetToolTip(closebutton, "Exit application");
            t.SetToolTip(backtostart, "Bck to Previous Section");
            t.SetToolTip(Minimizebtn, "Minimize");
        }

        private void Katabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kata kata = new Kata(this);
            kata.ShowDialog();
        }

        private void Fightbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fight fightscreen = new Fight(this);
            fightscreen.ShowDialog();
        }

        private void Backtostart_Click(object sender, EventArgs e)
        {
            prevForm1.Show();
            this.Close();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                prevForm1.Show();
            }
            catch (Exception)
            {
                Application.Exit();
            }
            
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
