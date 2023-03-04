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
using DataBase.HDT;

namespace GiaoDien
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
            LoadDanhSach();
            LoadKhu(cbbKhuXe);
            LoadXe(cbbLoaiXe);
            loadTheXe(cbbIDThe);

        }

        void LoadDanhSach()
        {
            // List < XeTrongNhaXeDA_HDT > list = new List<XeTrongNhaXeDA_HDT>();
            fQuanLyBU list1 = new fQuanLyBU();
            dtgvThemXe.DataSource = list1.FquanLy_hienThi();
        }
        void loadTheXe(ComboBox combo)
        {
            QLTheXeBU list1 = new QLTheXeBU();
            combo.DataSource = list1.HienThifql();
            combo.DisplayMember = "idThe";

        }
        void LoadKhu(ComboBox combo)
        {
            QLKhuXeBU khu = new QLKhuXeBU();

            combo.DataSource = khu.HienThi();
            combo.DisplayMember = "tenKhu";

            //cbbKhuXe.Items.Add(1);
        }
        void LoadXe(ComboBox combo)
        {
            QLLoaiXeBU loai = new QLLoaiXeBU();

            combo.DataSource = loai.HienThi();
            combo.DisplayMember = "tenLoaiXe";
            cbbLoaiXe.Text = "Xe Ô tô";


            //cbbKhuXe.Items.Add(1);
        }
        void LoadLaiText()
        {
            txtBSX.Text = "";
            txtTiemKiem.Text = "";
            loadTheXe(cbbIDThe);
            LoadDanhSach();
        }
        //private void BtnXeRa_Click(object sender, EventArgs e)
        //{
        //    fXeRa fXeRa = new fXeRa();
        //    fXeRa.ShowDialog();
        //}
        private void fQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void Open(object sender, EventArgs e)
        {
            fAdmin ad = new fAdmin();
            ad.ShowDialog();
            loadTheXe(cbbIDThe);
        }



        private void btnThemXe_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtBSX.Text == "")
            {
                errorProvider1.SetError(txtBSX, " Biển số xe không được để trống");
            }
            else
            {
                TheXeDA_HDT selectedThe = cbbIDThe.SelectedItem as TheXeDA_HDT;
                int Idthe = (int)selectedThe.IdThe;
                LoaiXeDa_HDT selectedLoai = cbbLoaiXe.SelectedItem as LoaiXeDa_HDT;
                int idLoai = (int)selectedLoai.IdLoai;
                KhuXeDAHDT selectedKhu = cbbKhuXe.SelectedItem as KhuXeDAHDT;
                int idKhu = (int)selectedKhu.IdKhu;

                // MessageBox.Show($"Khu {idKhu}, Thẻ {Idthe}, Loai {idLoai}");
                QLXeTrongNhaXeBU qLXeTrongNhaXeBU = new QLXeTrongNhaXeBU();
                qLXeTrongNhaXeBU.ThemXe(idKhu, txtBSX.Text, idLoai, Idthe);
                LoadLaiText();
                LoadDanhSach();
            }
            loadTheXe(cbbIDThe);
        }

        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLLoaiXeBU loai = new QLLoaiXeBU();
            int id;
            if (cbbLoaiXe.SelectedItem == null) return;
            LoaiXeDa_HDT selected = cbbLoaiXe.SelectedItem as LoaiXeDa_HDT;
            id = selected.IdLoai;
            txtGiaGui.Text = (loai.HienThiGiaXe(id)).ToString();

        }

        private void btnXeRa_Click_1(object sender, EventArgs e)
        {
            string IdXe = dtgvThemXe.SelectedRows[0].Cells[0].Value.ToString();
            string TenKhuXe = dtgvThemXe.SelectedRows[0].Cells[1].Value.ToString();
            string BienSoXe = dtgvThemXe.SelectedRows[0].Cells[2].Value.ToString();
            string IdThe = dtgvThemXe.SelectedRows[0].Cells[3].Value.ToString();
            string TenLoaiXe = dtgvThemXe.SelectedRows[0].Cells[4].Value.ToString();
            string NgayXeVao = dtgvThemXe.SelectedRows[0].Cells[5].Value.ToString();
            string giaGui = txtGiaGui.Text;

            fXeRa f = new fXeRa(IdXe,TenKhuXe,BienSoXe,IdThe,TenLoaiXe,NgayXeVao,giaGui);
            f.ShowDialog();
            LoadLaiText();
        }

        
        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn xóa xe ra khỏi danh sách!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
            {
                QLXeTrongNhaXeBU qLXeTrongNhaXeBU = new QLXeTrongNhaXeBU();
                string IdXe = dtgvThemXe.SelectedRows[0].Cells[0].Value.ToString();
                qLXeTrongNhaXeBU.XoaXe(int.Parse(IdXe));
                LoadLaiText();
            }
            
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            QLXeTrongNhaXeBU qLXeTrongNhaXeBU = new QLXeTrongNhaXeBU();
            dtgvThemXe.DataSource = qLXeTrongNhaXeBU.TimKiemByID(txtTiemKiem.Text);
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            string IdXe = dtgvThemXe.SelectedRows[0].Cells[0].Value.ToString();
            string TenKhuXe = dtgvThemXe.SelectedRows[0].Cells[1].Value.ToString();
            string BienSoXe = dtgvThemXe.SelectedRows[0].Cells[2].Value.ToString();
            string IdThe = dtgvThemXe.SelectedRows[0].Cells[3].Value.ToString();
            string TenLoaiXe = dtgvThemXe.SelectedRows[0].Cells[4].Value.ToString();
            string NgayXeVao = dtgvThemXe.SelectedRows[0].Cells[5].Value.ToString();
            string giaGui = txtGiaGui.Text;
            
            fSuaThongTinXe f = new fSuaThongTinXe(IdXe, TenKhuXe, BienSoXe, IdThe, TenLoaiXe, NgayXeVao, giaGui);
            f.ShowDialog();
            LoadLaiText();
        }

        private void dtgvThemXe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //TheXeDA_HDT selectedThe = cbbIDThe.SelectedItem as TheXeDA_HDT;
            try
            {
                cbbLoaiXe.Text = dtgvThemXe.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch
            {

            }
            //if (dtgvThemXe.Rows.Count < 1) return;
        }
    }
}
