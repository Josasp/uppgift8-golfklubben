namespace uppgift8_golfklubben
{
    partial class CompetitionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.players_dataGridView = new System.Windows.Forms.DataGridView();
            this.classes_dataGridView = new System.Windows.Forms.DataGridView();
            this.times_dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.times_addButton = new System.Windows.Forms.Button();
            this.times_remButton = new System.Windows.Forms.Button();
            this.classes_remButton = new System.Windows.Forms.Button();
            this.classes_addButton = new System.Windows.Forms.Button();
            this.players_remButton = new System.Windows.Forms.Button();
            this.players_addButton = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.saveName_button = new System.Windows.Forms.Button();
            this.date_textBox = new System.Windows.Forms.TextBox();
            this.time_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.players_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classes_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.times_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tävlingsnamn";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(15, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(262, 22);
            this.name_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deltagare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klasser";
            // 
            // players_dataGridView
            // 
            this.players_dataGridView.AllowUserToAddRows = false;
            this.players_dataGridView.AllowUserToDeleteRows = false;
            this.players_dataGridView.AllowUserToResizeRows = false;
            this.players_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.players_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.players_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.players_dataGridView.Location = new System.Drawing.Point(14, 135);
            this.players_dataGridView.MultiSelect = false;
            this.players_dataGridView.Name = "players_dataGridView";
            this.players_dataGridView.ReadOnly = true;
            this.players_dataGridView.RowHeadersVisible = false;
            this.players_dataGridView.RowTemplate.Height = 24;
            this.players_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.players_dataGridView.Size = new System.Drawing.Size(237, 422);
            this.players_dataGridView.TabIndex = 6;
            // 
            // classes_dataGridView
            // 
            this.classes_dataGridView.AllowUserToAddRows = false;
            this.classes_dataGridView.AllowUserToDeleteRows = false;
            this.classes_dataGridView.AllowUserToResizeRows = false;
            this.classes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classes_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.classes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classes_dataGridView.Location = new System.Drawing.Point(260, 385);
            this.classes_dataGridView.MultiSelect = false;
            this.classes_dataGridView.Name = "classes_dataGridView";
            this.classes_dataGridView.ReadOnly = true;
            this.classes_dataGridView.RowHeadersVisible = false;
            this.classes_dataGridView.RowTemplate.Height = 24;
            this.classes_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classes_dataGridView.Size = new System.Drawing.Size(237, 172);
            this.classes_dataGridView.TabIndex = 7;
            this.classes_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // times_dataGridView
            // 
            this.times_dataGridView.AllowUserToAddRows = false;
            this.times_dataGridView.AllowUserToDeleteRows = false;
            this.times_dataGridView.AllowUserToResizeRows = false;
            this.times_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.times_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.times_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.times_dataGridView.Location = new System.Drawing.Point(260, 135);
            this.times_dataGridView.MultiSelect = false;
            this.times_dataGridView.Name = "times_dataGridView";
            this.times_dataGridView.ReadOnly = true;
            this.times_dataGridView.RowHeadersVisible = false;
            this.times_dataGridView.RowTemplate.Height = 24;
            this.times_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.times_dataGridView.Size = new System.Drawing.Size(237, 176);
            this.times_dataGridView.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tider";
            // 
            // times_addButton
            // 
            this.times_addButton.Location = new System.Drawing.Point(430, 317);
            this.times_addButton.Name = "times_addButton";
            this.times_addButton.Size = new System.Drawing.Size(29, 23);
            this.times_addButton.TabIndex = 10;
            this.times_addButton.Text = "+";
            this.times_addButton.UseVisualStyleBackColor = true;
            // 
            // times_remButton
            // 
            this.times_remButton.Location = new System.Drawing.Point(465, 317);
            this.times_remButton.Name = "times_remButton";
            this.times_remButton.Size = new System.Drawing.Size(29, 23);
            this.times_remButton.TabIndex = 11;
            this.times_remButton.Text = "-";
            this.times_remButton.UseVisualStyleBackColor = true;
            // 
            // classes_remButton
            // 
            this.classes_remButton.Location = new System.Drawing.Point(468, 563);
            this.classes_remButton.Name = "classes_remButton";
            this.classes_remButton.Size = new System.Drawing.Size(29, 23);
            this.classes_remButton.TabIndex = 13;
            this.classes_remButton.Text = "-";
            this.classes_remButton.UseVisualStyleBackColor = true;
            // 
            // classes_addButton
            // 
            this.classes_addButton.Location = new System.Drawing.Point(433, 563);
            this.classes_addButton.Name = "classes_addButton";
            this.classes_addButton.Size = new System.Drawing.Size(29, 23);
            this.classes_addButton.TabIndex = 12;
            this.classes_addButton.Text = "+";
            this.classes_addButton.UseVisualStyleBackColor = true;
            // 
            // players_remButton
            // 
            this.players_remButton.Location = new System.Drawing.Point(222, 563);
            this.players_remButton.Name = "players_remButton";
            this.players_remButton.Size = new System.Drawing.Size(29, 23);
            this.players_remButton.TabIndex = 15;
            this.players_remButton.Text = "-";
            this.players_remButton.UseVisualStyleBackColor = true;
            // 
            // players_addButton
            // 
            this.players_addButton.Location = new System.Drawing.Point(187, 563);
            this.players_addButton.Name = "players_addButton";
            this.players_addButton.Size = new System.Drawing.Size(29, 23);
            this.players_addButton.TabIndex = 14;
            this.players_addButton.Text = "+";
            this.players_addButton.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(422, 607);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 16;
            this.ok_button.Text = "Klar";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(15, 607);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 23);
            this.remove_button.TabIndex = 17;
            this.remove_button.Text = "Radera";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // saveName_button
            // 
            this.saveName_button.Location = new System.Drawing.Point(226, 65);
            this.saveName_button.Name = "saveName_button";
            this.saveName_button.Size = new System.Drawing.Size(53, 23);
            this.saveName_button.TabIndex = 18;
            this.saveName_button.Text = "Spara";
            this.saveName_button.UseVisualStyleBackColor = true;
            this.saveName_button.Click += new System.EventHandler(this.saveName_button_Click);
            // 
            // date_textBox
            // 
            this.date_textBox.Location = new System.Drawing.Point(15, 66);
            this.date_textBox.Name = "date_textBox";
            this.date_textBox.Size = new System.Drawing.Size(143, 22);
            this.date_textBox.TabIndex = 23;
            this.date_textBox.Enter += new System.EventHandler(this.date_textBox_Enter);
            this.date_textBox.Leave += new System.EventHandler(this.date_textBox_Leave);
            // 
            // time_comboBox
            // 
            this.time_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_comboBox.FormattingEnabled = true;
            this.time_comboBox.Items.AddRange(new object[] {
            "00:00",
            "00:10",
            "00:20",
            "00:30",
            "00:40",
            "00:50",
            "01:00",
            "01:10",
            "01:20",
            "01:30",
            "01:40",
            "01:50",
            "02:00",
            "02:10",
            "02:20",
            "02:30",
            "02:40",
            "02:50",
            "03:00",
            "03:10",
            "03:20",
            "03:30",
            "03:40",
            "03:50",
            "04:00",
            "04:10",
            "04:20",
            "04:30",
            "04:40",
            "04:50",
            "05:00",
            "05:10",
            "05:20",
            "05:30",
            "05:40",
            "05:50",
            "06:00",
            "06:10",
            "06:20",
            "06:30",
            "06:40",
            "06:50",
            "07:00",
            "07:10",
            "07:20",
            "07:30",
            "07:40",
            "07:50",
            "08:00",
            "08:10",
            "08:20",
            "08:30",
            "08:40",
            "08:50",
            "09:00",
            "09:10",
            "09:20",
            "09:30",
            "09:40",
            "09:50",
            "10:00",
            "10:10",
            "10:20",
            "10:30",
            "10:40",
            "10:50",
            "11:00",
            "11:10",
            "11:20",
            "11:30",
            "11:40",
            "11:50",
            "12:00",
            "12:10",
            "12:20",
            "12:30",
            "12:40",
            "12:50",
            "13:00",
            "13:10",
            "13:20",
            "13:30",
            "13:40",
            "13:50",
            "14:00",
            "14:10",
            "14:20",
            "14:30",
            "14:40",
            "14:50",
            "15:00",
            "15:10",
            "15:20",
            "15:30",
            "15:40",
            "15:50",
            "16:00",
            "16:10",
            "16:20",
            "16:30",
            "16:40",
            "16:50",
            "17:00",
            "17:10",
            "17:20",
            "17:30",
            "17:40",
            "17:50",
            "18:00",
            "18:10",
            "18:20",
            "18:30",
            "18:40",
            "18:50",
            "19:00",
            "19:10",
            "19:20",
            "19:30",
            "19:40",
            "19:50",
            "20:00",
            "20:10",
            "20:20",
            "20:30",
            "20:40",
            "20:50",
            "21:00",
            "21:10",
            "21:20",
            "21:30",
            "21:40",
            "21:50",
            "22:00",
            "22:10",
            "22:20",
            "22:30",
            "22:40",
            "22:50",
            "23:00",
            "23:10",
            "23:20",
            "23:30",
            "23:40",
            "23:50"});
            this.time_comboBox.Location = new System.Drawing.Point(164, 66);
            this.time_comboBox.Name = "time_comboBox";
            this.time_comboBox.Size = new System.Drawing.Size(56, 21);
            this.time_comboBox.TabIndex = 22;
            this.time_comboBox.SelectedIndexChanged += new System.EventHandler(this.time_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Anmälan stänger";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(15, 89);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 21;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 642);
            this.Controls.Add(this.date_textBox);
            this.Controls.Add(this.time_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.saveName_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.players_remButton);
            this.Controls.Add(this.players_addButton);
            this.Controls.Add(this.classes_remButton);
            this.Controls.Add(this.classes_addButton);
            this.Controls.Add(this.times_remButton);
            this.Controls.Add(this.times_addButton);
            this.Controls.Add(this.times_dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classes_dataGridView);
            this.Controls.Add(this.players_dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label1);
            this.Name = "CompetitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tävling";
            ((System.ComponentModel.ISupportInitialize)(this.players_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classes_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.times_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView players_dataGridView;
        private System.Windows.Forms.DataGridView classes_dataGridView;
        private System.Windows.Forms.DataGridView times_dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button times_addButton;
        private System.Windows.Forms.Button times_remButton;
        private System.Windows.Forms.Button classes_remButton;
        private System.Windows.Forms.Button classes_addButton;
        private System.Windows.Forms.Button players_remButton;
        private System.Windows.Forms.Button players_addButton;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button saveName_button;
        private System.Windows.Forms.TextBox date_textBox;
        private System.Windows.Forms.ComboBox time_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}