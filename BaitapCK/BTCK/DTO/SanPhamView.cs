using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace BTCK.DTO
{
    public class SanPhamView
    {
        public string IDSP { get; set; }
        public string NameSP { get; set; }
        public float Gia { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool TinhTrang { get; set; }
        public string NameNCC { get; set; }
        public string NameTinh { get; set; }
    }
}
