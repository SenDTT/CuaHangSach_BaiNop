using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangSach
{
    public partial class frmrptBaoCaoHDBTheoNgay : Form
    {
        public frmrptBaoCaoHDBTheoNgay()
        {
            InitializeComponent();
        }

        private void frmrptBaoCaoHDBTheoNgay_Load(object sender, EventArgs e)
        {
            try
            {
                string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
                SqlConnection cn = new SqlConnection(cnStr);

                string sql = "SELECT Hoa_Don_Ban.NgayBan, Hoa_Don_Ban.MaHDB, Chi_Tiet_HDB.MaSach, Sach.TenSach, Chi_Tiet_HDB.DonGiaBan, Chi_Tiet_HDB.SoLuong FROM Hoa_Don_Ban, Chi_Tiet_HDB, Sach WHERE Hoa_Don_Ban.MaHDB = Chi_Tiet_HDB.MaHDB AND Chi_Tiet_HDB.MaSach = Sach.MaSach AND Month(Hoa_Don_Ban.NgayBan) = Month('" + dtpNgay.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("dtsDoanhThu", dt);
                rptDoanhThu.LocalReport.DataSources.Clear();
                rptDoanhThu.LocalReport.DataSources.Add(rds);
                rptDoanhThu.LocalReport.ReportPath = @"..\..\rptDoanhThu.rdlc";

                this.rptDoanhThu.RefreshReport();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNgay_Click(object sender, EventArgs e)
        {
            try
            {
                string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
                SqlConnection cn = new SqlConnection(cnStr);

                string sql = "SELECT Hoa_Don_Ban.NgayBan, Hoa_Don_Ban.MaHDB, Chi_Tiet_HDB.MaSach, Sach.TenSach, Chi_Tiet_HDB.DonGiaBan, Chi_Tiet_HDB.SoLuong FROM Hoa_Don_Ban, Chi_Tiet_HDB, Sach WHERE Hoa_Don_Ban.MaHDB = Chi_Tiet_HDB.MaHDB AND Chi_Tiet_HDB.MaSach = Sach.MaSach AND Hoa_Don_Ban.NgayBan = '" + dtpNgay.Text + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("dtsDoanhThu", dt);
                rptDoanhThu.LocalReport.DataSources.Clear();
                rptDoanhThu.LocalReport.DataSources.Add(rds);
                rptDoanhThu.LocalReport.ReportPath = @"..\..\rptDoanhThu.rdlc";

                this.rptDoanhThu.RefreshReport();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNam_Click(object sender, EventArgs e)
        {
            try
            {
                string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
                SqlConnection cn = new SqlConnection(cnStr);

                string sql = "SELECT Hoa_Don_Ban.NgayBan, Hoa_Don_Ban.MaHDB, Chi_Tiet_HDB.MaSach, Sach.TenSach, Chi_Tiet_HDB.DonGiaBan, Chi_Tiet_HDB.SoLuong FROM Hoa_Don_Ban, Chi_Tiet_HDB, Sach WHERE Hoa_Don_Ban.MaHDB = Chi_Tiet_HDB.MaHDB AND Chi_Tiet_HDB.MaSach = Sach.MaSach AND Year(Hoa_Don_Ban.NgayBan) = Year('" + dtpNgay.Text + "')";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("dtsDoanhThu", dt);
                rptDoanhThu.LocalReport.DataSources.Clear();
                rptDoanhThu.LocalReport.DataSources.Add(rds);
                rptDoanhThu.LocalReport.ReportPath = @"..\..\rptDoanhThu.rdlc";

                this.rptDoanhThu.RefreshReport();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
