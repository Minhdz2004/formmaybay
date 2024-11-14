using System.Data;

namespace formsanbay
{
    public partial class sanbay : Form
    {
        public sanbay()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void sanbay_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string query = "select * from MayBay";
            DataSet ds = kn.LayDuLieu(query);
            if (ds != null)
            {
                datamaybay.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemMayBay them = new ThemMayBay();
            them.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SuaMayBay sua = new SuaMayBay();   
            sua.Show();
        }

    }
}
