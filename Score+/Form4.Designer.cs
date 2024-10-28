using System.Drawing;
using System.Windows.Forms;

namespace Score_
{
    partial class Fight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizebtn = new System.Windows.Forms.Button();
            this.backtostart = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.oname = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.timerpanel = new System.Windows.Forms.Panel();
            this.Timerlabel = new System.Windows.Forms.Label();
            this.Secinput = new System.Windows.Forms.ComboBox();
            this.Mininput = new System.Windows.Forms.ComboBox();
            this.Timerresetbtn = new System.Windows.Forms.Button();
            this.Timerpausebtn = new System.Windows.Forms.Button();
            this.Timerstartbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ologo = new System.Windows.Forms.PictureBox();
            this.Aop4 = new System.Windows.Forms.Button();
            this.Aop3 = new System.Windows.Forms.Button();
            this.Aop2 = new System.Windows.Forms.Button();
            this.Aop1 = new System.Windows.Forms.Button();
            this.Aoc5 = new System.Windows.Forms.Button();
            this.Aoc4 = new System.Windows.Forms.Button();
            this.Aoc3 = new System.Windows.Forms.Button();
            this.Aoc2 = new System.Windows.Forms.Button();
            this.Aoc1 = new System.Windows.Forms.Button();
            this.Aosenshu = new System.Windows.Forms.Button();
            this.aoscore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Akap4 = new System.Windows.Forms.Button();
            this.Akap3 = new System.Windows.Forms.Button();
            this.Akap2 = new System.Windows.Forms.Button();
            this.Akap1 = new System.Windows.Forms.Button();
            this.Akac5 = new System.Windows.Forms.Button();
            this.Akac4 = new System.Windows.Forms.Button();
            this.Akac3 = new System.Windows.Forms.Button();
            this.Akac2 = new System.Windows.Forms.Button();
            this.Akac1 = new System.Windows.Forms.Button();
            this.Akasenshu = new System.Windows.Forms.Button();
            this.akascore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timerfight = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.timerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ologo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Minimizebtn);
            this.panel1.Controls.Add(this.backtostart);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 32);
            this.panel1.TabIndex = 2;
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizebtn.AutoEllipsis = true;
            this.Minimizebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.Minimizebtn.BackgroundImage = global::Score_.Properties.Resources.Subtract;
            this.Minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimizebtn.FlatAppearance.BorderSize = 0;
            this.Minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(135)))));
            this.Minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(105)))));
            this.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebtn.Location = new System.Drawing.Point(1264, 0);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(30, 32);
            this.Minimizebtn.TabIndex = 5;
            this.Minimizebtn.TabStop = false;
            this.Minimizebtn.UseVisualStyleBackColor = false;
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // backtostart
            // 
            this.backtostart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backtostart.AutoEllipsis = true;
            this.backtostart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backtostart.BackColor = System.Drawing.Color.Transparent;
            this.backtostart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtostart.BackgroundImage")));
            this.backtostart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backtostart.FlatAppearance.BorderSize = 0;
            this.backtostart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(135)))));
            this.backtostart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(105)))));
            this.backtostart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtostart.Location = new System.Drawing.Point(1300, 0);
            this.backtostart.Name = "backtostart";
            this.backtostart.Size = new System.Drawing.Size(30, 32);
            this.backtostart.TabIndex = 0;
            this.backtostart.TabStop = false;
            this.backtostart.UseVisualStyleBackColor = false;
            this.backtostart.Click += new System.EventHandler(this.Backtostart_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.BackgroundImage = global::Score_.Properties.Resources.ce;
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(135)))));
            this.closebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(105)))));
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(1334, 0);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(32, 32);
            this.closebutton.TabIndex = 0;
            this.closebutton.TabStop = false;
            this.closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score +";
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::Score_.Properties.Resources.R2;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(36, 32);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Score_.Properties.Resources.bg;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.oname);
            this.panel4.Controls.Add(this.tname);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 130);
            this.panel4.TabIndex = 5;
            // 
            // oname
            // 
            this.oname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oname.FlatAppearance.BorderSize = 0;
            this.oname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.oname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.oname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oname.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oname.Location = new System.Drawing.Point(0, 80);
            this.oname.Name = "oname";
            this.oname.Size = new System.Drawing.Size(1366, 50);
            this.oname.TabIndex = 2;
            this.oname.TabStop = false;
            this.oname.UseVisualStyleBackColor = true;
            // 
            // tname
            // 
            this.tname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tname.FlatAppearance.BorderSize = 0;
            this.tname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tname.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tname.Location = new System.Drawing.Point(0, 0);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(1366, 74);
            this.tname.TabIndex = 1;
            this.tname.TabStop = false;
            this.tname.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Score_.Properties.Resources.fightbg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Resetbtn);
            this.panel2.Controls.Add(this.timerpanel);
            this.panel2.Controls.Add(this.ologo);
            this.panel2.Controls.Add(this.Aop4);
            this.panel2.Controls.Add(this.Aop3);
            this.panel2.Controls.Add(this.Aop2);
            this.panel2.Controls.Add(this.Aop1);
            this.panel2.Controls.Add(this.Aoc5);
            this.panel2.Controls.Add(this.Aoc4);
            this.panel2.Controls.Add(this.Aoc3);
            this.panel2.Controls.Add(this.Aoc2);
            this.panel2.Controls.Add(this.Aoc1);
            this.panel2.Controls.Add(this.Aosenshu);
            this.panel2.Controls.Add(this.aoscore);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Akap4);
            this.panel2.Controls.Add(this.Akap3);
            this.panel2.Controls.Add(this.Akap2);
            this.panel2.Controls.Add(this.Akap1);
            this.panel2.Controls.Add(this.Akac5);
            this.panel2.Controls.Add(this.Akac4);
            this.panel2.Controls.Add(this.Akac3);
            this.panel2.Controls.Add(this.Akac2);
            this.panel2.Controls.Add(this.Akac1);
            this.panel2.Controls.Add(this.Akasenshu);
            this.panel2.Controls.Add(this.akascore);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 606);
            this.panel2.TabIndex = 6;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resetbtn.AutoEllipsis = true;
            this.Resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resetbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Resetbtn.FlatAppearance.BorderSize = 2;
            this.Resetbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.Resetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Image = ((System.Drawing.Image)(resources.GetObject("Resetbtn.Image")));
            this.Resetbtn.Location = new System.Drawing.Point(627, 122);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(124, 40);
            this.Resetbtn.TabIndex = 42;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Resetbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // timerpanel
            // 
            this.timerpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerpanel.BackColor = System.Drawing.Color.Transparent;
            this.timerpanel.BackgroundImage = global::Score_.Properties.Resources.tbg;
            this.timerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timerpanel.Controls.Add(this.Timerlabel);
            this.timerpanel.Controls.Add(this.Secinput);
            this.timerpanel.Controls.Add(this.Mininput);
            this.timerpanel.Controls.Add(this.Timerresetbtn);
            this.timerpanel.Controls.Add(this.Timerpausebtn);
            this.timerpanel.Controls.Add(this.Timerstartbtn);
            this.timerpanel.Controls.Add(this.label9);
            this.timerpanel.Controls.Add(this.label8);
            this.timerpanel.Location = new System.Drawing.Point(495, 164);
            this.timerpanel.Name = "timerpanel";
            this.timerpanel.Size = new System.Drawing.Size(400, 237);
            this.timerpanel.TabIndex = 44;
            // 
            // Timerlabel
            // 
            this.Timerlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Timerlabel.AutoSize = true;
            this.Timerlabel.BackColor = System.Drawing.Color.Transparent;
            this.Timerlabel.Font = new System.Drawing.Font("Book Antiqua", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerlabel.Location = new System.Drawing.Point(47, 36);
            this.Timerlabel.Name = "Timerlabel";
            this.Timerlabel.Size = new System.Drawing.Size(312, 114);
            this.Timerlabel.TabIndex = 9;
            this.Timerlabel.Text = "00 : 00";
            // 
            // Secinput
            // 
            this.Secinput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Secinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secinput.FormattingEnabled = true;
            this.Secinput.IntegralHeight = false;
            this.Secinput.Location = new System.Drawing.Point(287, 155);
            this.Secinput.Name = "Secinput";
            this.Secinput.Size = new System.Drawing.Size(65, 32);
            this.Secinput.TabIndex = 8;
            // 
            // Mininput
            // 
            this.Mininput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mininput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mininput.FormattingEnabled = true;
            this.Mininput.IntegralHeight = false;
            this.Mininput.Location = new System.Drawing.Point(65, 155);
            this.Mininput.Name = "Mininput";
            this.Mininput.Size = new System.Drawing.Size(65, 32);
            this.Mininput.TabIndex = 7;
            // 
            // Timerresetbtn
            // 
            this.Timerresetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Timerresetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerresetbtn.Location = new System.Drawing.Point(280, 197);
            this.Timerresetbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Timerresetbtn.Name = "Timerresetbtn";
            this.Timerresetbtn.Size = new System.Drawing.Size(72, 32);
            this.Timerresetbtn.TabIndex = 6;
            this.Timerresetbtn.Text = "Reset";
            this.Timerresetbtn.UseVisualStyleBackColor = true;
            this.Timerresetbtn.Click += new System.EventHandler(this.Timerresetbtn_Click);
            // 
            // Timerpausebtn
            // 
            this.Timerpausebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Timerpausebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerpausebtn.Location = new System.Drawing.Point(65, 197);
            this.Timerpausebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Timerpausebtn.Name = "Timerpausebtn";
            this.Timerpausebtn.Size = new System.Drawing.Size(63, 32);
            this.Timerpausebtn.TabIndex = 5;
            this.Timerpausebtn.Text = "Pause";
            this.Timerpausebtn.UseVisualStyleBackColor = true;
            this.Timerpausebtn.Click += new System.EventHandler(this.Timerpausebtn_Click);
            // 
            // Timerstartbtn
            // 
            this.Timerstartbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Timerstartbtn.BackColor = System.Drawing.Color.Transparent;
            this.Timerstartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerstartbtn.Location = new System.Drawing.Point(170, 197);
            this.Timerstartbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Timerstartbtn.Name = "Timerstartbtn";
            this.Timerstartbtn.Size = new System.Drawing.Size(59, 32);
            this.Timerstartbtn.TabIndex = 4;
            this.Timerstartbtn.Text = "Start";
            this.Timerstartbtn.UseVisualStyleBackColor = false;
            this.Timerstartbtn.Click += new System.EventHandler(this.Timerstartbtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seconds";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Minutes";
            // 
            // ologo
            // 
            this.ologo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ologo.Location = new System.Drawing.Point(638, 21);
            this.ologo.Name = "ologo";
            this.ologo.Padding = new System.Windows.Forms.Padding(4);
            this.ologo.Size = new System.Drawing.Size(100, 100);
            this.ologo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ologo.TabIndex = 43;
            this.ologo.TabStop = false;
            // 
            // Aop4
            // 
            this.Aop4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aop4.BackColor = System.Drawing.Color.Crimson;
            this.Aop4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aop4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Aop4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Aop4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aop4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aop4.ForeColor = System.Drawing.Color.White;
            this.Aop4.Location = new System.Drawing.Point(953, 356);
            this.Aop4.Name = "Aop4";
            this.Aop4.Size = new System.Drawing.Size(108, 40);
            this.Aop4.TabIndex = 41;
            this.Aop4.Text = "-1";
            this.Aop4.UseVisualStyleBackColor = false;
            this.Aop4.Click += new System.EventHandler(this.Aop4_Click);
            // 
            // Aop3
            // 
            this.Aop3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Aop3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aop3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Aop3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Aop3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aop3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aop3.ForeColor = System.Drawing.Color.White;
            this.Aop3.Location = new System.Drawing.Point(953, 310);
            this.Aop3.Name = "Aop3";
            this.Aop3.Size = new System.Drawing.Size(108, 40);
            this.Aop3.TabIndex = 40;
            this.Aop3.Text = "Ippon (+3)";
            this.Aop3.UseVisualStyleBackColor = false;
            this.Aop3.Click += new System.EventHandler(this.Aop3_Click);
            // 
            // Aop2
            // 
            this.Aop2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aop2.BackColor = System.Drawing.Color.DarkGreen;
            this.Aop2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aop2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Aop2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Aop2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aop2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aop2.ForeColor = System.Drawing.Color.White;
            this.Aop2.Location = new System.Drawing.Point(953, 265);
            this.Aop2.Name = "Aop2";
            this.Aop2.Size = new System.Drawing.Size(108, 40);
            this.Aop2.TabIndex = 39;
            this.Aop2.Text = "Wasa-ari (+2)";
            this.Aop2.UseVisualStyleBackColor = false;
            this.Aop2.Click += new System.EventHandler(this.Aop2_Click);
            // 
            // Aop1
            // 
            this.Aop1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aop1.BackColor = System.Drawing.Color.SeaGreen;
            this.Aop1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aop1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Aop1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Aop1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aop1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aop1.ForeColor = System.Drawing.Color.White;
            this.Aop1.Location = new System.Drawing.Point(953, 220);
            this.Aop1.Name = "Aop1";
            this.Aop1.Size = new System.Drawing.Size(108, 40);
            this.Aop1.TabIndex = 38;
            this.Aop1.Text = "Yoku (+1)";
            this.Aop1.UseVisualStyleBackColor = false;
            this.Aop1.Click += new System.EventHandler(this.Aop1_Click);
            // 
            // Aoc5
            // 
            this.Aoc5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aoc5.BackColor = System.Drawing.Color.Transparent;
            this.Aoc5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aoc5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aoc5.FlatAppearance.BorderSize = 2;
            this.Aoc5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aoc5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aoc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aoc5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aoc5.ForeColor = System.Drawing.Color.White;
            this.Aoc5.Location = new System.Drawing.Point(1275, 504);
            this.Aoc5.Name = "Aoc5";
            this.Aoc5.Size = new System.Drawing.Size(60, 60);
            this.Aoc5.TabIndex = 37;
            this.Aoc5.Text = "H";
            this.Aoc5.UseVisualStyleBackColor = true;
            this.Aoc5.Click += new System.EventHandler(this.Aoc5_Click);
            this.Aoc5.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Aoc4
            // 
            this.Aoc4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aoc4.BackColor = System.Drawing.Color.Transparent;
            this.Aoc4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aoc4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aoc4.FlatAppearance.BorderSize = 2;
            this.Aoc4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aoc4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aoc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aoc4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aoc4.ForeColor = System.Drawing.Color.White;
            this.Aoc4.Location = new System.Drawing.Point(1180, 504);
            this.Aoc4.Name = "Aoc4";
            this.Aoc4.Size = new System.Drawing.Size(60, 60);
            this.Aoc4.TabIndex = 36;
            this.Aoc4.Text = "HC";
            this.Aoc4.UseVisualStyleBackColor = true;
            this.Aoc4.Click += new System.EventHandler(this.Aoc4_Click);
            this.Aoc4.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Aoc3
            // 
            this.Aoc3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aoc3.BackColor = System.Drawing.Color.Transparent;
            this.Aoc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aoc3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aoc3.FlatAppearance.BorderSize = 2;
            this.Aoc3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aoc3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aoc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aoc3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aoc3.ForeColor = System.Drawing.Color.White;
            this.Aoc3.Location = new System.Drawing.Point(1085, 504);
            this.Aoc3.Name = "Aoc3";
            this.Aoc3.Size = new System.Drawing.Size(60, 60);
            this.Aoc3.TabIndex = 35;
            this.Aoc3.Text = "C3";
            this.Aoc3.UseVisualStyleBackColor = true;
            this.Aoc3.Click += new System.EventHandler(this.Aoc3_Click);
            this.Aoc3.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Aoc2
            // 
            this.Aoc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aoc2.BackColor = System.Drawing.Color.Transparent;
            this.Aoc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aoc2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aoc2.FlatAppearance.BorderSize = 2;
            this.Aoc2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aoc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aoc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aoc2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aoc2.ForeColor = System.Drawing.Color.White;
            this.Aoc2.Location = new System.Drawing.Point(992, 504);
            this.Aoc2.Name = "Aoc2";
            this.Aoc2.Size = new System.Drawing.Size(60, 60);
            this.Aoc2.TabIndex = 34;
            this.Aoc2.Text = "C2";
            this.Aoc2.UseVisualStyleBackColor = true;
            this.Aoc2.Click += new System.EventHandler(this.Aoc2_Click);
            this.Aoc2.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Aoc1
            // 
            this.Aoc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aoc1.BackColor = System.Drawing.Color.Transparent;
            this.Aoc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aoc1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aoc1.FlatAppearance.BorderSize = 2;
            this.Aoc1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aoc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aoc1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aoc1.ForeColor = System.Drawing.Color.White;
            this.Aoc1.Location = new System.Drawing.Point(895, 504);
            this.Aoc1.Name = "Aoc1";
            this.Aoc1.Size = new System.Drawing.Size(60, 60);
            this.Aoc1.TabIndex = 33;
            this.Aoc1.Text = "C1";
            this.Aoc1.UseVisualStyleBackColor = true;
            this.Aoc1.Click += new System.EventHandler(this.Aoc1_Click);
            this.Aoc1.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Aosenshu
            // 
            this.Aosenshu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aosenshu.BackColor = System.Drawing.Color.Transparent;
            this.Aosenshu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aosenshu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aosenshu.FlatAppearance.BorderSize = 2;
            this.Aosenshu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Aosenshu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Aosenshu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aosenshu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aosenshu.ForeColor = System.Drawing.Color.White;
            this.Aosenshu.Location = new System.Drawing.Point(953, 106);
            this.Aosenshu.Name = "Aosenshu";
            this.Aosenshu.Size = new System.Drawing.Size(102, 102);
            this.Aosenshu.TabIndex = 32;
            this.Aosenshu.Text = "SENSHU";
            this.Aosenshu.UseVisualStyleBackColor = true;
            this.Aosenshu.Click += new System.EventHandler(this.Aosenshu_Click);
            this.Aosenshu.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // aoscore
            // 
            this.aoscore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aoscore.AutoSize = true;
            this.aoscore.BackColor = System.Drawing.Color.Transparent;
            this.aoscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aoscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aoscore.Location = new System.Drawing.Point(1208, 176);
            this.aoscore.Name = "aoscore";
            this.aoscore.Size = new System.Drawing.Size(99, 108);
            this.aoscore.TabIndex = 31;
            this.aoscore.Text = "0";
            this.aoscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(1219, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 42);
            this.label7.TabIndex = 30;
            this.label7.Text = "Score";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1036, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 44);
            this.label5.TabIndex = 29;
            this.label5.Text = "WARNINGS";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1108, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 73);
            this.label3.TabIndex = 28;
            this.label3.Text = "AO";
            // 
            // Akap4
            // 
            this.Akap4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akap4.BackColor = System.Drawing.Color.Crimson;
            this.Akap4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akap4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akap4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akap4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Akap4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akap4.ForeColor = System.Drawing.Color.White;
            this.Akap4.Location = new System.Drawing.Point(313, 360);
            this.Akap4.Name = "Akap4";
            this.Akap4.Size = new System.Drawing.Size(108, 40);
            this.Akap4.TabIndex = 27;
            this.Akap4.Text = "-1";
            this.Akap4.UseVisualStyleBackColor = false;
            this.Akap4.Click += new System.EventHandler(this.Akap4_Click);
            // 
            // Akap3
            // 
            this.Akap3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akap3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Akap3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akap3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akap3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akap3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Akap3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akap3.ForeColor = System.Drawing.Color.White;
            this.Akap3.Location = new System.Drawing.Point(313, 312);
            this.Akap3.Name = "Akap3";
            this.Akap3.Size = new System.Drawing.Size(108, 40);
            this.Akap3.TabIndex = 26;
            this.Akap3.Text = "Ippon (+3)";
            this.Akap3.UseVisualStyleBackColor = false;
            this.Akap3.Click += new System.EventHandler(this.Akap3_Click);
            // 
            // Akap2
            // 
            this.Akap2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akap2.BackColor = System.Drawing.Color.DarkGreen;
            this.Akap2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akap2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akap2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akap2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Akap2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akap2.ForeColor = System.Drawing.Color.White;
            this.Akap2.Location = new System.Drawing.Point(313, 266);
            this.Akap2.Name = "Akap2";
            this.Akap2.Size = new System.Drawing.Size(108, 40);
            this.Akap2.TabIndex = 25;
            this.Akap2.Text = "Wasa-ari (+2)";
            this.Akap2.UseVisualStyleBackColor = false;
            this.Akap2.Click += new System.EventHandler(this.Akap2_Click);
            // 
            // Akap1
            // 
            this.Akap1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akap1.BackColor = System.Drawing.Color.SeaGreen;
            this.Akap1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akap1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akap1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akap1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Akap1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akap1.ForeColor = System.Drawing.Color.White;
            this.Akap1.Location = new System.Drawing.Point(313, 220);
            this.Akap1.Name = "Akap1";
            this.Akap1.Size = new System.Drawing.Size(108, 40);
            this.Akap1.TabIndex = 24;
            this.Akap1.Text = "Yoku (+1)";
            this.Akap1.UseVisualStyleBackColor = false;
            this.Akap1.Click += new System.EventHandler(this.Akap1_Click);
            // 
            // Akac5
            // 
            this.Akac5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akac5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akac5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akac5.FlatAppearance.BorderSize = 2;
            this.Akac5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akac5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akac5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akac5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akac5.ForeColor = System.Drawing.Color.White;
            this.Akac5.Location = new System.Drawing.Point(425, 504);
            this.Akac5.Name = "Akac5";
            this.Akac5.Size = new System.Drawing.Size(60, 60);
            this.Akac5.TabIndex = 23;
            this.Akac5.Text = "H";
            this.Akac5.UseVisualStyleBackColor = true;
            this.Akac5.Click += new System.EventHandler(this.Akac5_Click);
            this.Akac5.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Akac4
            // 
            this.Akac4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akac4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akac4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akac4.FlatAppearance.BorderSize = 2;
            this.Akac4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akac4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akac4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akac4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akac4.ForeColor = System.Drawing.Color.White;
            this.Akac4.Location = new System.Drawing.Point(324, 504);
            this.Akac4.Name = "Akac4";
            this.Akac4.Size = new System.Drawing.Size(60, 60);
            this.Akac4.TabIndex = 22;
            this.Akac4.Text = "HC";
            this.Akac4.UseVisualStyleBackColor = true;
            this.Akac4.Click += new System.EventHandler(this.Akac4_Click);
            this.Akac4.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Akac3
            // 
            this.Akac3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akac3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akac3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akac3.FlatAppearance.BorderSize = 2;
            this.Akac3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akac3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akac3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akac3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akac3.ForeColor = System.Drawing.Color.White;
            this.Akac3.Location = new System.Drawing.Point(224, 504);
            this.Akac3.Name = "Akac3";
            this.Akac3.Size = new System.Drawing.Size(60, 60);
            this.Akac3.TabIndex = 21;
            this.Akac3.Text = "C3";
            this.Akac3.UseVisualStyleBackColor = true;
            this.Akac3.Click += new System.EventHandler(this.Akac3_Click);
            this.Akac3.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Akac2
            // 
            this.Akac2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akac2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akac2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akac2.FlatAppearance.BorderSize = 2;
            this.Akac2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akac2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akac2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akac2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akac2.ForeColor = System.Drawing.Color.White;
            this.Akac2.Location = new System.Drawing.Point(126, 504);
            this.Akac2.Name = "Akac2";
            this.Akac2.Size = new System.Drawing.Size(60, 60);
            this.Akac2.TabIndex = 20;
            this.Akac2.Text = "C2";
            this.Akac2.UseVisualStyleBackColor = true;
            this.Akac2.Click += new System.EventHandler(this.Akac2_Click);
            this.Akac2.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Akac1
            // 
            this.Akac1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akac1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akac1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akac1.FlatAppearance.BorderSize = 2;
            this.Akac1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akac1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akac1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akac1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akac1.ForeColor = System.Drawing.Color.White;
            this.Akac1.Location = new System.Drawing.Point(26, 504);
            this.Akac1.Name = "Akac1";
            this.Akac1.Size = new System.Drawing.Size(60, 60);
            this.Akac1.TabIndex = 19;
            this.Akac1.Text = "C1";
            this.Akac1.UseVisualStyleBackColor = true;
            this.Akac1.Click += new System.EventHandler(this.Akac1_Click);
            this.Akac1.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // Akasenshu
            // 
            this.Akasenshu.AccessibleDescription = "";
            this.Akasenshu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Akasenshu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Akasenshu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Akasenshu.FlatAppearance.BorderSize = 2;
            this.Akasenshu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Akasenshu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Akasenshu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Akasenshu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akasenshu.ForeColor = System.Drawing.Color.White;
            this.Akasenshu.Location = new System.Drawing.Point(319, 106);
            this.Akasenshu.Name = "Akasenshu";
            this.Akasenshu.Size = new System.Drawing.Size(102, 102);
            this.Akasenshu.TabIndex = 18;
            this.Akasenshu.Tag = "";
            this.Akasenshu.Text = "SENSHU";
            this.Akasenshu.UseVisualStyleBackColor = true;
            this.Akasenshu.Click += new System.EventHandler(this.Akasenshu_Click);
            this.Akasenshu.Paint += new System.Windows.Forms.PaintEventHandler(this.Make_Roundbutton);
            // 
            // akascore
            // 
            this.akascore.AutoSize = true;
            this.akascore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akascore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.akascore.Location = new System.Drawing.Point(15, 176);
            this.akascore.Name = "akascore";
            this.akascore.Size = new System.Drawing.Size(99, 108);
            this.akascore.TabIndex = 17;
            this.akascore.Text = "0";
            this.akascore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "Score";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(132, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 44);
            this.label4.TabIndex = 15;
            this.label4.Text = "WARNINGS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 73);
            this.label2.TabIndex = 14;
            this.label2.Text = "AKA";
            // 
            // Timerfight
            // 
            this.Timerfight.Interval = 1000;
            this.Timerfight.Tick += new System.EventHandler(this.Timerfight_Tick);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Score_.Properties.Resources.fightbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Closing);

            //this.Load += new System.EventHandler(this.Fight_Load);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.timerpanel.ResumeLayout(false);
            this.timerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ologo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void Make_Roundbutton(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(0, 0, btn.Width, btn.Height);
                btn.Region = new System.Drawing.Region(path);
            }
            int borderThickness = btn.FlatAppearance.BorderSize;
            if (borderThickness == 0)
            {
                borderThickness = 2;
            }
            using (System.Drawing.Pen pen = new System.Drawing.Pen(btn.FlatAppearance.BorderColor, borderThickness))
            {
                e.Graphics.DrawEllipse(pen, borderThickness/2, borderThickness/2, btn.Width-borderThickness, btn.Height-borderThickness);
            }
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backtostart;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button oname;
        private System.Windows.Forms.Button tname;
        private System.Windows.Forms.Button Minimizebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Akap4;
        private System.Windows.Forms.Button Akap3;
        private System.Windows.Forms.Button Akap2;
        private System.Windows.Forms.Button Akap1;
        private System.Windows.Forms.Button Akac5;
        private System.Windows.Forms.Button Akac4;
        private System.Windows.Forms.Button Akac3;
        private System.Windows.Forms.Button Akac2;
        private System.Windows.Forms.Button Akac1;
        private System.Windows.Forms.Button Akasenshu;
        private System.Windows.Forms.Label akascore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aop4;
        private System.Windows.Forms.Button Aop3;
        private System.Windows.Forms.Button Aop2;
        private System.Windows.Forms.Button Aop1;
        private System.Windows.Forms.Button Aoc5;
        private System.Windows.Forms.Button Aoc4;
        private System.Windows.Forms.Button Aoc3;
        private System.Windows.Forms.Button Aoc2;
        private System.Windows.Forms.Button Aoc1;
        private System.Windows.Forms.Button Aosenshu;
        private System.Windows.Forms.Label aoscore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Timerfight;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Panel timerpanel;
        private System.Windows.Forms.Label Timerlabel;
        private System.Windows.Forms.ComboBox Secinput;
        private System.Windows.Forms.ComboBox Mininput;
        private System.Windows.Forms.Button Timerresetbtn;
        private System.Windows.Forms.Button Timerpausebtn;
        private System.Windows.Forms.Button Timerstartbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ologo;
    }
}