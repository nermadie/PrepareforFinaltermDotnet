using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCK.DTO
{
    public class DiaChi
    {
        public DiaChi()
        {
            NhaCungCaps = new HashSet<NhaCungCap>();
        }
        [Key]
        [Required]
        [StringLength(2)]
        public string _IDTinhTP { get; set; }
        public string _NameTinhTP { get; set; }
        public ICollection<NhaCungCap> NhaCungCaps { get; set; }
    }
}
