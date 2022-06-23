using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCK.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _IDNCC { get; set; }
        public string _NameNCC { get; set; }
        public string _IDTinhTP { get; set; }
        [ForeignKey("_IDTinhTP")]
        public DiaChi DiaChi { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
