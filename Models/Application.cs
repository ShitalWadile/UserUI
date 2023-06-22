using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AZURE_PORTAL.Models
{
    public class Application
    {
        
       [Key]

        public int C_Id{get;set;}

        public string C_Name{get;set;}

        public string Application_Name{get;set;}

         public string Application_Id{get;set;}
       
       public TimeSpan Blackout_Duration {get;set;}
        public string Serverinfo{get;set;}

        public string Portinfo{get;set;}
    }

}

