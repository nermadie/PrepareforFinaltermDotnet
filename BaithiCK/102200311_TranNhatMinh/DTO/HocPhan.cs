using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200311_TranNhatMinh.DTO
{
    public class HocPhan
    {
        public HocPhan()
        {
            SinhVienHocPhans = new HashSet<SinhVienHocPhan>();
        }
        [Key]
        [Required]
        public string _IDHP { get; set; }
        public string _NameHP { get; set; }
        public virtual ICollection<SinhVienHocPhan> SinhVienHocPhans { get; set; }
    }
}
