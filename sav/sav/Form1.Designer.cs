namespace sav
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skaičiavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagalbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spausdintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentųSkaičiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentoĮvertinimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.užduotisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurodymaiVartotojuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.įvestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duomenys = new System.Windows.Forms.RichTextBox();
            this.pavardeVrd = new System.Windows.Forms.TextBox();
            this.rezultatai = new System.Windows.Forms.DataGridView();
            this.vertinimai = new System.Windows.Forms.ComboBox();
            this.rezultatas = new System.Windows.Forms.Label();
            this.vaikinu = new System.Windows.Forms.RadioButton();
            this.merginu = new System.Windows.Forms.RadioButton();
            this.skaičiuotiVidurkįToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatai)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.skaičiavimaiToolStripMenuItem,
            this.pagalbaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.įvestiToolStripMenuItem,
            this.spausdintiToolStripMenuItem,
            this.baigtiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // skaičiavimaiToolStripMenuItem
            // 
            this.skaičiavimaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentųSkaičiusToolStripMenuItem,
            this.studentoĮvertinimaiToolStripMenuItem,
            this.skaičiuotiVidurkįToolStripMenuItem});
            this.skaičiavimaiToolStripMenuItem.Name = "skaičiavimaiToolStripMenuItem";
            this.skaičiavimaiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.skaičiavimaiToolStripMenuItem.Text = "Skaičiavimai";
            // 
            // pagalbaToolStripMenuItem
            // 
            this.pagalbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.užduotisToolStripMenuItem,
            this.nurodymaiVartotojuiToolStripMenuItem});
            this.pagalbaToolStripMenuItem.Name = "pagalbaToolStripMenuItem";
            this.pagalbaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pagalbaToolStripMenuItem.Text = "Pagalba";
            // 
            // spausdintiToolStripMenuItem
            // 
            this.spausdintiToolStripMenuItem.Name = "spausdintiToolStripMenuItem";
            this.spausdintiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spausdintiToolStripMenuItem.Text = "Spausdinti";
            this.spausdintiToolStripMenuItem.Click += new System.EventHandler(this.spausdintiToolStripMenuItem_Click);
            // 
            // baigtiToolStripMenuItem
            // 
            this.baigtiToolStripMenuItem.Name = "baigtiToolStripMenuItem";
            this.baigtiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baigtiToolStripMenuItem.Text = "Baigti";
            this.baigtiToolStripMenuItem.Click += new System.EventHandler(this.baigtiToolStripMenuItem_Click);
            // 
            // studentųSkaičiusToolStripMenuItem
            // 
            this.studentųSkaičiusToolStripMenuItem.Name = "studentųSkaičiusToolStripMenuItem";
            this.studentųSkaičiusToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentųSkaičiusToolStripMenuItem.Text = "Studentų skaičius";
            this.studentųSkaičiusToolStripMenuItem.Click += new System.EventHandler(this.studentųSkaičiusToolStripMenuItem_Click);
            // 
            // studentoĮvertinimaiToolStripMenuItem
            // 
            this.studentoĮvertinimaiToolStripMenuItem.Name = "studentoĮvertinimaiToolStripMenuItem";
            this.studentoĮvertinimaiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentoĮvertinimaiToolStripMenuItem.Text = "Studento įvertinimai";
            this.studentoĮvertinimaiToolStripMenuItem.Click += new System.EventHandler(this.studentoĮvertinimaiToolStripMenuItem_Click);
            // 
            // užduotisToolStripMenuItem
            // 
            this.užduotisToolStripMenuItem.Name = "užduotisToolStripMenuItem";
            this.užduotisToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.užduotisToolStripMenuItem.Text = "Užduotis";
            this.užduotisToolStripMenuItem.Click += new System.EventHandler(this.užduotisToolStripMenuItem_Click);
            // 
            // nurodymaiVartotojuiToolStripMenuItem
            // 
            this.nurodymaiVartotojuiToolStripMenuItem.Name = "nurodymaiVartotojuiToolStripMenuItem";
            this.nurodymaiVartotojuiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nurodymaiVartotojuiToolStripMenuItem.Text = "Nurodymai vartotojui";
            this.nurodymaiVartotojuiToolStripMenuItem.Click += new System.EventHandler(this.nurodymaiVartotojuiToolStripMenuItem_Click);
            // 
            // įvestiToolStripMenuItem
            // 
            this.įvestiToolStripMenuItem.Name = "įvestiToolStripMenuItem";
            this.įvestiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.įvestiToolStripMenuItem.Text = "Įvesti";
            this.įvestiToolStripMenuItem.Click += new System.EventHandler(this.įvestiToolStripMenuItem_Click);
            // 
            // duomenys
            // 
            this.duomenys.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.duomenys.Location = new System.Drawing.Point(21, 41);
            this.duomenys.Name = "duomenys";
            this.duomenys.Size = new System.Drawing.Size(380, 196);
            this.duomenys.TabIndex = 1;
            this.duomenys.Text = "Čia bus parodyti programos pradiniai duomenys";
            // 
            // pavardeVrd
            // 
            this.pavardeVrd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavardeVrd.Location = new System.Drawing.Point(24, 246);
            this.pavardeVrd.Name = "pavardeVrd";
            this.pavardeVrd.Size = new System.Drawing.Size(376, 26);
            this.pavardeVrd.TabIndex = 2;
            this.pavardeVrd.Text = "Čia užrašykite pavardę ir vardą";
            // 
            // rezultatai
            // 
            this.rezultatai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezultatai.Location = new System.Drawing.Point(25, 280);
            this.rezultatai.Name = "rezultatai";
            this.rezultatai.Size = new System.Drawing.Size(374, 229);
            this.rezultatai.TabIndex = 3;
            // 
            // vertinimai
            // 
            this.vertinimai.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vertinimai.FormattingEnabled = true;
            this.vertinimai.Location = new System.Drawing.Point(420, 41);
            this.vertinimai.Name = "vertinimai";
            this.vertinimai.Size = new System.Drawing.Size(226, 30);
            this.vertinimai.TabIndex = 4;
            this.vertinimai.Text = "Pasirinkite pažymį";
            // 
            // rezultatas
            // 
            this.rezultatas.AutoSize = true;
            this.rezultatas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rezultatas.ForeColor = System.Drawing.Color.Blue;
            this.rezultatas.Location = new System.Drawing.Point(417, 82);
            this.rezultatas.Name = "rezultatas";
            this.rezultatas.Size = new System.Drawing.Size(278, 18);
            this.rezultatas.TabIndex = 5;
            this.rezultatas.Text = "Čia bus parodyti rezultatai";
            this.rezultatas.Click += new System.EventHandler(this.label1_Click);
            // 
            // vaikinu
            // 
            this.vaikinu.AutoSize = true;
            this.vaikinu.Location = new System.Drawing.Point(438, 137);
            this.vaikinu.Name = "vaikinu";
            this.vaikinu.Size = new System.Drawing.Size(140, 17);
            this.vaikinu.TabIndex = 6;
            this.vaikinu.TabStop = true;
            this.vaikinu.Text = "Vaikinų pažymių vidurkis";
            this.vaikinu.UseVisualStyleBackColor = true;
            this.vaikinu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // merginu
            // 
            this.merginu.AutoSize = true;
            this.merginu.Location = new System.Drawing.Point(438, 160);
            this.merginu.Name = "merginu";
            this.merginu.Size = new System.Drawing.Size(143, 17);
            this.merginu.TabIndex = 7;
            this.merginu.TabStop = true;
            this.merginu.Text = "Merginų pažymių vidurkis";
            this.merginu.UseVisualStyleBackColor = true;
            // 
            // skaičiuotiVidurkįToolStripMenuItem
            // 
            this.skaičiuotiVidurkįToolStripMenuItem.Name = "skaičiuotiVidurkįToolStripMenuItem";
            this.skaičiuotiVidurkįToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.skaičiuotiVidurkįToolStripMenuItem.Text = "Skaičiuoti vidurkį";
            this.skaičiuotiVidurkįToolStripMenuItem.Click += new System.EventHandler(this.skaičiuotiVidurkįToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 521);
            this.Controls.Add(this.merginu);
            this.Controls.Add(this.vaikinu);
            this.Controls.Add(this.rezultatas);
            this.Controls.Add(this.vertinimai);
            this.Controls.Add(this.rezultatai);
            this.Controls.Add(this.pavardeVrd);
            this.Controls.Add(this.duomenys);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Studentai";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem įvestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spausdintiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skaičiavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentųSkaičiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentoĮvertinimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagalbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem užduotisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurodymaiVartotojuiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox duomenys;
        private System.Windows.Forms.TextBox pavardeVrd;
        private System.Windows.Forms.DataGridView rezultatai;
        private System.Windows.Forms.ComboBox vertinimai;
        private System.Windows.Forms.Label rezultatas;
        private System.Windows.Forms.RadioButton vaikinu;
        private System.Windows.Forms.RadioButton merginu;
        private System.Windows.Forms.ToolStripMenuItem skaičiuotiVidurkįToolStripMenuItem;
    }
}

