using QLDoanVien.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDoanVien.DTO
{
    public class DoanVienDTO
    {
        public int maDoanVien;
        private string hoVaTen;
        private string tenGoiKhac;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string danToc;
        private string queQuan;
        private string ngheNghiepBanThan;
        private string trinhDoHocVan;
        private string chuyenMonNghiepVu;
        private DateTime ngayVaoDoan;
        private string noiVaoDoan;
        private string sucKhoe;
        private string nuocDaDi;
        private string liDoDi;
        private string maChiDoan;

        public DoanVienDTO()
        {

        }

        public DoanVienDTO(int maDoanVien, string hoVaTen, string tenGoiKhac, DateTime ngaySinh, bool gioiTinh, string queQuan, string ngheNghiepBanThan, string trinhDoHocVan, string chuyenMonNghiepVu, DateTime ngayVaoDoan, string noiVaoDoan, string sucKhoe, string nuocDaDi, string liDoDi, string maChiDoan)
        {
            this.maDoanVien = maDoanVien;
            this.hoVaTen = hoVaTen;
            this.tenGoiKhac = tenGoiKhac;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.queQuan = queQuan;
            this.ngheNghiepBanThan = ngheNghiepBanThan;
            this.trinhDoHocVan = trinhDoHocVan;
            this.chuyenMonNghiepVu = chuyenMonNghiepVu;
            this.ngayVaoDoan = ngayVaoDoan;
            this.noiVaoDoan = noiVaoDoan;
            this.sucKhoe = sucKhoe;
            this.nuocDaDi = nuocDaDi;
            this.liDoDi = liDoDi;
            this.maChiDoan = maChiDoan;
        }

        public void setHoVaTen(string hoVaTen) { this.hoVaTen = hoVaTen; }
        public string getHoVaTen() { return this.hoVaTen; }

        public void setTenGoiKhac(string tenGoiKhac) { this.tenGoiKhac = tenGoiKhac; }
        public string getTenGoiKhac() { return this.tenGoiKhac; }

        public void setNgaySinh(DateTime ngaySinh) { this.ngaySinh = ngaySinh; }
        public DateTime getNgaySinh() { return this.ngaySinh; }

        public void setGioiTinh(bool gioiTinh) { this.gioiTinh = gioiTinh; }
        public bool getGioiTinh() { return this.gioiTinh; }

        public void setDanToc(string danToc) { this.danToc = danToc; }
        public string getDanToc() { return this.danToc; }

        public void setQueQuan(string queQuan) { this.queQuan = queQuan; }
        public string getQueQuan() { return this.queQuan; }

        public void setNgheNghiepBanThan(string ngheNghiepBanThan) { this.ngheNghiepBanThan = ngheNghiepBanThan; }
        public string getNgheNghiepBanThan() { return this.ngheNghiepBanThan; }

        public void setTrinhDoHocVan(string trinhDoHocVan) { this.trinhDoHocVan = trinhDoHocVan; }
        public string getTrinhDoHocVan() { return this.trinhDoHocVan; }

        public void setNgayVaoDoan(DateTime ngayVaoDoan) { this.ngayVaoDoan = ngayVaoDoan; }
        public DateTime getNgayVaoDoan() { return this.ngayVaoDoan; }

        public void setNoiVaoDoan(string noiVaoDoan) { this.noiVaoDoan = noiVaoDoan; }
        public string getNoiVaoDoan() { return this.noiVaoDoan; }

        public void setSucKhoe(string sucKhoe) { this.sucKhoe = sucKhoe; }
        public string getSucKhoe() { return this.sucKhoe; }

        public void setNuocDaDi(string nuocDaDi) { this.nuocDaDi = nuocDaDi; }
        public string getNuocDaDi() { return this.nuocDaDi; }

        public void setLiDoDi(string liDoDi) { this.liDoDi = liDoDi; }
        public string getliDoDi() { return this.liDoDi; }

        public void setMaChiDoan(string maChiDoan) { this.maChiDoan = maChiDoan; }
        public string getMaChiDoan() { return this.maChiDoan; }

        public void setChuyenMonNghiepVu(string chuyenMonNghiepVu) { this.chuyenMonNghiepVu = chuyenMonNghiepVu; }
        public string getChuyenMonNghiepVu() { return this.chuyenMonNghiepVu; }

        public DOANVIEN convertToEntity()
        {
            DOANVIEN dv = new DOANVIEN();
            dv.maDoanVien = this.maDoanVien;
            dv.hoVaTen = this.hoVaTen;
            dv.tenGoiKhac = this.tenGoiKhac;
            dv.ngaySinh = this.ngaySinh;
            dv.danToc = this.danToc;
            dv.gioiTinh = this.gioiTinh;
            dv.queQuan = this.queQuan;
            dv.ngheNghiepBanThan = this.ngheNghiepBanThan;
            dv.trinhDoHocVan = this.trinhDoHocVan;
            dv.chuyenMonNghiepVu = this.chuyenMonNghiepVu;
            dv.ngayVaoDoan = this.ngayVaoDoan;
            dv.noiVaoDoan = this.noiVaoDoan;
            dv.sucKhoe = this.sucKhoe;
            dv.nuocDaDi = this.nuocDaDi;
            dv.liDoDi = this.liDoDi;
            dv.maChiDoan = this.maChiDoan;
            return dv;
        }

        public static DoanVienDTO reConvertToDTO(DOANVIEN doanvien)
        {
            DoanVienDTO dv = new DoanVienDTO();

            dv.maDoanVien = doanvien.maDoanVien;
            dv.setHoVaTen(doanvien.hoVaTen);
            dv.setTenGoiKhac(doanvien.tenGoiKhac);
            dv.setNgaySinh(doanvien.ngaySinh);
            dv.setGioiTinh(doanvien.gioiTinh);
            dv.setDanToc(doanvien.danToc);
            dv.setQueQuan(doanvien.queQuan);
            dv.setNgheNghiepBanThan(doanvien.ngheNghiepBanThan);
            dv.setTrinhDoHocVan(doanvien.trinhDoHocVan);
            dv.setChuyenMonNghiepVu(doanvien.chuyenMonNghiepVu);
            dv.setNgayVaoDoan(doanvien.ngayVaoDoan);
            dv.setNoiVaoDoan(doanvien.noiVaoDoan);
            dv.setSucKhoe(doanvien.sucKhoe);
            dv.setNuocDaDi(doanvien.nuocDaDi);
            dv.setLiDoDi(doanvien.liDoDi);
            dv.setMaChiDoan(doanvien.maChiDoan);
            
            return dv;
        }
    }
}
