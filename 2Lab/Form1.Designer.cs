namespace _2Lab
{
    partial class Form1
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
            this.results = new System.Windows.Forms.RichTextBox();
            this.Message = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.intervalA = new System.Windows.Forms.TextBox();
            this.intervalB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TroleysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CombinesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(12, 34);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(524, 374);
            this.results.TabIndex = 1;
            this.results.Text = "Čia bus rodomi programos rezultatai";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F);
            this.Message.Location = new System.Drawing.Point(12, 411);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(195, 19);
            this.Message.TabIndex = 2;
            this.Message.Text = "Pranešimas apie atliktus veiksmus";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.Length.Location = new System.Drawing.Point(542, 61);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(210, 19);
            this.Length.TabIndex = 3;
            this.Length.Text = "Autobusų ir troleibusų maršrutų ilgiai";
            // 
            // intervalA
            // 
            this.intervalA.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.intervalA.Location = new System.Drawing.Point(546, 165);
            this.intervalA.Name = "intervalA";
            this.intervalA.Size = new System.Drawing.Size(92, 20);
            this.intervalA.TabIndex = 4;
            this.intervalA.Text = "Įveskite a";
            this.intervalA.TextChanged += new System.EventHandler(this.intervalA_TextChanged);
            // 
            // intervalB
            // 
            this.intervalB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalB.Location = new System.Drawing.Point(657, 165);
            this.intervalB.Name = "intervalB";
            this.intervalB.Size = new System.Drawing.Size(92, 20);
            this.intervalB.TabIndex = 5;
            this.intervalB.Text = "Įveskite b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(582, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Įveskite intervalą [ a : b ]";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Maroon;
            this.Close.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(625, 411);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(128, 33);
            this.Close.TabIndex = 8;
            this.Close.Text = "Baigti";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.word.Location = new System.Drawing.Point(586, 264);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(114, 20);
            this.word.TabIndex = 9;
            this.word.Text = "Įveskite žodį";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(543, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Žodis su kuriuo bus pašalinami maršrutai";
            // 
            // FilesToolStripMenuItem
            // 
            this.FilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputToolStripMenuItem});
            this.FilesToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
            this.FilesToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.FilesToolStripMenuItem.Text = "Failai";
            // 
            // InputToolStripMenuItem
            // 
            this.InputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TroleysToolStripMenuItem,
            this.BusesToolStripMenuItem,
            this.AdditionalToolStripMenuItem});
            this.InputToolStripMenuItem.Name = "InputToolStripMenuItem";
            this.InputToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.InputToolStripMenuItem.Text = "Įvesti duomenis";
            // 
            // TroleysToolStripMenuItem
            // 
            this.TroleysToolStripMenuItem.Name = "TroleysToolStripMenuItem";
            this.TroleysToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.TroleysToolStripMenuItem.Text = "Troleibusai";
            this.TroleysToolStripMenuItem.Click += new System.EventHandler(this.TroleysToolStripMenuItem_Click);
            // 
            // BusesToolStripMenuItem
            // 
            this.BusesToolStripMenuItem.Name = "BusesToolStripMenuItem";
            this.BusesToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.BusesToolStripMenuItem.Text = "Autobusai";
            this.BusesToolStripMenuItem.Click += new System.EventHandler(this.BusesToolStripMenuItem_Click);
            // 
            // AdditionalToolStripMenuItem
            // 
            this.AdditionalToolStripMenuItem.Name = "AdditionalToolStripMenuItem";
            this.AdditionalToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.AdditionalToolStripMenuItem.Text = "Papildomi";
            this.AdditionalToolStripMenuItem.Click += new System.EventHandler(this.AdditionalToolStripMenuItem_Click);
            // 
            // CalculationsToolStripMenuItem
            // 
            this.CalculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindToolStripMenuItem,
            this.CombinesListToolStripMenuItem,
            this.ArrangeToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.RemoveToolStripMenuItem});
            this.CalculationsToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.CalculationsToolStripMenuItem.Name = "CalculationsToolStripMenuItem";
            this.CalculationsToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.CalculationsToolStripMenuItem.Text = "Skaičiavimai";
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.FindToolStripMenuItem.Text = "Rasti";
            this.FindToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // CombinesListToolStripMenuItem
            // 
            this.CombinesListToolStripMenuItem.Name = "CombinesListToolStripMenuItem";
            this.CombinesListToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.CombinesListToolStripMenuItem.Text = "Sujungtas sąrašas";
            this.CombinesListToolStripMenuItem.Click += new System.EventHandler(this.CombinesListToolStripMenuItem_Click);
            // 
            // ArrangeToolStripMenuItem
            // 
            this.ArrangeToolStripMenuItem.Name = "ArrangeToolStripMenuItem";
            this.ArrangeToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.ArrangeToolStripMenuItem.Text = "Rikiuoti";
            this.ArrangeToolStripMenuItem.Click += new System.EventHandler(this.ArrangeToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.AddToolStripMenuItem.Text = "Įterpimas";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.RemoveToolStripMenuItem.Text = "Šalinimas";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskToolStripMenuItem,
            this.UserGuideToolStripMenuItem,
            this.autoriusToolStripMenuItem});
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.HelpToolStripMenuItem.Text = "Pagalba";
            // 
            // TaskToolStripMenuItem
            // 
            this.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            this.TaskToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.TaskToolStripMenuItem.Text = "Užduotis";
            this.TaskToolStripMenuItem.Click += new System.EventHandler(this.TaskToolStripMenuItem_Click);
            // 
            // UserGuideToolStripMenuItem
            // 
            this.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem";
            this.UserGuideToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.UserGuideToolStripMenuItem.Text = "Nurodymai vartotojui";
            this.UserGuideToolStripMenuItem.Click += new System.EventHandler(this.UserGuideToolStripMenuItem_Click);
            // 
            // autoriusToolStripMenuItem
            // 
            this.autoriusToolStripMenuItem.Name = "autoriusToolStripMenuItem";
            this.autoriusToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.autoriusToolStripMenuItem.Text = "Autorius";
            this.autoriusToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem,
            this.CalculationsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.word);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intervalB);
            this.Controls.Add(this.intervalA);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.results);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Viešasis transportas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox intervalA;
        private System.Windows.Forms.TextBox intervalB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TroleysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdditionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CombinesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriusToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

