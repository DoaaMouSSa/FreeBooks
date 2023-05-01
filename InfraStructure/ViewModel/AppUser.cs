using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.ViewModel
{
   public class AppUser:IdentityUser
    {
        public string name { get; set; }
        public string image_user { get; set; }
        public bool active_user { get; set; }
    }
}
