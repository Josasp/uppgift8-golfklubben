namespace uppgift8_golfklubben
{
    partial class BookingWindow
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.time_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.players_comboBox = new System.Windows.Forms.ComboBox();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weekDay_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.time_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar.Location = new System.Drawing.Point(333, 84);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            // 
            // time_dataGridView
            // 
            this.time_dataGridView.AllowUserToAddRows = false;
            this.time_dataGridView.AllowUserToDeleteRows = false;
            this.time_dataGridView.AllowUserToResizeColumns = false;
            this.time_dataGridView.AllowUserToResizeRows = false;
            this.time_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.time_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.time_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.time_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Player1,
            this.Player2,
            this.Player3,
            this.Player4});
            this.time_dataGridView.Location = new System.Drawing.Point(12, 84);
            this.time_dataGridView.Name = "time_dataGridView";
            this.time_dataGridView.ReadOnly = true;
            this.time_dataGridView.RowHeadersVisible = false;
            this.time_dataGridView.RowTemplate.Height = 24;
            this.time_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.time_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.time_dataGridView.Size = new System.Drawing.Size(309, 311);
            this.time_dataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weekDay_comboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gender_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.time_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.players_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spelare";
            // 
            // time_comboBox
            // 
            this.time_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_comboBox.FormattingEnabled = true;
            this.time_comboBox.Items.AddRange(new object[] {
            "-",
            "0:00",
            "0:10",
            "0:20",
            "0:30",
            "0:40",
            "0:50",
            "1:00",
            "1:10",
            "1:20",
            "1:30",
            "1:40",
            "1:50",
            "2:00",
            "2:10",
            "2:20",
            "2:30",
            "2:40",
            "2:50",
            "3:00",
            "3:10",
            "3:20",
            "3:30",
            "3:40",
            "3:50",
            "4:00",
            "4:10",
            "4:20",
            "4:30",
            "4:40",
            "4:50",
            "5:00",
            "5:10",
            "5:20",
            "5:30",
            "5:40",
            "5:50",
            "6:00",
            "6:10",
            "6:20",
            "6:30",
            "6:40",
            "6:50",
            "7:00",
            "7:10",
            "7:20",
            "7:30",
            "7:40",
            "7:50",
            "8:00",
            "8:10",
            "8:20",
            "8:30",
            "8:40",
            "8:50",
            "9:00",
            "9:10",
            "9:20",
            "9:30",
            "9:40",
            "9:50",
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
            this.time_comboBox.Location = new System.Drawing.Point(104, 37);
            this.time_comboBox.Name = "time_comboBox";
            this.time_comboBox.Size = new System.Drawing.Size(54, 21);
            this.time_comboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tid";
            // 
            // players_comboBox
            // 
            this.players_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.players_comboBox.FormattingEnabled = true;
            this.players_comboBox.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3",
            "4"});
            this.players_comboBox.Location = new System.Drawing.Point(164, 37);
            this.players_comboBox.Name = "players_comboBox";
            this.players_comboBox.Size = new System.Drawing.Size(45, 21);
            this.players_comboBox.TabIndex = 2;
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "-",
            "Man",
            "Kvinna"});
            this.gender_comboBox.Location = new System.Drawing.Point(215, 37);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(88, 21);
            this.gender_comboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kön";
            // 
            // weekDay_comboBox
            // 
            this.weekDay_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekDay_comboBox.FormattingEnabled = true;
            this.weekDay_comboBox.Items.AddRange(new object[] {
            "-",
            "Måndag",
            "Tisdag",
            "Onsdag",
            "Torsdag",
            "Fredag",
            "Lördag",
            "Söndag"});
            this.weekDay_comboBox.Location = new System.Drawing.Point(6, 37);
            this.weekDay_comboBox.Name = "weekDay_comboBox";
            this.weekDay_comboBox.Size = new System.Drawing.Size(92, 21);
            this.weekDay_comboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Veckodag";
            // 
            // Time
            // 
            this.Time.HeaderText = "Tid";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Player1
            // 
            this.Player1.HeaderText = "Spelare 1";
            this.Player1.Name = "Player1";
            this.Player1.ReadOnly = true;
            // 
            // Player2
            // 
            this.Player2.HeaderText = "Spelare 2";
            this.Player2.Name = "Player2";
            this.Player2.ReadOnly = true;
            // 
            // Player3
            // 
            this.Player3.HeaderText = "Spelare 3";
            this.Player3.Name = "Player3";
            this.Player3.ReadOnly = true;
            // 
            // Player4
            // 
            this.Player4.HeaderText = "Spelare 4";
            this.Player4.Name = "Player4";
            this.Player4.ReadOnly = true;
            // 
            // book_button
            // 
            this.book_button.Location = new System.Drawing.Point(12, 401);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(75, 23);
            this.book_button.TabIndex = 3;
            this.book_button.Text = "Boka tid";
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(93, 401);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Ändra tid";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // BookingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.book_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.time_dataGridView);
            this.Controls.Add(this.monthCalendar);
            this.Name = "BookingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bokningslista";
            ((System.ComponentModel.ISupportInitialize)(this.time_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView time_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox players_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox time_comboBox;
        private System.Windows.Forms.ComboBox weekDay_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player4;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.Button edit_button;
    }
}