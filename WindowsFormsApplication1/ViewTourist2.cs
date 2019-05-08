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
    public partial class ViewTourist2 : Form
    {
        public ViewTourist2()
        {
            InitializeComponent();
        }
        public String s { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
            s = Row.Cells[0].Value.ToString();
          EditTourist f=   new EditTourist();
           f.s = Row.Cells[0].Value.ToString();

          f.Show();
            this.Hide();
        }
        private DataTable GetTourist1()
        {
            DataTable dttourist = new DataTable();

            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tourist", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            dttourist.Columns.Add("TouristID");
            dttourist.Columns.Add("TouristName");
            dttourist.Columns.Add("Mail");
            dttourist.Columns.Add("Telephone");
            dttourist.Columns.Add("Pass");
            dttourist.Columns.Add("WayOfPayment");
            dttourist.Load(reader);
            reader.Close();
            con.Close();
            dataGridView1.DataSource = dttourist;
            return dttourist;
        }
     
        private void ViewTourist2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ministry_of_tourismDataSet2.Tourist' table. You can move, or remove it, as needed.
            this.touristTableAdapter.Fill(this.ministry_of_tourismDataSet2.Tourist);
            dataGridView1.DataSource = GetTourist1();
            dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            // dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(96, 199, 193);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(178, 176, 176);

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
