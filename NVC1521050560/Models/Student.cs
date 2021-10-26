using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NVC1521050560.Models
{
    [Table("Student")]
    public class Student : Person
    {
        public string StudentID { get; set; }

        [Required(ErrorMessage = "Ten Truong khong duoc de trong")]
        [MinLength(3)]
        public string University { get; set; }

        [Required(ErrorMessage = "Dia Chi khong duoc de trong")]
        [MinLength(3)]
        public string Adress { get; set; }

    }
}