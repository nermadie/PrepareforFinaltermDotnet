using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200311_TranNhatMinh.DTO
{
    public class CBBItemHP
    {
        public string _Value { get; set; }
        public string _Text { get; set; }

        public override string ToString()
        {
            return _Text;
        }
    }
}
