using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsanbay
{
    public partial class ThemMayBay : Form
    {
        public ThemMayBay()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void ThemMayBay_Load(object sender, EventArgs e)
        {

        }

        private void them_Click_1(object sender, EventArgs e)
        {
            string query = string.Format(
               "insert into MayBay VALUES('{0}', N'{1}', {2}, {3})",
             txtmamb.Text,
             txttenmb.Text,
             txtnamsx.Text,
             txtsogiobay.Text

           );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                sanbay sb = new sanbay();
                sb.Show();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }
    }
}
