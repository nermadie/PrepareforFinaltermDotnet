using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTCK.DTO;

namespace BTCK.Model
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLSP>
    {
        protected override void Seed(QLSP context)
        {
            context.SanPhams.AddRange(new[]
            {
                new SanPham{_IDSP = "000001", _NameSP = "Oto VinFast", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 30, _IDNCC = 1},
                new SanPham{_IDSP = "000002", _NameSP = "Oto Honda", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 10, _IDNCC = 2},
                new SanPham{_IDSP = "000003", _NameSP = "Oto Mercedes", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 20, _IDNCC = 3},
                new SanPham{_IDSP = "000004", _NameSP = "Oto Mazda", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 21, _IDNCC = 4},
                new SanPham{_IDSP = "000005", _NameSP = "Oto Mitsubishi", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 0, _IDNCC = 4},
                new SanPham{_IDSP = "000006", _NameSP = "Oto Suzuki", _GiaNhap = 30.0f, _NgayNhap = new DateTime(2022,10,22),_SoLuong = 0, _IDNCC = 3},

            });
            context.NhaCungCaps.AddRange(new[]
            {
                new NhaCungCap{_IDNCC = 1, _NameNCC = "Thang Long", _IDTinhTP = "01"},
                new NhaCungCap{_IDNCC = 2, _NameNCC = "Ha Long", _IDTinhTP = "02"},
                new NhaCungCap{_IDNCC = 3, _NameNCC = "Long Bien", _IDTinhTP = "03"},
                new NhaCungCap{_IDNCC = 4, _NameNCC = "Chien Thang", _IDTinhTP = "04"},
            });
            context.DiaChis.AddRange(new[]
            {
                new DiaChi { _IDTinhTP = "01", _NameTinhTP = "Da Nang" },
                new DiaChi { _IDTinhTP = "02", _NameTinhTP = "Ha Noi" },
                new DiaChi { _IDTinhTP = "03", _NameTinhTP = "TP Ho Chi Minh" },
                new DiaChi { _IDTinhTP = "04", _NameTinhTP = "Hai Phong" },
            });
        }

    }
}
