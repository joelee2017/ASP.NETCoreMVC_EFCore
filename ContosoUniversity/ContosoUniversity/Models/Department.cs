using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        // Timestamp 屬性會指定此資料行會包含在傳送到資料庫之 Update 和 Delete 命令的 Where 子句中。
        // 另一種寫法 DbContext 的 OnModelCreating 中加入
        // modelBuilder.Entity<Department>().Property(p => p.RowVersion).IsConcurrencyToken();
        [Timestamp]
        public byte[] RowVersion { get; set; }


        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}