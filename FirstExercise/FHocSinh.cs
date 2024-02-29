using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FirstExercise
{
    public partial class FHocSinh : Form
    {
        DBConnection dbConnection = new DBConnection();
        HocSinhDao hsDao = new HocSinhDao();
        string sqlStr = string.Format("SELECT *FROM HocSinh");
        public FHocSinh()
        {
            InitializeComponent();
        }
        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucThongTin1.DataGridView.DataSource = dbConnection.Update(sqlStr);
            ucThongTin1.btnThem.Click += btnThem_Click;
            ucThongTin1.btnXoa.Click += btnXoa_Click;
            ucThongTin1.btnSua.Click += btnSua_Click;
            ucThongTin1.DataGridView.CellClick += gvHsinh_CellClick;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = new HocSinh(int.Parse(ucThongTin1.txtID.Text), ucThongTin1.txtHoVaTen.Text, ucThongTin1.txtDiaChi.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpBirthDay.Value, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtPhone.Text, ucThongTin1.txtMail.Text);
                if (hs.checkMailPhoneNull())
                {
                    hsDao.Them(hs);
                    ucThongTin1.DataGridView.DataSource = dbConnection.Update(sqlStr);
                }
            }
            catch
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
            clearTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                hsDao.Xoa(int.Parse(ucThongTin1.txtID.Text));
                ucThongTin1.DataGridView.DataSource = dbConnection.Update(sqlStr);
            }
            catch
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
            clearTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = new HocSinh(int.Parse(ucThongTin1.txtID.Text), ucThongTin1.txtHoVaTen.Text, ucThongTin1.txtDiaChi.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpBirthDay.Value, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtPhone.Text, ucThongTin1.txtMail.Text);
                if (hs.checkMailPhoneNull())
                {
                    hsDao.Sua(hs);
                    ucThongTin1.DataGridView.DataSource = dbConnection.Update(sqlStr);
                }
            }
            catch
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
            clearTextBox();
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.ucThongTin1.DataGridView.Rows[e.RowIndex];
                    ucThongTin1.txtID.Text = row.Cells[0].Value.ToString();
                    ucThongTin1.txtHoVaTen.Text = row.Cells[1].Value.ToString();
                    ucThongTin1.txtDiaChi.Text = row.Cells[2].Value.ToString();
                    ucThongTin1.txtCMND.Text = row.Cells[3].Value.ToString();
                    ucThongTin1.dtpBirthDay.Value = (DateTime)row.Cells[4].Value;
                    ucThongTin1.txtGioiTinh.Text = row.Cells[5].Value.ToString();
                    ucThongTin1.txtPhone.Text = row.Cells[6].Value.ToString();
                    ucThongTin1.txtMail.Text = row.Cells[7].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please select available row in DataGridView");
            }
        }

        private void clearTextBox()
        {
            ucThongTin1.txtID.Clear();
            ucThongTin1.txtHoVaTen.Clear();
            ucThongTin1.txtCMND.Clear();
            ucThongTin1.txtDiaChi.Clear();
            ucThongTin1.txtGioiTinh.Clear();
            ucThongTin1.txtMail.Clear();
            ucThongTin1.txtPhone.Clear();
            ucThongTin1.dtpBirthDay.ResetText();
        }


        private void btnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiangVien form2 = new FGiangVien();
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }
    }
}
