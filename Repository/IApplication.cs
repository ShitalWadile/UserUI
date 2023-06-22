using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AZURE_PORTAL.Models;

namespace AZURE_PORTAL.Repository
{
public interface IApplication
{
    IEnumerable<Application> GetAll();
    Application GetById (int C_Id);
    void Add(Application App);
    void Update(Application App);
    void Delete(Application App);
    
}
}