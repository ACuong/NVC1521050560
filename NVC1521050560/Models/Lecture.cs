using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NVC1521050560.Models
{
    [Table("Lecture")]
    public class Lecture: Person
    {
        public String LectureID { get; set; }

        [Required(ErrorMessage = "Ten Truong khong duoc de trong")]
        [MinLength(3)]
        public string Faculty { get; set; }

        [Required(ErrorMessage = "Ten Truong khong duoc de trong")]
        [MinLength(3)]
        public string Department { get; set; }
    }
}