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
    public partial class reservePlace : Form
    {
        public reservePlace()
        {
            InitializeComponent();
        }
        public String s { get; set; }
        public string id { get; set; }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void click()
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("AddTouristPlace", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@plac", s));
            cmd.Parameters.Add(new SqlParameter("@touristID", Global.GlobalVar));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Confirmed , Thank You");
            new mainmenu().Show();
            this.Hide();
        }


        private void reservePlace_Load(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(96, 199, 193);
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            String str = @"select * from Place where PlaceID=@ID";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.Add(new SqlParameter("@ID", s));
            //  SqlParameter param1 = new SqlParameter("@ID", s);

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    label4.Text = oReader["PlaceName"].ToString();
                    label5.Text = oReader["Location"].ToString();
                    label6.Text = oReader["Price"].ToString();

                }

                con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new mainmenu().Show();
            this.Hide();
        }
    }
}
