using QLDoanVien.DAO;
using QLDoanVien.Database;
using QLDoanVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoanVien
{
    public partial class QL_DoanVien : Form
    {
        private string selected;
        public QL_DoanVien()
        {
            InitializeComponent();
        }

        private void QL_DoanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DOANVIENDataSet.DOANVIEN' table. You can move, or remove it, as needed.
            DoanVienDAO dao = new DoanVienDAO();
            IEnumerable<DOANVIEN> list = dao.listAll();
            this.dataGridView.DataSource = list;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Rows[0].Selected = true;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);

        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            if (this.btnThemMoi.Text == "Thêm mới")
            {
                this.panelDetail.Enabled = true;
                this.btnSua.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnThemMoi.Text = "Xác nhận";
                this.btnThemMoi.BackColor = Color.Green;
            }
            else
            {
                DoanVienDAO dao = new DoanVienDAO();

                //kiểm thử dữ liệu đầu vào
                var listInput = GetAll(this.panelDetail, this.txtHoVaTen.GetType());
                bool flag = false;
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }
                if (this.comboGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Dữ liệu Giới tính không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                }
                //kết thúc kiểm thử dữ liệu đầu vào

                if (!flag)
                {

                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien.setHoVaTen(this.txtHoVaTen.Text);
                    doanvien.setTenGoiKhac(this.txtTenGoiKhac.Text);
                    if (this.comboGioiTinh.Text == "Nam")
                        doanvien.setGioiTinh(true);
                    else
                        doanvien.setGioiTinh(false);
                    doanvien.setDanToc(this.txtDanToc.Text);
                    doanvien.setQueQuan(this.txtQueQuan.Text);
                    doanvien.setNgheNghiepBanThan(this.txtNgheNghiep.Text);
                    doanvien.setTrinhDoHocVan(this.txtTrinhDoHocVan.Text);
                    doanvien.setNoiVaoDoan(this.txtNoiVaoDoan.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNuocDaDi(this.txtNuocDaDi.Text);
                    doanvien.setLiDoDi(this.txtLiDoDi.Text);
                    doanvien.setNgaySinh(this.dateNgayThangNamSinh.Value);
                    doanvien.setNgayVaoDoan(this.dateNgayVaoDoan.Value);
                    doanvien.setChuyenMonNghiepVu(this.txtChuyenMon.Text);

                    bool res = dao.themDoanVien(doanvien);
                }


                //xác nhận
                this.panelDetail.Enabled = false;
                foreach (var item in listInput)
                {
                    item.Text = String.Empty;
                }
                this.btnThemMoi.Text = "Thêm mới";
                this.btnThemMoi.BackColor = SystemColors.Control;
                this.btnDelete.Enabled = true;
                this.btnSua.Enabled = true;
                //kết thúc xác nhận

                this.dataGridView.DataSource = dao.listAll();

                this.dataGridView.Rows[0].Selected = true;
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
            {
                var temp = this.dataGridView.SelectedRows[0];
                var temp2 = temp.Cells[0].Value.ToString();
                this.selected = temp2;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoanVienDAO dao = new DoanVienDAO();
            dao.xoaDoanVien(this.selected);

            this.dataGridView.DataSource = dao.listAll();

            this.dataGridView.Rows[0].Selected = true;
        }

        private void s(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DoanVienDAO dao = new DoanVienDAO();
            var res = dao.getByMaDoanVien(this.selected);
            if (this.btnSua.Text == "Sửa")
            {
                if (res != null) //ton tai
                {
                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien = DoanVienDTO.reConvertToDTO(res);
                    this.panelDetail.Enabled = true;
                    this.btnThemMoi.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnSua.Text = "Xác nhận";
                    this.btnSua.BackColor = Color.Green;


                    this.txtHoVaTen.Text = doanvien.getHoVaTen();
                    this.txtTenGoiKhac.Text = doanvien.getTenGoiKhac();
                    this.dateNgayThangNamSinh.Value = doanvien.getNgaySinh();
                    if (doanvien.getGioiTinh() == true)
                        this.comboGioiTinh.SelectedIndex = 0;
                    else
                        this.comboGioiTinh.SelectedIndex = 1;
                    this.txtQueQuan.Text = doanvien.getQueQuan();
                    this.txtDanToc.Text = doanvien.getDanToc();
                    this.txtNgheNghiep.Text = doanvien.getNgheNghiepBanThan();
                    this.txtTrinhDoHocVan.Text = doanvien.getTrinhDoHocVan();
                    this.txtChuyenMon.Text = doanvien.getChuyenMonNghiepVu();
                    this.txtNoiVaoDoan.Text = doanvien.getNoiVaoDoan();
                    this.dateNgayVaoDoan.Value = doanvien.getNgayVaoDoan();
                    this.txtNuocDaDi.Text = doanvien.getNuocDaDi();
                    this.txtLiDoDi.Text = doanvien.getliDoDi();
                    this.txtSucKhoe.Text = doanvien.getSucKhoe();
                }
                else
                {
                    MessageBox.Show("Không tồn tại đoàn viên");
                }
            }
            else
            {
                //Đoạn code edit giống đoạn code thêm mới
                //kiểm thử dữ liệu đầu vào
                var listInput = GetAll(this.panelDetail, this.txtHoVaTen.GetType());
                bool flag = false;
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }
                if (this.comboGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Dữ liệu Giới tính không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                }
                //kết thúc kiểm thử dữ liệu đầu vào

                if (!flag)
                {

                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien.setHoVaTen(this.txtHoVaTen.Text);
                    doanvien.setTenGoiKhac(this.txtTenGoiKhac.Text);
                    //doanvien.setNgaySinh(this.dateNgayThangNamSinh.Text)
                    if (this.comboGioiTinh.Text == "Nam")
                        doanvien.setGioiTinh(true);
                    else
                        doanvien.setGioiTinh(false);
                    doanvien.setDanToc(this.txtDanToc.Text);
                    doanvien.setQueQuan(this.txtQueQuan.Text);
                    doanvien.setNgheNghiepBanThan(this.txtNgheNghiep.Text);
                    doanvien.setTrinhDoHocVan(this.txtTrinhDoHocVan.Text);
                    doanvien.setNoiVaoDoan(this.txtNoiVaoDoan.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNuocDaDi(this.txtNuocDaDi.Text);
                    doanvien.setLiDoDi(this.txtLiDoDi.Text);
                    doanvien.setNgaySinh(this.dateNgayThangNamSinh.Value);
                    doanvien.setNgayVaoDoan(this.dateNgayVaoDoan.Value);
                    doanvien.setChuyenMonNghiepVu(this.txtChuyenMon.Text);
                    doanvien.maDoanVien = Int32.Parse(this.selected) ;

                    bool result = dao.edit(doanvien);
                    if (result == false)
                        MessageBox.Show("Chỉnh sửa thất bại!");
                }


                //xác nhận
                this.panelDetail.Enabled = false;
                foreach (var item in listInput)
                {
                    item.Text = String.Empty;
                }
                this.btnThemMoi.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSua.Text = "Sửa";
                this.btnSua.BackColor = SystemColors.Control;


                this.dataGridView.DataSource = dao.listAll();

                this.dataGridView.Rows[0].Selected = true;
            }




        }
    }

}
