using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCK.DTO
{
    public class SanPham
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string _IDSP { get; set; }
        [Required]
        public string _NameSP { get; set; }
        public float _GiaNhap { get; set; }
        public DateTime _NgayNhap { get; set; }
        public int _SoLuong { get; set; }
        public int _IDNCC { get; set; }
        [ForeignKey("_IDNCC")]
        public NhaCungCap NhaCungCap { get; set; }
    }
}
