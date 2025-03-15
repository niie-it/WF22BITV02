using System.Data;
using System.Data.SqlClient;

namespace DemoCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = "Data Source=.;Initial Catalog=QLHocSinh;Integrated Security=True;";
        private void Form1_Load(object sender, EventArgs e)
        {
            //lấy dữ liệu đổ vô DataGridView
            var conn = new SqlConnection(chuoiKetNoi);
            var query = "SELECT * FROM HocSinh";
            var da = new SqlDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;
        }
    }
}
