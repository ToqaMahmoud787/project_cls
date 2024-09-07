using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public string Position { get; set; }

        public int DeptId { get; set; }  // Foreign Key


        [ForeignKey("DeptId")]
        public Department Department { get; set; }

    }
}
