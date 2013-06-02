namespace uppgift8_golfklubben
{
    partial class MainWindow
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
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anslutTillDatabasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopplaFrånDatabasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasinställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.medlemslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tävlingslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tidsbokningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookStartTime_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaÖvrigVerksamhetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bookinglist_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connected_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.medlemToolStripMenuItem,
            this.tävlingarToolStripMenuItem,
            this.tidsbokningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anslutTillDatabasToolStripMenuItem,
            this.kopplaFrånDatabasToolStripMenuItem,
            this.databasinställningarToolStripMenuItem,
            this.toolStripSeparator1,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // anslutTillDatabasToolStripMenuItem
            // 
            this.anslutTillDatabasToolStripMenuItem.Name = "anslutTillDatabasToolStripMenuItem";
            this.anslutTillDatabasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.anslutTillDatabasToolStripMenuItem.Text = "Anslut till databas";
            this.anslutTillDatabasToolStripMenuItem.Click += new System.EventHandler(this.anslutTillDatabasToolStripMenuItem_Click);
            // 
            // kopplaFrånDatabasToolStripMenuItem
            // 
            this.kopplaFrånDatabasToolStripMenuItem.Enabled = false;
            this.kopplaFrånDatabasToolStripMenuItem.Name = "kopplaFrånDatabasToolStripMenuItem";
            this.kopplaFrånDatabasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kopplaFrånDatabasToolStripMenuItem.Text = "Koppla från databas";
            this.kopplaFrånDatabasToolStripMenuItem.Click += new System.EventHandler(this.kopplaFrånDatabasToolStripMenuItem_Click);
            // 
            // databasinställningarToolStripMenuItem
            // 
            this.databasinställningarToolStripMenuItem.Name = "databasinställningarToolStripMenuItem";
            this.databasinställningarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.databasinställningarToolStripMenuItem.Text = "Databasinställningar";
            this.databasinställningarToolStripMenuItem.Click += new System.EventHandler(this.databasinställningarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyMedlemToolStripMenuItem,
            this.toolStripSeparator3,
            this.medlemslistaToolStripMenuItem});
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // nyMedlemToolStripMenuItem
            // 
            this.nyMedlemToolStripMenuItem.Name = "nyMedlemToolStripMenuItem";
            this.nyMedlemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nyMedlemToolStripMenuItem.Text = "Ny medlem";
            this.nyMedlemToolStripMenuItem.Click += new System.EventHandler(this.nyMedlemToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // medlemslistaToolStripMenuItem
            // 
            this.medlemslistaToolStripMenuItem.Name = "medlemslistaToolStripMenuItem";
            this.medlemslistaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.medlemslistaToolStripMenuItem.Text = "Medlemslista";
            this.medlemslistaToolStripMenuItem.Click += new System.EventHandler(this.medlemslistaToolStripMenuItem_Click);
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyTävlingToolStripMenuItem,
            this.toolStripSeparator2,
            this.tävlingslistaToolStripMenuItem});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävlingar";
            // 
            // nyTävlingToolStripMenuItem
            // 
            this.nyTävlingToolStripMenuItem.Name = "nyTävlingToolStripMenuItem";
            this.nyTävlingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nyTävlingToolStripMenuItem.Text = "Ny Tävling";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tävlingslistaToolStripMenuItem
            // 
            this.tävlingslistaToolStripMenuItem.Name = "tävlingslistaToolStripMenuItem";
            this.tävlingslistaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tävlingslistaToolStripMenuItem.Text = "Tävlingslista";
            this.tävlingslistaToolStripMenuItem.Click += new System.EventHandler(this.tävlingslistaToolStripMenuItem_Click);
            // 
            // tidsbokningToolStripMenuItem
            // 
            this.tidsbokningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookStartTime_ToolStripMenuItem,
            this.bokaÖvrigVerksamhetToolStripMenuItem,
            this.toolStripSeparator4,
            this.bookinglist_ToolStripMenuItem});
            this.tidsbokningToolStripMenuItem.Enabled = false;
            this.tidsbokningToolStripMenuItem.Name = "tidsbokningToolStripMenuItem";
            this.tidsbokningToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tidsbokningToolStripMenuItem.Text = "Tidsbokning";
            // 
            // bookStartTime_ToolStripMenuItem
            // 
            this.bookStartTime_ToolStripMenuItem.Name = "bookStartTime_ToolStripMenuItem";
            this.bookStartTime_ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.bookStartTime_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bookStartTime_ToolStripMenuItem.Text = "Boka starttid";
            this.bookStartTime_ToolStripMenuItem.Click += new System.EventHandler(this.bookStartTime_ToolStripMenuItem_Click);
            // 
            // bokaÖvrigVerksamhetToolStripMenuItem
            // 
            this.bokaÖvrigVerksamhetToolStripMenuItem.Enabled = false;
            this.bokaÖvrigVerksamhetToolStripMenuItem.Name = "bokaÖvrigVerksamhetToolStripMenuItem";
            this.bokaÖvrigVerksamhetToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bokaÖvrigVerksamhetToolStripMenuItem.Text = "Boka övrig verksamhet";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // bookinglist_ToolStripMenuItem
            // 
            this.bookinglist_ToolStripMenuItem.Name = "bookinglist_ToolStripMenuItem";
            this.bookinglist_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bookinglist_ToolStripMenuItem.Text = "Bokningslista";
            this.bookinglist_ToolStripMenuItem.Click += new System.EventHandler(this.bookinglist_ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connected_statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connected_statusLabel
            // 
            this.connected_statusLabel.Name = "connected_statusLabel";
            this.connected_statusLabel.Size = new System.Drawing.Size(64, 17);
            this.connected_statusLabel.Text = "Ej ansluten";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Golfklubben";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anslutTillDatabasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopplaFrånDatabasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasinställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemslistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyTävlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingslistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tidsbokningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookStartTime_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokaÖvrigVerksamhetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bookinglist_ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connected_statusLabel;
    }
}

