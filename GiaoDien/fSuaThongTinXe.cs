using Business;
using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fSuaThongTinXe : Form
    {
        private int id;
        private int idThe;
        private string ngayVao;
        public fSuaThongTinXe(string id, string TenKhuXe, string BienSoXe, string IdThe, string TenLoaiXe, string NgayXeVao, string giaGui)
        {
            InitializeComponent();
            this.idThe = int.Parse(IdThe);
            this.id = int.Parse(id);

            LoadCbb();
            cbbKhuXe.Text = TenKhuXe;
            cbbLoaiXe.Text = TenLoaiXe;
            txtBienSoXe.Text = BienSoXe;
            cbbIdThe.Text = IdThe;
            DateTime ngayXeVao_datime = DateTime.Parse(NgayXeVao);
            var vNgayVao = ngayXeVao_datime.ToShortDateString();
            txtNgayVao.Text = vNgayVao;
            this.ngayVao = vNgayVao;
            this.id = int.Parse(id);
            //this.idThe = int.Parse(IdThe);
        }
        void LoadCbb()
        {
            QLLoaiXeBU loai = new QLLoaiXeBU();

            cbbLoaiXe.DataSource = loai.HienThi();
            cbbLoaiXe.DisplayMember = "tenLoaiXe";
            QLKhuXeBU khu = new QLKhuXeBU();

            cbbKhuXe.DataSource = khu.HienThi();
            cbbKhuXe.DisplayMember = "tenKhu";
          
            QLTheXeBU list1 = new QLTheXeBU();
            cbbIdThe.DataSource = list1.HienthiTheXeInFSua(idThe);
            cbbIdThe.DisplayMember = "idThe";
            //cbbIdThe.Items.Add(idThe);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            QLXeTrongNhaXeBU qLXeTrongNhaXeBU = new QLXeTrongNhaXeBU();
            TheXeDA_HDT selectedThe = cbbIdThe.SelectedItem as TheXeDA_HDT;
            int Idthe = (int)selectedThe.IdThe;
            LoaiXeDa_HDT selectedLoai = cbbLoaiXe.SelectedItem as LoaiXeDa_HDT;
            int idLoai = (int)selectedLoai.IdLoai;
            KhuXeDAHDT selectedKhu = cbbKhuXe.SelectedItem as KhuXeDAHDT;
            int idKhu = (int)selectedKhu.IdKhu;
            this.ngayVao = txtNgayVao.Text;
            qLXeTrongNhaXeBU.SuaXe(id, idKhu, txtBienSoXe.Text, Idthe,idLoai,ngayVao);
            MessageBox.Show("Đã sửa dữ liệu thành công");
            this.Close();
        }
    }
}
