using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models
{
    public class RegisterModel
    {
       
        public int IdentityID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birth_Date { get; set; }

        public int Phone { get; set; }

    }
}