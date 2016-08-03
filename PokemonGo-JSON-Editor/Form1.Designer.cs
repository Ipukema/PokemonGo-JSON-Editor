namespace PokemonGo_JSON_Editor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Auth_service = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gmaps_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Max_steps = new System.Windows.Forms.TextBox();
            this.Mode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Walk_speed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Debug = new System.Windows.Forms.ComboBox();
            this.Test = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Initial_transfer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Location_cache = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Distance_unit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auth Service";
            // 
            // Auth_service
            // 
            this.Auth_service.Enabled = false;
            this.Auth_service.FormattingEnabled = true;
            this.Auth_service.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Auth_service.Location = new System.Drawing.Point(100, 56);
            this.Auth_service.Name = "Auth_service";
            this.Auth_service.Size = new System.Drawing.Size(167, 21);
            this.Auth_service.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(100, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(167, 20);
            this.Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(100, 117);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 20);
            this.Password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(100, 147);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(167, 20);
            this.Location.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            // 
            // Gmaps_key
            // 
            this.Gmaps_key.Location = new System.Drawing.Point(100, 177);
            this.Gmaps_key.Name = "Gmaps_key";
            this.Gmaps_key.Size = new System.Drawing.Size(167, 20);
            this.Gmaps_key.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gmaps API Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max Steps";
            // 
            // Max_steps
            // 
            this.Max_steps.Location = new System.Drawing.Point(490, 56);
            this.Max_steps.Name = "Max_steps";
            this.Max_steps.Size = new System.Drawing.Size(167, 20);
            this.Max_steps.TabIndex = 12;
            // 
            // Mode
            // 
            this.Mode.Location = new System.Drawing.Point(490, 86);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(167, 20);
            this.Mode.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mode";
            // 
            // Walk_speed
            // 
            this.Walk_speed.Location = new System.Drawing.Point(490, 116);
            this.Walk_speed.Name = "Walk_speed";
            this.Walk_speed.Size = new System.Drawing.Size(167, 20);
            this.Walk_speed.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Walk Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Debug";
            // 
            // Debug
            // 
            this.Debug.FormattingEnabled = true;
            this.Debug.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Debug.Location = new System.Drawing.Point(490, 146);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(167, 21);
            this.Debug.TabIndex = 18;
            // 
            // Test
            // 
            this.Test.FormattingEnabled = true;
            this.Test.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Test.Location = new System.Drawing.Point(490, 176);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(167, 21);
            this.Test.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Test";
            // 
            // Initial_transfer
            // 
            this.Initial_transfer.Location = new System.Drawing.Point(490, 207);
            this.Initial_transfer.Name = "Initial_transfer";
            this.Initial_transfer.Size = new System.Drawing.Size(167, 20);
            this.Initial_transfer.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Initial Transfer";
            // 
            // Location_cache
            // 
            this.Location_cache.FormattingEnabled = true;
            this.Location_cache.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Location_cache.Location = new System.Drawing.Point(490, 237);
            this.Location_cache.Name = "Location_cache";
            this.Location_cache.Size = new System.Drawing.Size(167, 21);
            this.Location_cache.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Location Cache";
            // 
            // Distance_unit
            // 
            this.Distance_unit.Enabled = false;
            this.Distance_unit.FormattingEnabled = true;
            this.Distance_unit.Location = new System.Drawing.Point(490, 268);
            this.Distance_unit.Name = "Distance_unit";
            this.Distance_unit.Size = new System.Drawing.Size(167, 21);
            this.Distance_unit.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Distance unit";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 360);
            this.Controls.Add(this.Distance_unit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Location_cache);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Initial_transfer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Walk_speed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Max_steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gmaps_key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Auth_service);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Pokemon Go - Json Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Auth_service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Gmaps_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Max_steps;
        private System.Windows.Forms.TextBox Mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Walk_speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Debug;
        private System.Windows.Forms.ComboBox Test;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Initial_transfer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Location_cache;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Distance_unit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
    }
}

