namespace uppgift8_golfklubben
{
    partial class MemberlistWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberlistWindow));
            this.members_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.new_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.view_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.remove_toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.members_dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // members_dataGridView
            // 
            this.members_dataGridView.AllowUserToAddRows = false;
            this.members_dataGridView.AllowUserToDeleteRows = false;
            this.members_dataGridView.AllowUserToResizeRows = false;
            this.members_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.members_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.members_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.members_dataGridView.Location = new System.Drawing.Point(0, 28);
            this.members_dataGridView.MultiSelect = false;
            this.members_dataGridView.Name = "members_dataGridView";
            this.members_dataGridView.ReadOnly = true;
            this.members_dataGridView.RowHeadersVisible = false;
            this.members_dataGridView.RowTemplate.Height = 24;
            this.members_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.members_dataGridView.Size = new System.Drawing.Size(584, 336);
            this.members_dataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_toolStripButton,
            this.view_toolStripButton,
            this.edit_toolStripButton,
            this.remove_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // new_toolStripButton
            // 
            this.new_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_toolStripButton.Name = "new_toolStripButton";
            this.new_toolStripButton.Size = new System.Drawing.Size(73, 22);
            this.new_toolStripButton.Text = "Ny medlem";
            this.new_toolStripButton.Click += new System.EventHandler(this.new_toolStripButton_Click);
            // 
            // view_toolStripButton
            // 
            this.view_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.view_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.view_toolStripButton.Name = "view_toolStripButton";
            this.view_toolStripButton.Size = new System.Drawing.Size(32, 22);
            this.view_toolStripButton.Text = "Visa";
            this.view_toolStripButton.Click += new System.EventHandler(this.view_toolStripButton_Click);
            // 
            // edit_toolStripButton
            // 
            this.edit_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.edit_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("edit_toolStripButton.Image")));
            this.edit_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_toolStripButton.Name = "edit_toolStripButton";
            this.edit_toolStripButton.Size = new System.Drawing.Size(43, 22);
            this.edit_toolStripButton.Text = "Ändra";
            // 
            // remove_toolStripButton
            // 
            this.remove_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.remove_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("remove_toolStripButton.Image")));
            this.remove_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remove_toolStripButton.Name = "remove_toolStripButton";
            this.remove_toolStripButton.Size = new System.Drawing.Size(49, 22);
            this.remove_toolStripButton.Text = "Ta bort";
            // 
            // MemberlistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.members_dataGridView);
            this.Name = "MemberlistWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medlemslista";
            ((System.ComponentModel.ISupportInitialize)(this.members_dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView members_dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton new_toolStripButton;
        private System.Windows.Forms.ToolStripButton view_toolStripButton;
        private System.Windows.Forms.ToolStripButton edit_toolStripButton;
        private System.Windows.Forms.ToolStripButton remove_toolStripButton;
    }
}