using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class datakk : Form
    {
        public datakk()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=notebook\;Initial Catalog=login;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM datakk";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sdt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            //String query = "INSERT INTO Penduduk (No_KK, NIK, Nama, Tempat_lahir, Tanggal_lahir, Jk, Alamat, Agama, Status_kawin, Pekerjaan, Kwarganegaraan) VALUES ('" + text_nokk.Text + "','" + text_nik.Text + "','" + text_nama.Text + "','" + text_tpt_lhr.Text + "','" + text_tgl_lhr.Text + "','" + comboBox_jk.Text + "','" + text_alamat.Text + "','" + text_agama.Text + "','" + comboBox_status.Text + "','" + text_pekerjaan.Text + "','" + text_kewarnegaraan.Text + "')";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //SDA.SelectCommand.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [datakk] (No_KK,NIK,Nama,Tempat_lahir,Tanggal_lahir,Jk,Alamat,Agama,Status_kawin,Pekerjaan,Kwarganegaraan) VALUES ('"
                + text_nokk.Text + "','" + text_nik.Text + "','" + text_nama.Text + "','" + text_tpt_lhr.Text + "','" 
                + text_tgl_lhr.Text + "','" + comboBox_jk.Text + "','" + text_alamat.Text + "','" + text_agama.Text + "','" 
                + comboBox_status.Text + "','" + text_pekerjaan.Text + "','" + text_kewarnegaraan.Text + "')";
            cmd.ExecuteNonQuery();
            //SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            //sdt.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Success");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM [datakk] where No_KK = '" + text_nokk.Text + "'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RECORD DELETE");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            text_nokk.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            text_nik.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            text_nama.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            text_tpt_lhr.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            text_tgl_lhr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox_jk.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            text_alamat.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            text_agama.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBox_status.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            text_pekerjaan.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            text_kewarnegaraan.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE datakk  SET No_KK='" + text_nokk.Text + "', NIK='" + text_nik.Text + "',Nama = '" + text_nama.Text + 
                "',Tempat_lahir='" + text_tpt_lhr.Text + "',Tanggal_lahir='" + text_tgl_lhr.Text + "',Jk='" + comboBox_jk.Text + 
                "',Alamat='" + text_alamat.Text + "',Agama='" + text_agama.Text + "',Status_kawin='" + comboBox_status.Text + 
                "',Pekerjaan='" + text_pekerjaan.Text + "',Kwarganegaraan='" + text_kewarnegaraan.Text + "'WHERE No_KK = '" + text_nokk.Text + "'";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            sdt.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESS");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text_nokk.Text = string.Empty;
            text_nik.Text = string.Empty;
            text_nama.Text = string.Empty;
            text_tpt_lhr.Text = string.Empty;
            text_tgl_lhr.Text = string.Empty;
            comboBox_jk.SelectedIndex = 0;
            text_alamat.Text = string.Empty;
            text_agama.Text = string.Empty;
            comboBox_status.SelectedIndex = 0;
            text_pekerjaan.Text = string.Empty;
            text_kewarnegaraan.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MDIParent1 ss = new MDIParent1();
            this.Hide();
           // ss.Show();

        }
    }
}
