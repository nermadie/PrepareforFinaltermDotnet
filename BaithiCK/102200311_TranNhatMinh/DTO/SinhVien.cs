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
        public SinhVien()
        {
            _SinhVienHocPhans = new HashSet<SinhVienHocPhan>();
        }
        [Key]
        [Required]
        public string _IDSV { get; set; }
        public string _NameSV { get; set; }
        public string _LopSH { get; set; }
        public bool _Gender { get; set; }
        public virtual ICollection<SinhVienHocPhan> _SinhVienHocPhans { get; set; }

    }
}
