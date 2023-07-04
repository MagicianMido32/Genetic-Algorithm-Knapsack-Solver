namespace GA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.Run_Button = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.monoFlat_Panel2 = new MonoFlat.MonoFlat_Panel();
            this.Result_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.monoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            this.MaxGenerations_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.TournamentSize_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.ElitismRate_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.MutationRate_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.PopulationSize_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.Values_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.Weights_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.MaxWeight_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel7 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            this.ItemCount_TextBox = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.monoFlat_Panel2.SuspendLayout();
            this.monoFlat_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.Run_Button);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Panel2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Panel1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(949, 620);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Genetic Algorithm - Knapsack Solver";
            // 
            // Run_Button
            // 
            this.Run_Button.BackColor = System.Drawing.Color.Transparent;
            this.Run_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Run_Button.Image = null;
            this.Run_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Run_Button.Location = new System.Drawing.Point(388, 559);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(226, 49);
            this.Run_Button.TabIndex = 22;
            this.Run_Button.Text = "Run";
            this.Run_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(837, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 21;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // monoFlat_Panel2
            // 
            this.monoFlat_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel2.Controls.Add(this.Result_TextBox);
            this.monoFlat_Panel2.Location = new System.Drawing.Point(503, 73);
            this.monoFlat_Panel2.Name = "monoFlat_Panel2";
            this.monoFlat_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel2.Size = new System.Drawing.Size(433, 461);
            this.monoFlat_Panel2.TabIndex = 19;
            this.monoFlat_Panel2.Text = "monoFlat_Panel2";
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Result_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.Result_TextBox.Image = null;
            this.Result_TextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Result_TextBox.Location = new System.Drawing.Point(8, 8);
            this.Result_TextBox.MaxLength = 32767;
            this.Result_TextBox.Multiline = true;
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.ReadOnly = false;
            this.Result_TextBox.Size = new System.Drawing.Size(417, 417);
            this.Result_TextBox.TabIndex = 19;
            this.Result_TextBox.Text = "The results of the experiment will be printed here.";
            this.Result_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Result_TextBox.UseSystemPasswordChar = false;
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel4);
            this.monoFlat_Panel1.Controls.Add(this.MaxGenerations_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.TournamentSize_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.ElitismRate_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.MutationRate_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.PopulationSize_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.Values_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.Weights_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.MaxWeight_TextBox);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel2);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel3);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel5);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel6);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel7);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel8);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_HeaderLabel9);
            this.monoFlat_Panel1.Controls.Add(this.ItemCount_TextBox);
            this.monoFlat_Panel1.Location = new System.Drawing.Point(13, 73);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(471, 461);
            this.monoFlat_Panel1.TabIndex = 18;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // monoFlat_HeaderLabel4
            // 
            this.monoFlat_HeaderLabel4.AutoSize = true;
            this.monoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel4.Location = new System.Drawing.Point(15, 264);
            this.monoFlat_HeaderLabel4.Name = "monoFlat_HeaderLabel4";
            this.monoFlat_HeaderLabel4.Size = new System.Drawing.Size(92, 20);
            this.monoFlat_HeaderLabel4.TabIndex = 3;
            this.monoFlat_HeaderLabel4.Text = "ElitismRate ";
            // 
            // MaxGenerations_TextBox
            // 
            this.MaxGenerations_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxGenerations_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxGenerations_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.MaxGenerations_TextBox.Image = null;
            this.MaxGenerations_TextBox.Location = new System.Drawing.Point(141, 384);
            this.MaxGenerations_TextBox.MaxLength = 32767;
            this.MaxGenerations_TextBox.Multiline = false;
            this.MaxGenerations_TextBox.Name = "MaxGenerations_TextBox";
            this.MaxGenerations_TextBox.ReadOnly = false;
            this.MaxGenerations_TextBox.Size = new System.Drawing.Size(322, 41);
            this.MaxGenerations_TextBox.TabIndex = 10;
            this.MaxGenerations_TextBox.Text = "100";
            this.MaxGenerations_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaxGenerations_TextBox.UseSystemPasswordChar = false;
            // 
            // TournamentSize_TextBox
            // 
            this.TournamentSize_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.TournamentSize_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentSize_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.TournamentSize_TextBox.Image = null;
            this.TournamentSize_TextBox.Location = new System.Drawing.Point(141, 337);
            this.TournamentSize_TextBox.MaxLength = 32767;
            this.TournamentSize_TextBox.Multiline = false;
            this.TournamentSize_TextBox.Name = "TournamentSize_TextBox";
            this.TournamentSize_TextBox.ReadOnly = false;
            this.TournamentSize_TextBox.Size = new System.Drawing.Size(322, 41);
            this.TournamentSize_TextBox.TabIndex = 11;
            this.TournamentSize_TextBox.Text = "5";
            this.TournamentSize_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TournamentSize_TextBox.UseSystemPasswordChar = false;
            // 
            // ElitismRate_TextBox
            // 
            this.ElitismRate_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.ElitismRate_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ElitismRate_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.ElitismRate_TextBox.Image = null;
            this.ElitismRate_TextBox.Location = new System.Drawing.Point(141, 290);
            this.ElitismRate_TextBox.MaxLength = 32767;
            this.ElitismRate_TextBox.Multiline = false;
            this.ElitismRate_TextBox.Name = "ElitismRate_TextBox";
            this.ElitismRate_TextBox.ReadOnly = false;
            this.ElitismRate_TextBox.Size = new System.Drawing.Size(322, 41);
            this.ElitismRate_TextBox.TabIndex = 12;
            this.ElitismRate_TextBox.Text = "0.1";
            this.ElitismRate_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ElitismRate_TextBox.UseSystemPasswordChar = false;
            // 
            // MutationRate_TextBox
            // 
            this.MutationRate_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.MutationRate_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MutationRate_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.MutationRate_TextBox.Image = null;
            this.MutationRate_TextBox.Location = new System.Drawing.Point(141, 243);
            this.MutationRate_TextBox.MaxLength = 32767;
            this.MutationRate_TextBox.Multiline = false;
            this.MutationRate_TextBox.Name = "MutationRate_TextBox";
            this.MutationRate_TextBox.ReadOnly = false;
            this.MutationRate_TextBox.Size = new System.Drawing.Size(322, 41);
            this.MutationRate_TextBox.TabIndex = 13;
            this.MutationRate_TextBox.Text = "0.01";
            this.MutationRate_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MutationRate_TextBox.UseSystemPasswordChar = false;
            // 
            // PopulationSize_TextBox
            // 
            this.PopulationSize_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.PopulationSize_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopulationSize_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.PopulationSize_TextBox.Image = null;
            this.PopulationSize_TextBox.Location = new System.Drawing.Point(141, 196);
            this.PopulationSize_TextBox.MaxLength = 32767;
            this.PopulationSize_TextBox.Multiline = false;
            this.PopulationSize_TextBox.Name = "PopulationSize_TextBox";
            this.PopulationSize_TextBox.ReadOnly = false;
            this.PopulationSize_TextBox.Size = new System.Drawing.Size(322, 41);
            this.PopulationSize_TextBox.TabIndex = 14;
            this.PopulationSize_TextBox.Text = "100";
            this.PopulationSize_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PopulationSize_TextBox.UseSystemPasswordChar = false;
            // 
            // Values_TextBox
            // 
            this.Values_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Values_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Values_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.Values_TextBox.Image = null;
            this.Values_TextBox.Location = new System.Drawing.Point(141, 149);
            this.Values_TextBox.MaxLength = 32767;
            this.Values_TextBox.Multiline = false;
            this.Values_TextBox.Name = "Values_TextBox";
            this.Values_TextBox.ReadOnly = false;
            this.Values_TextBox.Size = new System.Drawing.Size(322, 41);
            this.Values_TextBox.TabIndex = 15;
            this.Values_TextBox.Text = "6, 7, 8, 9, 10, 11, 12, 13, 14, 15";
            this.Values_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Values_TextBox.UseSystemPasswordChar = false;
            // 
            // Weights_TextBox
            // 
            this.Weights_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.Weights_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weights_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.Weights_TextBox.Image = null;
            this.Weights_TextBox.Location = new System.Drawing.Point(141, 102);
            this.Weights_TextBox.MaxLength = 32767;
            this.Weights_TextBox.Multiline = false;
            this.Weights_TextBox.Name = "Weights_TextBox";
            this.Weights_TextBox.ReadOnly = false;
            this.Weights_TextBox.Size = new System.Drawing.Size(322, 41);
            this.Weights_TextBox.TabIndex = 16;
            this.Weights_TextBox.Text = "2, 3, 4, 5, 6, 7, 8, 9, 10, 11";
            this.Weights_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Weights_TextBox.UseSystemPasswordChar = false;
            // 
            // MaxWeight_TextBox
            // 
            this.MaxWeight_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxWeight_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxWeight_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.MaxWeight_TextBox.Image = null;
            this.MaxWeight_TextBox.Location = new System.Drawing.Point(141, 55);
            this.MaxWeight_TextBox.MaxLength = 32767;
            this.MaxWeight_TextBox.Multiline = false;
            this.MaxWeight_TextBox.Name = "MaxWeight_TextBox";
            this.MaxWeight_TextBox.ReadOnly = false;
            this.MaxWeight_TextBox.Size = new System.Drawing.Size(322, 41);
            this.MaxWeight_TextBox.TabIndex = 17;
            this.MaxWeight_TextBox.Text = "20";
            this.MaxWeight_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaxWeight_TextBox.UseSystemPasswordChar = false;
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(15, 29);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(88, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 0;
            this.monoFlat_HeaderLabel1.Text = "Item Count";
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(15, 405);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(124, 20);
            this.monoFlat_HeaderLabel2.TabIndex = 1;
            this.monoFlat_HeaderLabel2.Text = "MaxGenerations";
            // 
            // monoFlat_HeaderLabel3
            // 
            this.monoFlat_HeaderLabel3.AutoSize = true;
            this.monoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel3.Location = new System.Drawing.Point(15, 357);
            this.monoFlat_HeaderLabel3.Name = "monoFlat_HeaderLabel3";
            this.monoFlat_HeaderLabel3.Size = new System.Drawing.Size(126, 20);
            this.monoFlat_HeaderLabel3.TabIndex = 2;
            this.monoFlat_HeaderLabel3.Text = "TournamentSize ";
            // 
            // monoFlat_HeaderLabel5
            // 
            this.monoFlat_HeaderLabel5.AutoSize = true;
            this.monoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel5.Location = new System.Drawing.Point(15, 309);
            this.monoFlat_HeaderLabel5.Name = "monoFlat_HeaderLabel5";
            this.monoFlat_HeaderLabel5.Size = new System.Drawing.Size(106, 20);
            this.monoFlat_HeaderLabel5.TabIndex = 4;
            this.monoFlat_HeaderLabel5.Text = "MutationRate";
            // 
            // monoFlat_HeaderLabel6
            // 
            this.monoFlat_HeaderLabel6.AutoSize = true;
            this.monoFlat_HeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel6.Location = new System.Drawing.Point(15, 213);
            this.monoFlat_HeaderLabel6.Name = "monoFlat_HeaderLabel6";
            this.monoFlat_HeaderLabel6.Size = new System.Drawing.Size(116, 20);
            this.monoFlat_HeaderLabel6.TabIndex = 5;
            this.monoFlat_HeaderLabel6.Text = "PopulationSize ";
            // 
            // monoFlat_HeaderLabel7
            // 
            this.monoFlat_HeaderLabel7.AutoSize = true;
            this.monoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel7.Location = new System.Drawing.Point(15, 170);
            this.monoFlat_HeaderLabel7.Name = "monoFlat_HeaderLabel7";
            this.monoFlat_HeaderLabel7.Size = new System.Drawing.Size(58, 20);
            this.monoFlat_HeaderLabel7.TabIndex = 6;
            this.monoFlat_HeaderLabel7.Text = "Values ";
            // 
            // monoFlat_HeaderLabel8
            // 
            this.monoFlat_HeaderLabel8.AutoSize = true;
            this.monoFlat_HeaderLabel8.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel8.Location = new System.Drawing.Point(15, 123);
            this.monoFlat_HeaderLabel8.Name = "monoFlat_HeaderLabel8";
            this.monoFlat_HeaderLabel8.Size = new System.Drawing.Size(67, 20);
            this.monoFlat_HeaderLabel8.TabIndex = 7;
            this.monoFlat_HeaderLabel8.Text = "Weights";
            // 
            // monoFlat_HeaderLabel9
            // 
            this.monoFlat_HeaderLabel9.AutoSize = true;
            this.monoFlat_HeaderLabel9.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_HeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel9.Location = new System.Drawing.Point(15, 76);
            this.monoFlat_HeaderLabel9.Name = "monoFlat_HeaderLabel9";
            this.monoFlat_HeaderLabel9.Size = new System.Drawing.Size(98, 20);
            this.monoFlat_HeaderLabel9.TabIndex = 8;
            this.monoFlat_HeaderLabel9.Text = "Max Weight ";
            // 
            // ItemCount_TextBox
            // 
            this.ItemCount_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemCount_TextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemCount_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.ItemCount_TextBox.Image = null;
            this.ItemCount_TextBox.Location = new System.Drawing.Point(141, 8);
            this.ItemCount_TextBox.MaxLength = 32767;
            this.ItemCount_TextBox.Multiline = false;
            this.ItemCount_TextBox.Name = "ItemCount_TextBox";
            this.ItemCount_TextBox.ReadOnly = false;
            this.ItemCount_TextBox.Size = new System.Drawing.Size(322, 41);
            this.ItemCount_TextBox.TabIndex = 9;
            this.ItemCount_TextBox.Text = "10";
            this.ItemCount_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemCount_TextBox.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 620);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Genetic Algorithm - Knapsack Solver";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_Panel2.ResumeLayout(false);
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat.MonoFlat_TextBox MaxWeight_TextBox;
        private MonoFlat.MonoFlat_TextBox Weights_TextBox;
        private MonoFlat.MonoFlat_TextBox Values_TextBox;
        private MonoFlat.MonoFlat_TextBox PopulationSize_TextBox;
        private MonoFlat.MonoFlat_TextBox MutationRate_TextBox;
        private MonoFlat.MonoFlat_TextBox ElitismRate_TextBox;
        private MonoFlat.MonoFlat_TextBox TournamentSize_TextBox;
        private MonoFlat.MonoFlat_TextBox MaxGenerations_TextBox;
        private MonoFlat.MonoFlat_TextBox ItemCount_TextBox;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel9;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel8;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel7;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel6;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel5;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel4;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel3;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel2;
        private MonoFlat.MonoFlat_TextBox Result_TextBox;
        private MonoFlat.MonoFlat_Button Run_Button;
    }
}