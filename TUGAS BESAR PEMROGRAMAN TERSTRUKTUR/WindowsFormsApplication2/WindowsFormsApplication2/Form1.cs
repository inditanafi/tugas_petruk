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
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=notebook;Initial Catalog=login;Integrated Security=True");
            SqlDataAdapter sdt = new SqlDataAdapter("Select role from admin Where username='"+textBox1.Text + "' and pass='" + textBox2.Text + "' ",con);
            DataTable dt = new System.Data.DataTable();
            sdt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MDIParent1 ss = new MDIParent1 ();
                this.Hide();
                ss.Show();
            }
        }
    }
} 
