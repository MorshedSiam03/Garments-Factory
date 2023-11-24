using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// library for using SqlClient

namespace GarmentsSoft.Forms
{
    public partial class Client : Form
    {

        // conncect database with project using connection string
        string connString = "Data Source=DESKTOP-GJFPPDJ;Initial Catalog=GarmentsFactory;Integrated Security=True";

        public Client()
        {
            
            InitializeComponent();
        }

   

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label10.ForeColor = ThemeColor.PrimaryColor;
            label11.ForeColor = ThemeColor.PrimaryColor;

            panel1.BackColor = ThemeColor.PrimaryColor;
        }







        private void UserSettingts_Load(object sender, EventArgs e)
        {
            LoadTheme();
            button4.PerformClick();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int outID;
            int outTreadLicance;


            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM [GarmentsFactory].[dbo].[Client] WHERE [Client_ID]=@Client_ID", conn);
            cmd1.Parameters.AddWithValue("@Client_ID", textBox1.Text);
            int count = (int)cmd1.ExecuteScalar();
            if (count > 0)
            {
                // The ID already exists, so don't insert the new record
                MessageBox.Show("ID already exists in table", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.LightCoral;
                    MessageBox.Show("Client ID Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }

                else if (!int.TryParse(textBox1.Text, out outID))
                {
                    textBox1.BackColor = Color.LightCoral;
                    MessageBox.Show("Client ID Failed it's Must be intiger", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }


                else if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Name Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }

                else if (textBox4.Text == "")
                {
                    textBox4.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Email Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                }

                else if (textBox3.Text == "")
                {
                    textBox3.BackColor = Color.LightCoral;
                    MessageBox.Show("Client CompanyName Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                }





                else if (textBox6.Text == "")
                {
                    textBox6.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Trade License No Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                }

                else if (!int.TryParse(textBox6.Text, out outTreadLicance))
                {
                    textBox6.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Tread Licance No Failed it's Must be intiger", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                }

                else if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Phone No Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                }

                else if (textBox9.Text == "")
                {
                    textBox9.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Address Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox9.Focus();
                }

                else if (textBox10.Text == "")
                {
                    textBox10.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Address Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox10.Focus();
                }

                else if (textBox11.Text == "")
                {
                    textBox11.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Address Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox11.Focus();
                }

                else if (comboBox1.Text == "")
                {
                    comboBox1.BackColor = Color.LightCoral;
                    MessageBox.Show("Client Address Failed it's Required", "Validition Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Focus();
                }


                else
                {
                    //SqlConnection conn = new SqlConnection(connString);
                    //conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[Client] values (@Client_ID,@Client_Name,@Client_Email,@Client_CompanyName, @Client_TradeLicenseNo, @Client_PhoneNo, @Client_Address)", conn);
                    cmd.Parameters.AddWithValue("@Client_ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Client_Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Client_Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Client_CompanyName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Client_TradeLicenseNo", int.Parse(textBox6.Text));
                    cmd.Parameters.AddWithValue("@Client_PhoneNo", textBox5.Text + ", " + textBox7.Text);
                    cmd.Parameters.AddWithValue("@Client_Address", textBox9.Text + " " + textBox11.Text + " " + comboBox1.Text + " " + textBox10.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data inserted successfully");
                }
                button4.PerformClick();
            }



            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from [GarmentsFactory].[dbo].[Client]", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //cmd.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter User ID", "Warnning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Client_ID,Client_Name,Client_Email,Client_CompanyName,Client_TradeLicenseNo,Client_PhoneNo,Client_Address  from Client where [Client_ID]  =@Client_ID", conn);
                
                cmd.Parameters.AddWithValue("@Client_ID", textBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox1.Text = dr["Client_ID"].ToString();
                    textBox2.Text = dr["Client_Name"].ToString();
                    textBox4.Text = dr["Client_Email"].ToString();
                    textBox3.Text = dr["Client_CompanyName"].ToString();
                    textBox6.Text = dr["Client_TradeLicenseNo"].ToString();
                    textBox5.Text = dr["Client_PhoneNo"].ToString();
                    textBox9.Text = dr["Client_Address"].ToString();
                    conn.Close();

                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;



                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you want to update the informaion", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update [GarmentsFactory].[dbo].[Client] set [Client_ID] = @Client_ID,  Client_Name = @Client_Name,  Client_Email=@Client_Email,  Client_CompanyName = @Client_CompanyName,   Client_TradeLicenseNo=@Client_TradeLicenseNo, Client_PhoneNo=@Client_PhoneNo, Client_Address=@Client_Address where [Client_ID] = @Client_ID", conn);
                cmd.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Client_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Client_Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Client_CompanyName", textBox3.Text);
                cmd.Parameters.AddWithValue("@Client_TradeLicenseNo", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@Client_PhoneNo", textBox5.Text );
                cmd.Parameters.AddWithValue("@Client_Address", textBox9.Text );

                cmd.ExecuteNonQuery();
                conn.Close();


                SqlConnection conn1 = new SqlConnection(connString); //source from teacher registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [GarmentsFactory].[dbo].[Client] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to remove the informaion", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connString); //remove from teacherRegistration table
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete Client where [Client_ID]  =@Client_ID", conn);
                cmd.Parameters.AddWithValue("@Client_ID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();


                SqlConnection conn1 = new SqlConnection(connString);
                 //source from teacher registration table
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT *FROM [GarmentsFactory].[dbo].[Client] ", conn1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



            
            
            
            

        }
    }
}
