using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NVC1521050560.Models
{
    [Table("Person")]
    public class Person
    {
        NVC1521050560DbContext db = new NVC1521050560DbContext();
        public string PersonID { get; set; }

        [Required(ErrorMessage = "Ten Person khong duoc de trong")]
        [MinLength(3)]
        public string PersonName { get; set; }

    }
}