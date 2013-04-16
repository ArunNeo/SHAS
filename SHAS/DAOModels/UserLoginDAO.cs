using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SHAS.DAOModels
{
    public class UserLoginDAO
    {
       [ScaffoldColumn(false)]
        public string userName { get; set; }

        [Required  ,StringLength(20),Display(Name ="Password")]
        public string Password { get; set; }


    }
}