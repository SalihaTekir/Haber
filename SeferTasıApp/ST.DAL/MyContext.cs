using Microsoft.AspNet.Identity.EntityFramework;
using ST.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.DAL
{
   public class MyContext:IdentityDbContext<ApplicationUser>
    {
        public MyContext()
            : base("name=MyCon")
        {
           
           
        }
    }
}
