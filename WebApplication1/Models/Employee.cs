using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Eno { get; set; }
        public String Ename { get; set; }
        public double Salary { get; set; }
    }
}
