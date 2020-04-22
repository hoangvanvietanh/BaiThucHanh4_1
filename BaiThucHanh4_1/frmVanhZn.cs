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
    public partial class frmVanhZn : Form
    {
        
        #region Khai báo biến
        private char code = 'Z';
        #endregion

        #region Các hàm tạo
        public frmVanhZn()
        {
            InitializeComponent();
        }
        #endregion

        #region Các phương thức

        #endregion

        #region Các xử lý
        private void nudN_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCong_Click_1(object sender, EventArgs e)
        {
            int n = (int)(nudN.Value);
            frmBangPhepCong frm = new frmBangPhepCong(code, n); 
            frm.MdiParent = this.MdiParent; 
            frm.Show();
        }

        private void btnNhan_Click_1(object sender, EventArgs e)
        {
            int n = (int)(nudN.Value); 
            frmBangPhepNhan frm = new frmBangPhepNhan(code, n);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLuyThua_Click_1(object sender, EventArgs e)
        {
            int n = (int)(nudN.Value); 
            frmBangPhepLuyThua frm = new frmBangPhepLuyThua(code, n); 
            frm.MdiParent = this.MdiParent; 
            frm.Show();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


    }
}
