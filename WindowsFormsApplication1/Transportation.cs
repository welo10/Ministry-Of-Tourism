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
    public partial class Transportation : Form
    {
        public Transportation()
        {
            InitializeComponent();
        }
        public String s { get; set; }
    
        private DataTable GetTransportation()
        {
            DataTable dtTransportation = new DataTable();

            SqlConnection con = new SqlConnection("Data Source =DESKTOP-7RCG43D\\SQLEXPRESS; Initial Catalog = Ministry of tourism; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Transportation", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            dtTransportation.Columns.Add("Type");
            dtTransportation.Columns.Add("DepartureTime");
            dtTransportation.Columns.Add("ArrivalTime");
            dtTransportation.Columns.Add("DeparturePlace");
            dtTransportation.Columns.Add("ArrivalPlace");
            dtTransportation.Columns.Add("PlaceID");
            dtTransportation.Load(reader);
            reader.Close();
            con.Close();
            dataGridView1.DataSource = dtTransportation;
            return dtTransportation;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
            s = Row.Cells[0].Value.ToString();
            ReserveTransport f = new ReserveTransport();
            f.s = Row.Cells[0].Value.ToString();
            
            f.Show();
            this.Hide();
        }

        private void Transportation_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ministry_of_tourismDataSet1.Transportation' table. You can move, or remove it, as needed.
            this.transportationTableAdapter.Fill(this.ministry_of_tourismDataSet1.Transportation);
            dataGridView1.DataSource = GetTransportation();
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
