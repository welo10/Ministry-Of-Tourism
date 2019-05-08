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

namespace WindowsFormsApplication1
{
    public partial class ReserveTransport : Form
    {
        public ReserveTransport()
        {
            InitializeComponent();
        }
        public String s { get; set; }
        public string id { get; set; }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ReserveTransport_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(96, 199, 193);
            
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String str = @"select * from Transportation where TransportationID=@ID";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.Add(new SqlParameter("@ID", s));
            //  SqlParameter param1 = new SqlParameter("@ID", s);

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    label4.Text = oReader["Type"].ToString();
                    label5.Text = oReader["DepartureTime"].ToString();
                    label6.Text = oReader["ArrivalTime"].ToString();
                    label7.Text = oReader["ArrivalPlace"].ToString();
                    label8.Text = oReader["DeparturePlace"].ToString();
                }

                con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("AddTouristTrans", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TransID", s));
            cmd.Parameters.Add(new SqlParameter("@touristID", Global.GlobalVar));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Confirmed , Thank You");
            new mainmenu().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new mainmenu().Show();
            this.Hide();
        }
    }
}
