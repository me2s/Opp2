namespace _1Labaratorinis
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
            this.Input = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enterA = new System.Windows.Forms.TextBox();
            this.enterB = new System.Windows.Forms.TextBox();
            this.FindDistance = new System.Windows.Forms.Button();
            this.Arrange = new System.Windows.Forms.Button();
            this.Removal = new System.Windows.Forms.Button();
            this.Combine = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.RichTextBox();
            this.DistanceRes = new System.Windows.Forms.Label();
            this.Guide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Thistle;
            this.Input.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.Input.Location = new System.Drawing.Point(611, 10);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(115, 44);
            this.Input.TabIndex = 3;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.Word.Location = new System.Drawing.Point(16, 431);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(278, 24);
            this.Word.TabIndex = 5;
            this.Word.Text = "Enter a word";
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a word to delete routes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Maroon;
            this.Close.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(611, 419);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 51);
            this.Close.TabIndex = 7;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(600, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter interval [ a; b ]";
            // 
            // enterA
            // 
            this.enterA.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.enterA.Location = new System.Drawing.Point(611, 146);
            this.enterA.Name = "enterA";
            this.enterA.Size = new System.Drawing.Size(115, 24);
            this.enterA.TabIndex = 10;
            this.enterA.Text = "Enter a";
            this.enterA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterB
            // 
            this.enterB.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.enterB.Location = new System.Drawing.Point(611, 176);
            this.enterB.Name = "enterB";
            this.enterB.Size = new System.Drawing.Size(115, 24);
            this.enterB.TabIndex = 11;
            this.enterB.Text = "Enter b";
            this.enterB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FindDistance
            // 
            this.FindDistance.BackColor = System.Drawing.Color.Thistle;
            this.FindDistance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.FindDistance.Location = new System.Drawing.Point(611, 60);
            this.FindDistance.Name = "FindDistance";
            this.FindDistance.Size = new System.Drawing.Size(115, 47);
            this.FindDistance.TabIndex = 12;
            this.FindDistance.Text = "Find distance";
            this.FindDistance.UseVisualStyleBackColor = false;
            this.FindDistance.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Arrange
            // 
            this.Arrange.BackColor = System.Drawing.Color.Thistle;
            this.Arrange.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Arrange.Location = new System.Drawing.Point(611, 254);
            this.Arrange.Name = "Arrange";
            this.Arrange.Size = new System.Drawing.Size(115, 45);
            this.Arrange.TabIndex = 13;
            this.Arrange.Text = "Rearrange";
            this.Arrange.UseVisualStyleBackColor = false;
            this.Arrange.Click += new System.EventHandler(this.Arrange_Click);
            // 
            // Removal
            // 
            this.Removal.BackColor = System.Drawing.Color.Thistle;
            this.Removal.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Removal.Location = new System.Drawing.Point(611, 305);
            this.Removal.Name = "Removal";
            this.Removal.Size = new System.Drawing.Size(115, 44);
            this.Removal.TabIndex = 14;
            this.Removal.Text = "Removal";
            this.Removal.UseVisualStyleBackColor = false;
            this.Removal.Click += new System.EventHandler(this.Removal_Click);
            // 
            // Combine
            // 
            this.Combine.BackColor = System.Drawing.Color.Thistle;
            this.Combine.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.Combine.Location = new System.Drawing.Point(611, 206);
            this.Combine.Name = "Combine";
            this.Combine.Size = new System.Drawing.Size(115, 42);
            this.Combine.TabIndex = 16;
            this.Combine.Text = "Combine";
            this.Combine.UseVisualStyleBackColor = false;
            this.Combine.Click += new System.EventHandler(this.Combine_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.Gainsboro;
            this.results.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.results.Location = new System.Drawing.Point(16, 12);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(575, 376);
            this.results.TabIndex = 17;
            this.results.Text = "Here will be displayed the programs results";
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // DistanceRes
            // 
            this.DistanceRes.AutoSize = true;
            this.DistanceRes.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.DistanceRes.Location = new System.Drawing.Point(319, 408);
            this.DistanceRes.Name = "DistanceRes";
            this.DistanceRes.Size = new System.Drawing.Size(179, 19);
            this.DistanceRes.TabIndex = 18;
            this.DistanceRes.Text = "Distances will be displayed here";
            // 
            // Guide
            // 
            this.Guide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Guide.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.Guide.Location = new System.Drawing.Point(611, 355);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(115, 45);
            this.Guide.TabIndex = 19;
            this.Guide.Text = "User Guide";
            this.Guide.UseVisualStyleBackColor = false;
            this.Guide.Click += new System.EventHandler(this.Guide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 482);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.DistanceRes);
            this.Controls.Add(this.results);
            this.Controls.Add(this.Combine);
            this.Controls.Add(this.Removal);
            this.Controls.Add(this.Arrange);
            this.Controls.Add(this.FindDistance);
            this.Controls.Add(this.enterB);
            this.Controls.Add(this.enterA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Public Transport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterA;
        private System.Windows.Forms.TextBox enterB;
        private System.Windows.Forms.Button FindDistance;
        private System.Windows.Forms.Button Arrange;
        private System.Windows.Forms.Button Removal;
        private System.Windows.Forms.Button Combine;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Label DistanceRes;
        private System.Windows.Forms.Button Guide;
    }
}

