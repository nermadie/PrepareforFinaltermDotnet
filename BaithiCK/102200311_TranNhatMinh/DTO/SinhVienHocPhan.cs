using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200311_TranNhatMinh.DTO
{
    public class SinhVienHocPhan
    {
        [Key, Column(Order = 1)]
        [Required]
        public string _IDSV { get; set; }
        [Key, Column(Order = 2)]
        [Required]
        public string _IDHP { get; set; }
        public double _DiemBT { get; set; }
        public double _DiemGK { get; set; }
        public double _DiemCK { get; set; }
        public DateTime _NgayThi { get; set; }
        [ForeignKey("_IDHP")]
        public virtual HocPhan _HocPhan { get; set; }
        [ForeignKey("_IDSV")]
        public virtual SinhVien _SinhVien { get; set; }
    }
}
