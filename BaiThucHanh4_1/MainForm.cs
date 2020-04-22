using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh4_1
{
    public partial class MainForm : Form
    {

        #region Khai báo biến

        #endregion

        #region Các hàm tạo
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Các phương thức
        public static String Ten(char code)
        {
            return (code == 'Z') ? "Vành Z" : "Trường Q";
        }

        #endregion

        #region Các xử lý

        private void mnuVanhZn_Click(object sender, EventArgs e)
        {
            frmVanhZn frm = new frmVanhZn(); 
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTruongQp_Click(object sender, EventArgs e)
        {
            frmTruongQp frm = new frmTruongQp();
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion


    }
}
