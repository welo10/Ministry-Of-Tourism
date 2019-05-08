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
    public partial class place : Form
    {

        public place()
        {
            InitializeComponent();
        }
        public  String s { get; set; }

        private void place_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ministry_of_tourismDataSet3.Place' table. You can move, or remove it, as needed.
            this.placeTableAdapter1.Fill(this.ministry_of_tourismDataSet3.Place);
            // TODO: This line of code loads data into the 'ministry_of_tourismDataSet.Place' table. You can move, or remove it, as needed.
         //   this.placeTableAdapter.Fill(this.ministry_of_tourismDataSet.Place);
            dataGridView1.DataSource = GetPlace();
            dataGridView1.BorderStyle = BorderStyle.None;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable GetPlace()
        {
            DataTable dtPlace = new DataTable();

            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Place", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            dtPlace.Columns.Add("PlaceName");
            dtPlace.Columns.Add("Location");
            dtPlace.Columns.Add("Price");
            dtPlace.Load(reader);
            reader.Close();
            con.Close();
            dataGridView1.DataSource = dtPlace;
            return dtPlace;
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {}

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {}

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        { }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
           s = Row.Cells[0].Value.ToString();
            reservePlace f = new reservePlace();
            f.s = Row.Cells[0].Value.ToString();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //

        ////
    }
}
