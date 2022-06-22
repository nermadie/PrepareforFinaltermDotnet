using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCK.DTO;
using BTCK.Model;

namespace BTCK.BLL
{
    public class BLLQLSP
    {
        private static BLLQLSP _Instance;
        public static BLLQLSP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLQLSP();
                }
                return _Instance;
            }
            private set { }
        }
        private QLSP db = new QLSP();
        private BLLQLSP() { }
        public List<CBBItemTinhTP> GetCBBTinhTP(bool isMainForm = true)
        {
            List<CBBItemTinhTP> data = new List<CBBItemTinhTP>();
            if (isMainForm)
                data.Add(new CBBItemTinhTP { Value = "00", Text = "All" });
            foreach (DiaChi i in db.DiaChis)
            {
                data.Add(new CBBItemTinhTP
                {
                    Value = i._IDTinhTP,
                    Text = i._NameTinhTP
                });
            }
            return data;
        }
        public List<CBBItemNCC> GetCBBNCCByIDTinhTP(string nameTinhTP, bool isMainForm = true)
        {
            List<CBBItemNCC> data = new List<CBBItemNCC>();
            if (nameTinhTP != "All")
                foreach (NhaCungCap i in db.NhaCungCaps)
                {
                    if (i.DiaChi._NameTinhTP == nameTinhTP)
                        data.Add(new CBBItemNCC
                        {
                            Value = i._IDNCC,
                            Text = i._NameNCC
                        });
                }
            else
            {
                if (isMainForm)
                    data.Add(new CBBItemNCC { Value = 0, Text = "All" });
                foreach (NhaCungCap i in db.NhaCungCaps)
                {
                    data.Add(new CBBItemNCC
                    {
                        Value = i._IDNCC,
                        Text = i._NameNCC
                    });
                }
            }
            return data;
        }
        public List<SanPhamView> GetSPViewByIDNCC(int idNCC)
        {
            List<SanPhamView> data = new List<SanPhamView>();
            var listSP_View = (idNCC == 0) ? from p in db.SanPhams
                                             select new { p._IDSP, p._NameSP, p._GiaNhap, p._NgayNhap, p._SoLuong, p.NhaCungCap._NameNCC, p.NhaCungCap.DiaChi._NameTinhTP }
                :
                from p in db.SanPhams
                where p._IDNCC == idNCC
                select new { p._IDSP, p._NameSP, p._GiaNhap, p._NgayNhap, p._SoLuong, p.NhaCungCap._NameNCC, p.NhaCungCap.DiaChi._NameTinhTP };
            foreach (var v in listSP_View)
            {
                data.Add(new SanPhamView()
                {
                    IDSP = v._IDSP,
                    NameSP = v._NameSP,
                    Gia = v._GiaNhap,
                    NgayNhap = v._NgayNhap,
                    TinhTrang = Convert.ToBoolean(v._SoLuong > 0),
                    NameNCC = v._NameNCC,
                    NameTinh = v._NameTinhTP
                });
            }
            return data;
        }
        //SEARCH
        public List<SanPhamView> Search(int idNCC, string text)
        {
            List<SanPhamView> data = new List<SanPhamView>();
            foreach (SanPhamView i in GetSPViewByIDNCC(idNCC))
            {
                if (i.NameSP.ToLower().Contains(text.ToLower()))
                    data.Add(i);
                else if (i.Gia.ToString().ToLower().Contains(text.ToLower()))
                    data.Add(i);
                else if (i.NameNCC.ToLower().Contains(text.ToLower()))
                    data.Add(i);
                else if (i.NameTinh.ToLower().Contains(text.ToLower()))
                    data.Add(i);
            }
            return data;
        }

        public SanPham GetSPByMSSP(string mssp)
        {
            SanPham sp = db.SanPhams.Where(p => p._IDSP == mssp).FirstOrDefault();
            return sp;
        }

        public void Add_UpdateSP(SanPham s)
        {
            SanPham temp = db.SanPhams.Find(s._IDSP);
            if (temp == null)
                db.SanPhams.Add(s);
            else
            {
                temp._IDSP = s._IDSP;
                temp._NameSP = s._NameSP;
                temp._GiaNhap = s._GiaNhap;
                temp._SoLuong = s._SoLuong;
                temp._NgayNhap = s._NgayNhap;
                temp._IDNCC = s._IDNCC;
            }
            db.SaveChanges();
        }

        public void DeleteSP(List<string> id)
        {
            foreach (string mssp in id)
            {
                SanPham s = db.SanPhams.Find(mssp);
                db.SanPhams.Remove(s);
            }
            db.SaveChanges();
        }

        public List<SanPhamView> Sort(List<string> id, string typeSort)
        {
            List<SanPhamView> data = new List<SanPhamView>();
            foreach (string mssp in id)
            {
                int MSSV = Convert.ToInt32(mssp);
                var listSPView = from p in db.SanPhams
                                 where p._IDSP == mssp
                                 select new { p._IDSP, p._NameSP, p._GiaNhap, p._NgayNhap, p._SoLuong, p.NhaCungCap._NameNCC, p.NhaCungCap.DiaChi._NameTinhTP };
                foreach (var v in listSPView)
                {
                    data.Add(new SanPhamView
                    {
                        IDSP = v._IDSP,
                        NameSP = v._NameSP,
                        Gia = v._GiaNhap,
                        NgayNhap = v._NgayNhap,
                        TinhTrang = Convert.ToBoolean(v._SoLuong > 0),
                        NameNCC = v._NameNCC,
                        NameTinh = v._NameTinhTP
                    });
                }
            }
            switch (typeSort)
            {
                case "Mã sản phẩm":
                    data.Sort((x, y) => x.IDSP.CompareTo(y.IDSP));
                    break;
                case "Tên sản phẩm":
                    data.Sort((x, y) => x.NameSP.CompareTo(y.NameSP));
                    break;
                case "Giá nhập":
                    data.Sort((x, y) => x.Gia.CompareTo(y.Gia));
                    break;
                case "Ngày nhập hàng":
                    data.Sort((x, y) => x.NgayNhap.CompareTo(y.NgayNhap));
                    break;
                case "Tình trạng":
                    data.Sort((x, y) => x.TinhTrang.CompareTo(y.TinhTrang));
                    break;
                case "Nhà cung cấp":
                    data.Sort((x, y) => x.NameNCC.CompareTo(y.NameNCC));
                    break;
                case "Tỉnh/TP":
                    data.Sort((x, y) => x.NameTinh.CompareTo(y.NameTinh));
                    break;
            }
            return data;
        }
    }
}
