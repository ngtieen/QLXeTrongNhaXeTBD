using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using Business;

namespace GiaoDien
{
    public partial class fXeRa : Form
    {
        private int id;
        private int tongTienXe;
        public fXeRa(string id, string TenKhuXe, string BienSoXe, string IdThe, string TenLoaiXe, string NgayXeVao, string giaGui)
        {
            InitializeComponent();
            txtKhuXe.Text = TenKhuXe;
            txtLoaiXe.Text = TenLoaiXe;
            txtBienSoXe.Text = BienSoXe;
            txtTheXe.Text=IdThe;
            //ngày ra
            DateTime ngayRa = DateTime.Now;
            var vNgayra = ngayRa.ToShortDateString();
            txtNgayRa.Text = vNgayra;
            DateTime ngayXeVao_datime = DateTime.Parse(NgayXeVao);
             //ngày vào
            var vNgayVao= ngayXeVao_datime.ToShortDateString();
            txtNgayVao.Text = vNgayVao;

            //// Giá
            txtgiaGui.Text = giaGui;
           int soLuong=0;//= ngayRa.Day - ngayXeVao_datime.Day;
            if (ngayRa.Year > ngayXeVao_datime.Year)
            {
                     soLuong = ngayRa.Day - ngayXeVao_datime.Day +  DateTime.DaysInMonth(ngayXeVao_datime.Year, ngayXeVao_datime.Month);
            }
            else
            {
                if (ngayRa.Month > ngayXeVao_datime.Month)
                {
                    soLuong = DateTime.DaysInMonth(ngayXeVao_datime.Year, ngayXeVao_datime.Month)- ngayXeVao_datime.Day + ngayRa.Day ;
                }
                else
                {
                    soLuong = ngayRa.Day - ngayXeVao_datime.Day;
                }
            }
            soLuong = soLuong + 1;
            txtSoNgayGui.Text = soLuong.ToString();
            int tongTien = int.Parse(giaGui) * soLuong;
            txtTongTien.Text = tongTien.ToString();
            this.id = int.Parse(id);
            this.tongTienXe = tongTien;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GiaGui()
        {
            // 
        }
        private void BtnXatNhan_Click(object sender, EventArgs e)
        {
            QLXeTrongNhaXeBU qLXeTrongNhaXeBU = new QLXeTrongNhaXeBU();
            qLXeTrongNhaXeBU.XuatXe(id,tongTienXe);
            this.Close();
        }
    }
}
