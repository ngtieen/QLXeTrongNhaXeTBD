using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataBase;

namespace GiaoDien
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        QLTheXeBU QLTXBU = new QLTheXeBU();
        DoanhThu DThu = new DoanhThu();
        QlDoanhThu QlDoanhThu = new QlDoanhThu();
        string khu;
        void LoadDanhSach()
        {
            dtgvDoanhThu.DataSource = DThu.fDoanhThuHienThiAll();
            txtTongSoLuongXe.Text = QlDoanhThu.CountALL().ToString();
            TinhTongDoanhThu();
        }
        public void TinhTongDoanhThu()
        {
            int TongDoanhThu = 0;
            foreach (DataGridViewRow row in dtgvDoanhThu.Rows)
            {
                TongDoanhThu += int.Parse(row.Cells[7].Value.ToString());
            }
            txtTongDanhThu.Text = Convert.ToString(TongDoanhThu) + ".000";
        }
        private void btnKhuA_Click(object sender, EventArgs e)
        {
            khu = "Khu A";
            dtgvDoanhThu.DataSource = DThu.fDanhThu_HienThiDoanhThuTheoKhu(khu);
            txtTongSoLuongXe.Text = QlDoanhThu.CountKhu(khu).ToString();
            TinhTongDoanhThu();
        }
        private void btnKhuK_Click(object sender, EventArgs e)
        {
            khu = "Khu K";
            dtgvDoanhThu.DataSource = DThu.fDanhThu_HienThiDoanhThuTheoKhu("Khu K");
            txtTongSoLuongXe.Text = QlDoanhThu.CountKhu(khu).ToString();
            TinhTongDoanhThu();
        }
        private void btnKhuO_Click(object sender, EventArgs e)
        {
            khu = "Khu O";
            dtgvDoanhThu.DataSource = DThu.fDanhThu_HienThiDoanhThuTheoKhu("Khu O");
            txtTongSoLuongXe.Text = QlDoanhThu.CountKhu(khu).ToString();
            TinhTongDoanhThu();
        }
        void LoadListXeByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvDoanhThu.DataSource = XeTrongNhaXeDA.Instance.GetXeListByDate(checkIn, checkOut);
        }

        private void dtpcBatDau_ValueChanged(object sender, EventArgs e)
        {
            LoadListXeByDate(dtpcBatDau.Value, dtpcKetThuc.Value);
        }

        private void dtpcKetThuc_ValueChanged(object sender, EventArgs e)
        {
            LoadListXeByDate(dtpcBatDau.Value, dtpcKetThuc.Value);
        }

        private void btnToanKhu_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnDanhSachXe_Click(object sender, EventArgs e)
        {
            LoadListXeByDate(dtpcBatDau.Value, dtpcKetThuc.Value);
        }
        private void btnThemTheXe_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSoThe.Text == null || txtSoThe.Text == "") errorProvider1.SetError(txtSoThe, "Không Hợp Lệ !!!");
            else
            {
                QLTXBU.TaoThemTheXe(int.Parse(txtSoThe.Text));
                MessageBox.Show($"Đã thêm {txtSoThe.Text} thẻ");
            }
        }
    }
}
