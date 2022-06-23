using System;
using System.Data.Entity;
using System.Linq;
using _102200311_TranNhatMinh.DTO;

namespace _102200311_TranNhatMinh.EntityFramework
{
    public class QLSV : DbContext
    {

        public QLSV()
            : base("name=QLSV")
        {
            Database.SetInitializer<QLSV>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<SinhVienHocPhan> SinhVienHocPhans { get; set; }
    }
}