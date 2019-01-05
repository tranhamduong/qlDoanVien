using QLDoanVien.Database;
using QLDoanVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDoanVien.DAO
{
    public class DoanVienDAO 
    {
        DoanVienDatabase db = null;
        public DoanVienDAO()
        {
            db = new DoanVienDatabase();
        }

        ~DoanVienDAO()
        {
            db.Dispose();
        }

        public bool themDoanVien(DoanVienDTO dto)
        {
            try
            {
                DOANVIEN entity = dto.convertToEntity();
                var res = db.DOANVIENs.Add(entity);
                db.SaveChanges();
                return true;
            }catch (Exception e) { }
            return false;
        }

        public IEnumerable<DOANVIEN> listAll()
        {
            return db.DOANVIENs.OrderBy(x => x.maDoanVien).ToArray();
        }

        public void xoaDoanVien(string selected)
        {
            try
            {
                int t = Int32.Parse(selected);
                var res = db.DOANVIENs.Where(x => x.maDoanVien == t).FirstOrDefault();
                if (res != null)
                    db.DOANVIENs.Remove(res);
                db.SaveChanges();
            } catch (Exception e) { }
        }

        public DOANVIEN getByMaDoanVien(string selected)
        {
            int t = Int32.Parse(selected);
            return db.DOANVIENs.Where(x => x.maDoanVien == t).FirstOrDefault();
        }

        public bool edit(DoanVienDTO doanvien)
        {
            int maDoanVien = doanvien.maDoanVien;
            var res = db.DOANVIENs.Where(x => x.maDoanVien == maDoanVien).FirstOrDefault();
            if (res == null) // không tồn tại
                return false;
            else
            {
                res.gioiTinh = doanvien.getGioiTinh();
                res.hoVaTen = doanvien.getHoVaTen();
                res.queQuan = doanvien.getQueQuan();
                res.ngaySinh = doanvien.getNgaySinh();
                res.gioiTinh = doanvien.getGioiTinh();
                res.tenGoiKhac = doanvien.getTenGoiKhac();
                res.danToc = doanvien.getDanToc();
                res.trinhDoHocVan = doanvien.getTrinhDoHocVan();
                res.chuyenMonNghiepVu = doanvien.getChuyenMonNghiepVu();
                res.ngheNghiepBanThan = doanvien.getNgheNghiepBanThan();
                res.nuocDaDi = doanvien.getNuocDaDi();
                res.liDoDi = doanvien.getliDoDi();
                res.sucKhoe = doanvien.getSucKhoe();
                res.ngayVaoDoan = doanvien.getNgayVaoDoan();
                res.noiVaoDoan = doanvien.getNoiVaoDoan();

                db.SaveChanges();
                return true;
            }
        }
    }
}
