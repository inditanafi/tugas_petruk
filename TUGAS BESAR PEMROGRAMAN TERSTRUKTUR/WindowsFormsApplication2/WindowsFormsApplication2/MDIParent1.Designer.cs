namespace WindowsFormsApplication2
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendudukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPendudukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKartuKeluargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMutasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendudukToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pendudukToolStripMenuItem
            // 
            this.pendudukToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPendudukToolStripMenuItem,
            this.dataKartuKeluargaToolStripMenuItem,
            this.dataMutasiToolStripMenuItem});
            this.pendudukToolStripMenuItem.Name = "pendudukToolStripMenuItem";
            this.pendudukToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pendudukToolStripMenuItem.Text = "Penduduk";
            this.pendudukToolStripMenuItem.Click += new System.EventHandler(this.pendudukToolStripMenuItem_Click);
            // 
            // dataPendudukToolStripMenuItem
            // 
            this.dataPendudukToolStripMenuItem.Name = "dataPendudukToolStripMenuItem";
            this.dataPendudukToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dataPendudukToolStripMenuItem.Text = "Data Penduduk";
            this.dataPendudukToolStripMenuItem.Click += new System.EventHandler(this.dataPendudukToolStripMenuItem_Click);
            // 
            // dataKartuKeluargaToolStripMenuItem
            // 
            this.dataKartuKeluargaToolStripMenuItem.Name = "dataKartuKeluargaToolStripMenuItem";
            this.dataKartuKeluargaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dataKartuKeluargaToolStripMenuItem.Text = "Data Kartu Keluarga";
            this.dataKartuKeluargaToolStripMenuItem.Click += new System.EventHandler(this.dataKartuKeluargaToolStripMenuItem_Click);
            // 
            // dataMutasiToolStripMenuItem
            // 
            this.dataMutasiToolStripMenuItem.Name = "dataMutasiToolStripMenuItem";
            this.dataMutasiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dataMutasiToolStripMenuItem.Text = "Data Mutasi";
            this.dataMutasiToolStripMenuItem.Click += new System.EventHandler(this.dataMutasiToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Pulau_Seram1;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendudukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPendudukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKartuKeluargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMutasiToolStripMenuItem;
    }
}



