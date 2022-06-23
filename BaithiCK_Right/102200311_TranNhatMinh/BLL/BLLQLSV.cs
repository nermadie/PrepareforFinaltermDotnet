using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102200311_TranNhatMinh.DTO;
using _102200311_TranNhatMinh.EntityFramework;

namespace _102200311_TranNhatMinh.BLL
{
    public class BLLQLSV
    {
        private static BLLQLSV _Instance;
        public static BLLQLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLQLSV();
                }
                return _Instance;
            }
            private set { }
        }
        private QLSV db = new QLSV();
        private BLLQLSV() { }

        public List<SV_View> GetSV_ViewByidHP(string idHP)
        {
            List<SV_View> data = new List<SV_View>();
            var listSP_View = (idHP == "00000") ? from p in db.SinhViens
                                                  select new { p._IDSV, p._IDHP, p._NameSV, p._LopSH, p.HocPhan._NameHP, p._DiemBT, p._DiemGK, p._DiemCK, p._NgayThi }
                :
                from p in db.SinhViens
                where p._IDHP == idHP
                select new { p._IDSV, p._IDHP, p._NameSV, p._LopSH, p.HocPhan._NameHP, p._DiemBT, p._DiemGK, p._DiemCK, p._NgayThi };
            foreach (var v in listSP_View)
            {
                data.Add(new SV_View()
                {
                    _IDSV = v._IDSV,
                    _TenSV = v._NameSV,
                    _LopSH = v._LopSH,
                    _TenHP = v._NameHP,
                    _DiemBT = v._DiemBT,
                    _DiemGK = v._DiemGK,
                    _DiemCK = v._DiemCK,
                    _TongKet = v._DiemBT * 0.2 + v._DiemGK * 0.2 + v._DiemCK * 0.6,
                    _NgayThi = v._NgayThi
                });
            }
            return data;
        }

        public List<CBBItemHP> GetCBBHP(bool isDetailForm = false)
        {
            List<CBBItemHP> data = new List<CBBItemHP>();
            if (!isDetailForm)
                data.Add(new CBBItemHP { _Value = "00000", _Text = "All" });
            foreach (HocPhan i in db.HocPhans)
            {
                data.Add(new CBBItemHP
                {
                    _Value = i._IDHP,
                    _Text = i._NameHP
                });
            }
            return data;
        }

        public List<string> GetCBBLSH()
        {
            List<string> data = new List<string>();
            foreach (SinhVien i in db.SinhViens)
            {
                if (!(data.Contains(i._LopSH)))
                {
                    data.Add(i._LopSH);
                }
            }
            return data;
        }

        public SinhVien GetSVByMSSV(string mssv)
        {
            SinhVien sp = db.SinhViens.Where(p => p._IDSV == mssv).FirstOrDefault();
            return sp;
        }
        public void Add_UpdateSV(SinhVien s)
        {
            SinhVien temp = db.SinhViens.Find(s._IDSV);
            if (temp == null)
                db.SinhViens.Add(s);
            else
            {
                temp._IDSV = s._IDSV;
                temp._NameSV = s._NameSV;
                temp._LopSH = s._LopSH;
                temp._LopSH = s._LopSH;
                temp._Gender = s._Gender;
                temp._DiemBT = s._DiemBT;
                temp._DiemGK = s._DiemGK;
                temp._DiemCK = s._DiemCK;
                temp._NgayThi = s._NgayThi;
                temp._IDHP = s._IDHP;
            }
            db.SaveChanges();
        }

        public void DeleteSVHP(List<string> mssv)
        {
            foreach (var MSSV in mssv)
            {
                SinhVien sv = db.SinhViens.Find(MSSV);
                db.SinhViens.Remove(sv);
            }
            db.SaveChanges();
        }

        public List<SV_View> Search(string idhocphan, string text)
        {
            List<SV_View> data = new List<SV_View>();
            foreach (SV_View i in GetSV_ViewByidHP(idhocphan))
            {
                if (i._TenSV.ToLower().Contains(text.ToLower()))
                    data.Add(i);
                else if (i._IDSV.ToLower().Contains(text.ToLower()))
                    data.Add(i);
            }
            return data;
        }

        public List<SV_View> Sort(List<string> mssv, List<string> mshp, string typeSort)
        {
            List<SV_View> data = new List<SV_View>();
            for (int i = 0; i < mssv.Count; i++)
            {
                string MSSV = mssv[i];
                string MSHP = mshp[i];
                var listSPView = from p in db.SinhViens
                                 where (p._IDSV == MSSV) && (p._IDHP == MSHP)
                                 select new { p._IDSV, p._IDHP, p._NameSV, p._LopSH, p.HocPhan._NameHP, p._DiemBT, p._DiemGK, p._DiemCK, p._NgayThi };
                foreach (var v in listSPView)
                {
                    data.Add(new SV_View
                    {
                        _IDSV = v._IDSV,
                        _TenSV = v._NameSV,
                        _LopSH = v._LopSH,
                        _TenHP = v._NameHP,
                        _DiemBT = v._DiemBT,
                        _DiemGK = v._DiemGK,
                        _DiemCK = v._DiemCK,
                        _TongKet = v._DiemBT * 0.2 + v._DiemGK * 0.2 + v._DiemCK * 0.6,
                        _NgayThi = v._NgayThi
                    });
                }
            }
            switch (typeSort)
            {
                case "Tên SV":
                    data.Sort((x, y) => x._TenSV.CompareTo(y._TenSV));
                    break;
                case "Lớp SH":
                    data.Sort((x, y) => x._LopSH.CompareTo(y._LopSH));
                    break;
                case "Tên học phần":
                    data.Sort((x, y) => x._TenHP.CompareTo(y._TenHP));
                    break;
                case "Điểm BT":
                    data.Sort((x, y) => x._TenHP.CompareTo(y._TenHP));
                    break;
                case "Điểm GK":
                    data.Sort((x, y) => x._DiemGK.CompareTo(y._DiemGK));
                    break;
                case "Điểm CK":
                    data.Sort((x, y) => x._DiemCK.CompareTo(y._DiemCK));
                    break;
                case "Tổng kết":
                    data.Sort((x, y) => x._TongKet.CompareTo(y._TongKet));
                    break;
                case "Ngày thi":
                    data.Sort((x, y) => x._NgayThi.CompareTo(y._NgayThi));
                    break;
            }
            return data;
        }

    }
}
