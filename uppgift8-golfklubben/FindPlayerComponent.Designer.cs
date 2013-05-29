namespace uppgift8_golfklubben
{
    partial class FindPlayerComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.handicap_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_textBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.golfId_textBox = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.age_textBox);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.handicap_textBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.gender_textBox);
            this.groupBox.Controls.Add(this.find_button);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.name_textBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.golfId_textBox);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(230, 152);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Spelare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ålder";
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(56, 120);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.ReadOnly = true;
            this.age_textBox.Size = new System.Drawing.Size(41, 22);
            this.age_textBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Handicap";
            // 
            // handicap_textBox
            // 
            this.handicap_textBox.Location = new System.Drawing.Point(103, 120);
            this.handicap_textBox.Name = "handicap_textBox";
            this.handicap_textBox.ReadOnly = true;
            this.handicap_textBox.Size = new System.Drawing.Size(53, 22);
            this.handicap_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kön";
            // 
            // gender_textBox
            // 
            this.gender_textBox.Location = new System.Drawing.Point(9, 120);
            this.gender_textBox.Name = "gender_textBox";
            this.gender_textBox.ReadOnly = true;
            this.gender_textBox.Size = new System.Drawing.Size(41, 22);
            this.gender_textBox.TabIndex = 12;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(175, 33);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(44, 23);
            this.find_button.TabIndex = 10;
            this.find_button.Text = "Sök";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namn";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(9, 75);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(211, 22);
            this.name_textBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Golf-ID";
            // 
            // golfId_textBox
            // 
            this.golfId_textBox.Location = new System.Drawing.Point(9, 34);
            this.golfId_textBox.Name = "golfId_textBox";
            this.golfId_textBox.Size = new System.Drawing.Size(160, 22);
            this.golfId_textBox.TabIndex = 5;
            // 
            // FindPlayerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "FindPlayerComponent";
            this.Size = new System.Drawing.Size(240, 163);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox handicap_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gender_textBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox golfId_textBox;
    }
}
