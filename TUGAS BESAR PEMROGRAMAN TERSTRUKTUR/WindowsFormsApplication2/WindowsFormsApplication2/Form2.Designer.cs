namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.text_nik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_jk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_nama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_nokk = new System.Windows.Forms.TextBox();
            this.text_tpt_lhr = new System.Windows.Forms.TextBox();
            this.text_alamat = new System.Windows.Forms.TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.text_pekerjaan = new System.Windows.Forms.TextBox();
            this.text_kewarnegaraan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_agama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_tgl_lhr = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = " NIK";
            // 
            // text_nik
            // 
            this.text_nik.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nik.Location = new System.Drawing.Point(145, 60);
            this.text_nik.Name = "text_nik";
            this.text_nik.Size = new System.Drawing.Size(168, 26);
            this.text_nik.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_jk
            // 
            this.comboBox_jk.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_jk.FormattingEnabled = true;
            this.comboBox_jk.Items.AddRange(new object[] {
            "-- Pilih Salah Satu --",
            "Wanita",
            "laki-laki"});
            this.comboBox_jk.Location = new System.Drawing.Point(145, 204);
            this.comboBox_jk.Name = "comboBox_jk";
            this.comboBox_jk.Size = new System.Drawing.Size(168, 27);
            this.comboBox_jk.TabIndex = 3;
            this.comboBox_jk.SelectedIndexChanged += new System.EventHandler(this.combo_jk_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tempat Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status Kawin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pekerjaan";
            // 
            // text_nama
            // 
            this.text_nama.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nama.Location = new System.Drawing.Point(145, 96);
            this.text_nama.Name = "text_nama";
            this.text_nama.Size = new System.Drawing.Size(168, 26);
            this.text_nama.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kewarganegaraan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "No KK";
            // 
            // text_nokk
            // 
            this.text_nokk.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nokk.Location = new System.Drawing.Point(145, 20);
            this.text_nokk.Name = "text_nokk";
            this.text_nokk.Size = new System.Drawing.Size(168, 26);
            this.text_nokk.TabIndex = 14;
            // 
            // text_tpt_lhr
            // 
            this.text_tpt_lhr.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tpt_lhr.Location = new System.Drawing.Point(145, 132);
            this.text_tpt_lhr.Name = "text_tpt_lhr";
            this.text_tpt_lhr.Size = new System.Drawing.Size(168, 26);
            this.text_tpt_lhr.TabIndex = 17;
            // 
            // text_alamat
            // 
            this.text_alamat.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_alamat.Location = new System.Drawing.Point(145, 244);
            this.text_alamat.Name = "text_alamat";
            this.text_alamat.Size = new System.Drawing.Size(168, 26);
            this.text_alamat.TabIndex = 16;
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "-- Pilih Salah Satu --",
            "Kawin",
            "Belum Kawin"});
            this.comboBox_status.Location = new System.Drawing.Point(145, 320);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(168, 27);
            this.comboBox_status.TabIndex = 18;
            // 
            // text_pekerjaan
            // 
            this.text_pekerjaan.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pekerjaan.Location = new System.Drawing.Point(145, 360);
            this.text_pekerjaan.Name = "text_pekerjaan";
            this.text_pekerjaan.Size = new System.Drawing.Size(168, 26);
            this.text_pekerjaan.TabIndex = 23;
            // 
            // text_kewarnegaraan
            // 
            this.text_kewarnegaraan.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_kewarnegaraan.Location = new System.Drawing.Point(145, 399);
            this.text_kewarnegaraan.Name = "text_kewarnegaraan";
            this.text_kewarnegaraan.Size = new System.Drawing.Size(168, 26);
            this.text_kewarnegaraan.TabIndex = 22;
            this.text_kewarnegaraan.TextChanged += new System.EventHandler(this.text_kewarganegaraan_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(484, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(598, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(707, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(914, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(717, 317);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // text_agama
            // 
            this.text_agama.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_agama.Location = new System.Drawing.Point(145, 283);
            this.text_agama.Name = "text_agama";
            this.text_agama.Size = new System.Drawing.Size(168, 26);
            this.text_agama.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Agama";
            // 
            // text_tgl_lhr
            // 
            this.text_tgl_lhr.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tgl_lhr.Location = new System.Drawing.Point(145, 172);
            this.text_tgl_lhr.Name = "text_tgl_lhr";
            this.text_tgl_lhr.Size = new System.Drawing.Size(168, 26);
            this.text_tgl_lhr.TabIndex = 32;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(812, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1078, 453);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.text_tgl_lhr);
            this.Controls.Add(this.text_agama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_pekerjaan);
            this.Controls.Add(this.text_kewarnegaraan);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.text_tpt_lhr);
            this.Controls.Add(this.text_alamat);
            this.Controls.Add(this.text_nokk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_nama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_jk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_nik);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_jk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_nokk;
        private System.Windows.Forms.TextBox text_tpt_lhr;
        private System.Windows.Forms.TextBox text_alamat;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.TextBox text_pekerjaan;
        private System.Windows.Forms.TextBox text_kewarnegaraan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_agama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_tgl_lhr;
        //private loginDataSet loginDataSet;
       // private System.Windows.Forms.BindingSource adminBindingSource;
        //private loginDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button button6;
    }
}