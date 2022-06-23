using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200311_TranNhatMinh.DTO
{
    public class SinhVien
    {
        [Key]
        [Required]
        public string _IDSV { get; set; }
        public string _NameSV { get; set; }
        public string _LopSH { get; set; }
        public bool _Gender { get; set; }
        public double _DiemBT { get; set; }
        public double _DiemGK { get; set; }
        public double _DiemCK { get; set; }
        public DateTime _NgayThi { get; set; }
        public string _IDHP { get; set; }
        [ForeignKey("_IDHP")]
        public virtual HocPhan HocPhan { get; set; }

    }
}
