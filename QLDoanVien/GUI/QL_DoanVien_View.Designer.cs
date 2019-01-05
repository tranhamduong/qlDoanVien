using System;
using System.Windows.Forms;

namespace QLDoanVien
{
    partial class QL_DoanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txtTrinhDoHocVan = new System.Windows.Forms.TextBox();
            this.lbTrinhDoHocVan = new System.Windows.Forms.Label();
            this.comboChiDoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLiDoDi = new System.Windows.Forms.TextBox();
            this.lbLiDoDi = new System.Windows.Forms.Label();
            this.txtNuocDaDi = new System.Windows.Forms.TextBox();
            this.lbNuocDaDi = new System.Windows.Forms.Label();
            this.txtSucKhoe = new System.Windows.Forms.TextBox();
            this.lbSucKhoe = new System.Windows.Forms.Label();
            this.txtNoiVaoDoan = new System.Windows.Forms.TextBox();
            this.lbNoiVaoDoan = new System.Windows.Forms.Label();
            this.dateNgayVaoDoan = new System.Windows.Forms.DateTimePicker();
            this.lbNgayVaoDoan = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.lbChuyenMon = new System.Windows.Forms.Label();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.lbDanToc = new System.Windows.Forms.Label();
            this.comboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNgayThangNamSinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenGoiKhac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.qL_DOANVIENDataSet = new QLDoanVien.QL_DOANVIENDataSet();
            this.dOANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOANVIENTableAdapter = new QLDoanVien.QL_DOANVIENDataSetTableAdapters.DOANVIENTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(461, 23);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(97, 34);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(461, 64);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(461, 103);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.txtTrinhDoHocVan);
            this.panelDetail.Controls.Add(this.lbTrinhDoHocVan);
            this.panelDetail.Controls.Add(this.comboChiDoan);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.txtLiDoDi);
            this.panelDetail.Controls.Add(this.lbLiDoDi);
            this.panelDetail.Controls.Add(this.txtNuocDaDi);
            this.panelDetail.Controls.Add(this.lbNuocDaDi);
            this.panelDetail.Controls.Add(this.txtSucKhoe);
            this.panelDetail.Controls.Add(this.lbSucKhoe);
            this.panelDetail.Controls.Add(this.txtNoiVaoDoan);
            this.panelDetail.Controls.Add(this.lbNoiVaoDoan);
            this.panelDetail.Controls.Add(this.dateNgayVaoDoan);
            this.panelDetail.Controls.Add(this.lbNgayVaoDoan);
            this.panelDetail.Controls.Add(this.txtChuyenMon);
            this.panelDetail.Controls.Add(this.lbChuyenMon);
            this.panelDetail.Controls.Add(this.txtNgheNghiep);
            this.panelDetail.Controls.Add(this.lbNgheNghiep);
            this.panelDetail.Controls.Add(this.txtQueQuan);
            this.panelDetail.Controls.Add(this.lbQueQuan);
            this.panelDetail.Controls.Add(this.txtDanToc);
            this.panelDetail.Controls.Add(this.lbDanToc);
            this.panelDetail.Controls.Add(this.comboGioiTinh);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.dateNgayThangNamSinh);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.txtTenGoiKhac);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.txtHoVaTen);
            this.panelDetail.Controls.Add(this.lbHoTen);
            this.panelDetail.Enabled = false;
            this.panelDetail.Location = new System.Drawing.Point(564, 14);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(385, 532);
            this.panelDetail.TabIndex = 4;
            // 
            // txtTrinhDoHocVan
            // 
            this.txtTrinhDoHocVan.Location = new System.Drawing.Point(200, 343);
            this.txtTrinhDoHocVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrinhDoHocVan.Name = "txtTrinhDoHocVan";
            this.txtTrinhDoHocVan.Size = new System.Drawing.Size(171, 22);
            this.txtTrinhDoHocVan.TabIndex = 29;
            this.txtTrinhDoHocVan.Tag = "Trình độ học vấn";
            // 
            // lbTrinhDoHocVan
            // 
            this.lbTrinhDoHocVan.AutoSize = true;
            this.lbTrinhDoHocVan.Location = new System.Drawing.Point(197, 324);
            this.lbTrinhDoHocVan.Name = "lbTrinhDoHocVan";
            this.lbTrinhDoHocVan.Size = new System.Drawing.Size(115, 17);
            this.lbTrinhDoHocVan.TabIndex = 28;
            this.lbTrinhDoHocVan.Text = "Trình độ học vấn";
            // 
            // comboChiDoan
            // 
            this.comboChiDoan.FormattingEnabled = true;
            this.comboChiDoan.Location = new System.Drawing.Point(276, 244);
            this.comboChiDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboChiDoan.Name = "comboChiDoan";
            this.comboChiDoan.Size = new System.Drawing.Size(80, 24);
            this.comboChiDoan.TabIndex = 27;
            this.comboChiDoan.Tag = "Chi đoàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Chi Đoàn";
            // 
            // txtLiDoDi
            // 
            this.txtLiDoDi.Location = new System.Drawing.Point(15, 471);
            this.txtLiDoDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLiDoDi.Multiline = true;
            this.txtLiDoDi.Name = "txtLiDoDi";
            this.txtLiDoDi.Size = new System.Drawing.Size(356, 52);
            this.txtLiDoDi.TabIndex = 25;
            this.txtLiDoDi.Tag = "Lí do đi";
            // 
            // lbLiDoDi
            // 
            this.lbLiDoDi.AutoSize = true;
            this.lbLiDoDi.Location = new System.Drawing.Point(12, 450);
            this.lbLiDoDi.Name = "lbLiDoDi";
            this.lbLiDoDi.Size = new System.Drawing.Size(54, 17);
            this.lbLiDoDi.TabIndex = 24;
            this.lbLiDoDi.Text = "Lí do đi";
            // 
            // txtNuocDaDi
            // 
            this.txtNuocDaDi.Location = new System.Drawing.Point(15, 391);
            this.txtNuocDaDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuocDaDi.Multiline = true;
            this.txtNuocDaDi.Name = "txtNuocDaDi";
            this.txtNuocDaDi.Size = new System.Drawing.Size(356, 52);
            this.txtNuocDaDi.TabIndex = 23;
            this.txtNuocDaDi.Tag = "Nước đã đi";
            // 
            // lbNuocDaDi
            // 
            this.lbNuocDaDi.AutoSize = true;
            this.lbNuocDaDi.Location = new System.Drawing.Point(12, 370);
            this.lbNuocDaDi.Name = "lbNuocDaDi";
            this.lbNuocDaDi.Size = new System.Drawing.Size(76, 17);
            this.lbNuocDaDi.TabIndex = 22;
            this.lbNuocDaDi.Text = "Nước đã đi";
            // 
            // txtSucKhoe
            // 
            this.txtSucKhoe.Location = new System.Drawing.Point(15, 343);
            this.txtSucKhoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSucKhoe.Name = "txtSucKhoe";
            this.txtSucKhoe.Size = new System.Drawing.Size(171, 22);
            this.txtSucKhoe.TabIndex = 21;
            this.txtSucKhoe.Tag = "Sức khỏe";
            // 
            // lbSucKhoe
            // 
            this.lbSucKhoe.AutoSize = true;
            this.lbSucKhoe.Location = new System.Drawing.Point(12, 322);
            this.lbSucKhoe.Name = "lbSucKhoe";
            this.lbSucKhoe.Size = new System.Drawing.Size(67, 17);
            this.lbSucKhoe.TabIndex = 20;
            this.lbSucKhoe.Text = "Sức khỏe";
            // 
            // txtNoiVaoDoan
            // 
            this.txtNoiVaoDoan.Location = new System.Drawing.Point(15, 293);
            this.txtNoiVaoDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiVaoDoan.Name = "txtNoiVaoDoan";
            this.txtNoiVaoDoan.Size = new System.Drawing.Size(171, 22);
            this.txtNoiVaoDoan.TabIndex = 19;
            this.txtNoiVaoDoan.Tag = "Nơi vào đoàn";
            // 
            // lbNoiVaoDoan
            // 
            this.lbNoiVaoDoan.AutoSize = true;
            this.lbNoiVaoDoan.Location = new System.Drawing.Point(12, 273);
            this.lbNoiVaoDoan.Name = "lbNoiVaoDoan";
            this.lbNoiVaoDoan.Size = new System.Drawing.Size(92, 17);
            this.lbNoiVaoDoan.TabIndex = 18;
            this.lbNoiVaoDoan.Text = "Nơi vào đoàn";
            // 
            // dateNgayVaoDoan
            // 
            this.dateNgayVaoDoan.Location = new System.Drawing.Point(15, 242);
            this.dateNgayVaoDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayVaoDoan.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateNgayVaoDoan.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNgayVaoDoan.Name = "dateNgayVaoDoan";
            this.dateNgayVaoDoan.Size = new System.Drawing.Size(253, 22);
            this.dateNgayVaoDoan.TabIndex = 17;
            this.dateNgayVaoDoan.Tag = "Ngày vào đoàn";
            // 
            // lbNgayVaoDoan
            // 
            this.lbNgayVaoDoan.AutoSize = true;
            this.lbNgayVaoDoan.Location = new System.Drawing.Point(12, 222);
            this.lbNgayVaoDoan.Name = "lbNgayVaoDoan";
            this.lbNgayVaoDoan.Size = new System.Drawing.Size(104, 17);
            this.lbNgayVaoDoan.TabIndex = 16;
            this.lbNgayVaoDoan.Text = "Ngày vào đoàn";
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Location = new System.Drawing.Point(200, 191);
            this.txtChuyenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(171, 22);
            this.txtChuyenMon.TabIndex = 15;
            this.txtChuyenMon.Tag = "Chuyên môn nghiệp vụ";
            // 
            // lbChuyenMon
            // 
            this.lbChuyenMon.AutoSize = true;
            this.lbChuyenMon.Location = new System.Drawing.Point(197, 171);
            this.lbChuyenMon.Name = "lbChuyenMon";
            this.lbChuyenMon.Size = new System.Drawing.Size(153, 17);
            this.lbChuyenMon.TabIndex = 14;
            this.lbChuyenMon.Text = "Chuyên môn nghiệp vụ";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(15, 191);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(171, 22);
            this.txtNgheNghiep.TabIndex = 13;
            this.txtNgheNghiep.Tag = "Nghề nghiệp";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.Location = new System.Drawing.Point(12, 171);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(89, 17);
            this.lbNgheNghiep.TabIndex = 12;
            this.lbNgheNghiep.Text = "Nghề nghiệp";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(200, 143);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(171, 22);
            this.txtQueQuan.TabIndex = 11;
            this.txtQueQuan.Tag = "Quê quán";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Location = new System.Drawing.Point(197, 123);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(71, 17);
            this.lbQueQuan.TabIndex = 10;
            this.lbQueQuan.Text = "Quê quán";
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(15, 143);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(171, 22);
            this.txtDanToc.TabIndex = 9;
            this.txtDanToc.Tag = "Dân tộc";
            // 
            // lbDanToc
            // 
            this.lbDanToc.AutoSize = true;
            this.lbDanToc.Location = new System.Drawing.Point(12, 123);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Size = new System.Drawing.Size(57, 17);
            this.lbDanToc.TabIndex = 8;
            this.lbDanToc.Text = "Dân tộc";
            // 
            // comboGioiTinh
            // 
            this.comboGioiTinh.FormattingEnabled = true;
            this.comboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboGioiTinh.Location = new System.Drawing.Point(276, 89);
            this.comboGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboGioiTinh.Name = "comboGioiTinh";
            this.comboGioiTinh.Size = new System.Drawing.Size(80, 24);
            this.comboGioiTinh.TabIndex = 7;
            this.comboGioiTinh.Tag = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính";
            // 
            // dateNgayThangNamSinh
            // 
            this.dateNgayThangNamSinh.Location = new System.Drawing.Point(15, 89);
            this.dateNgayThangNamSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayThangNamSinh.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateNgayThangNamSinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNgayThangNamSinh.Name = "dateNgayThangNamSinh";
            this.dateNgayThangNamSinh.Size = new System.Drawing.Size(253, 22);
            this.dateNgayThangNamSinh.TabIndex = 5;
            this.dateNgayThangNamSinh.Tag = "Ngày tháng năm sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày tháng năm sinh";
            // 
            // txtTenGoiKhac
            // 
            this.txtTenGoiKhac.Location = new System.Drawing.Point(200, 38);
            this.txtTenGoiKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGoiKhac.Name = "txtTenGoiKhac";
            this.txtTenGoiKhac.Size = new System.Drawing.Size(171, 22);
            this.txtTenGoiKhac.TabIndex = 3;
            this.txtTenGoiKhac.Tag = "Tên Gọi Khác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên gọi khác";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(15, 38);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(171, 22);
            this.txtHoVaTen.TabIndex = 1;
            this.txtHoVaTen.Tag = "Họ và Tên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(12, 18);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(69, 17);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // qL_DOANVIENDataSet
            // 
            this.qL_DOANVIENDataSet.DataSetName = "QL_DOANVIENDataSet";
            this.qL_DOANVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOANVIENBindingSource
            // 
            this.dOANVIENBindingSource.DataMember = "DOANVIEN";
            this.dOANVIENBindingSource.DataSource = this.qL_DOANVIENDataSet;
            // 
            // dOANVIENTableAdapter
            // 
            this.dOANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(443, 522);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.s);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // QL_DoanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 546);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThemMoi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_DoanVien";
            this.Text = "Quản lý Đoàn viên";
            this.Load += new System.EventHandler(this.QL_DoanVien_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DOANVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txtTenGoiKhac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.DateTimePicker dateNgayThangNamSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label lbDanToc;
        private System.Windows.Forms.DateTimePicker dateNgayVaoDoan;
        private System.Windows.Forms.Label lbNgayVaoDoan;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.Label lbChuyenMon;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.TextBox txtNuocDaDi;
        private System.Windows.Forms.Label lbNuocDaDi;
        private System.Windows.Forms.TextBox txtSucKhoe;
        private System.Windows.Forms.Label lbSucKhoe;
        private System.Windows.Forms.TextBox txtNoiVaoDoan;
        private System.Windows.Forms.Label lbNoiVaoDoan;
        private System.Windows.Forms.ComboBox comboChiDoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLiDoDi;
        private System.Windows.Forms.Label lbLiDoDi;
        private System.Windows.Forms.TextBox txtTrinhDoHocVan;
        private System.Windows.Forms.Label lbTrinhDoHocVan;
        private QL_DOANVIENDataSet qL_DOANVIENDataSet;
        private BindingSource dOANVIENBindingSource;
        private QL_DOANVIENDataSetTableAdapters.DOANVIENTableAdapter dOANVIENTableAdapter;
        private DataGridView dataGridView;
    }
}

