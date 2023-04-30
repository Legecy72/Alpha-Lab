using System;
using System.Data;
using System.Data.SqlClient;

namespace Alpha_Lab
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\querc\source\repos\Alpha Lab\Alpha Lab\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from lab", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into lab "
                + "values(" + txtid.Text + " , '" + txtname.Text + "','" + txtb.Text + "' , '" + txtaddress.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [lab] SET [Name] = '" + txtname.Text + "', " + " [Blood Type] =  '" + txtb.Text + "'  WHERE Id = " + txtid.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM lab WHERE [Id] = " + txtid.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}