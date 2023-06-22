using AZURE_PORTAL.usercontext;
using AZURE_PORTAL.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AZURE_PORTAL.Repository
{
    public class ApplicationRepo : IApplication  
    {  
       public Context _context;
        public ApplicationRepo(Context context)
         { 
            _context = context;
         } 
          public IEnumerable<Application> GetAll() 
          { 
            return _context.Applications.ToList();
         } 
         public Application GetById(int C_Id) 
         { 
            return _context.Applications.FirstOrDefault(m => m.C_Id == C_Id); 
         }
         public void Add(Application App)
        {
            _context.Applications.Add(App);
            _context.SaveChanges();
        }

        public void Update(Application App)
        {
            var existingApp = GetById(App.C_Id);
            if (existingApp != null)
            {
                existingApp.C_Id = App.C_Id;
                existingApp.C_Name = App.C_Name;
                existingApp.Application_Id = App.Application_Id;
                existingApp.Application_Name = App.Application_Name;
                existingApp.Serverinfo = App.Serverinfo;
                existingApp.Blackout_Duration= App.Blackout_Duration;
                existingApp.Portinfo = App.Portinfo;
                _context.SaveChanges();
            }
        }

        public void Delete(Application App)
        {
            var existingModel = GetById(App.C_Id);
            if (existingModel != null)
            {
                _context.Applications.Remove(existingModel);
                _context.SaveChanges();
            }
        }
    }
}
