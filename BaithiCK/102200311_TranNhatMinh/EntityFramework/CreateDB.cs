using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _102200311_TranNhatMinh.DTO;

namespace _102200311_TranNhatMinh.EntityFramework
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLSV> //DropCreateDatabaseAlways<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.HocPhans.AddRange(new[]
            {
                new HocPhan { _IDHP = "00001", _NameHP = "Toán rời rạc" },
                new HocPhan { _IDHP = "00002", _NameHP = "Toán UD CNTT" },
                new HocPhan { _IDHP = "00003", _NameHP = ".NET" },
                new HocPhan { _IDHP = "00004", _NameHP = "Lập trình Java" },
                new HocPhan { _IDHP = "00005", _NameHP = "Cơ sở dữ liệu" },
            });
            context.SinhViens.AddRange(new[]
            {
                new SinhVien{_IDSV = "00001", _NameSV = "Nguyen Van A", _LopSH = "20T1", _Gender = true},
                new SinhVien{_IDSV = "00002", _NameSV = "Nguyen Van B", _LopSH = "20T2", _Gender = true},
                new SinhVien{_IDSV = "00003", _NameSV = "Nguyen Van C", _LopSH = "20T3", _Gender = true},
                new SinhVien{_IDSV = "00004", _NameSV = "Nguyen Van D", _LopSH = "20T4", _Gender = true},
                new SinhVien{_IDSV = "00005", _NameSV = "Nguyen Van E", _LopSH = "20T5", _Gender = true},

            });
            context.SinhVienHocPhans.AddRange(new[]
            {
                new SinhVienHocPhan { _IDSV = "00001", _IDHP = "00001" , _DiemBT = 10, _DiemGK = 10, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00002", _IDHP = "00002" , _DiemBT = 10, _DiemGK = 9, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00003", _IDHP = "00003" , _DiemBT = 10, _DiemGK = 7, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00004", _IDHP = "00004" , _DiemBT = 10, _DiemGK = 6, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00005", _IDHP = "00005" , _DiemBT = 10, _DiemGK = 9, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00001", _IDHP = "00005" , _DiemBT = 10, _DiemGK = 5, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00002", _IDHP = "00004" , _DiemBT = 10, _DiemGK = 10, _DiemCK = 9, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00003", _IDHP = "00004" , _DiemBT = 10, _DiemGK = 7, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00004", _IDHP = "00003" , _DiemBT = 10, _DiemGK = 8, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00005", _IDHP = "00002" , _DiemBT = 10, _DiemGK = 9, _DiemCK = 10, _NgayThi = new DateTime(2022,6,23)},
                new SinhVienHocPhan { _IDSV = "00001", _IDHP = "00002" , _DiemBT = 10, _DiemGK = 10, _DiemCK = 9, _NgayThi = new DateTime(2022,6,23)},
            });
        }
    }
}
