using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AZURE_PORTAL.Models;
using AZURE_PORTAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AZURE_PORTAL.usercontext;
namespace AZURE_PORTAL.Models
{
[ApiController]
[Route("api/[controller]")]
public class ApplicationController : ControllerBase
{
    private readonly IApplication _applicationRepo;

 

    public ApplicationController(IApplication applicationRepo)
    {
        _applicationRepo = applicationRepo;
    }

    [HttpGet]
public IActionResult GetAll()
{
    var models = _applicationRepo.GetAll();
    return Ok(models);
}

 

[HttpGet("{id}")]
public IActionResult GetById(int id)
{
    var model = _applicationRepo.GetById(id);
    if (model == null)
    {
        return NotFound();
    }
    return Ok(model);
}

 

[HttpPost]
public IActionResult Create(Application App)
{
    _applicationRepo.Add(App);
    return CreatedAtAction(nameof(GetById), new { id = App.C_Id }, App);
}

 

[HttpPut("{id}")]
public IActionResult Update(int id, Application App)
{
    var existingModel = _applicationRepo.GetById(id);
    if (existingModel == null)
    {
        return NotFound();
    }

    existingModel.C_Name= App.C_Name;
    existingModel.Application_Name = App.Application_Name;
    existingModel.Serverinfo= App.Serverinfo;
    existingModel.Portinfo= App.Portinfo;
    _applicationRepo.Update(existingModel);

    return NoContent();
}

 

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var existingModel = _applicationRepo.GetById(id);
    if (existingModel == null)
    {
        return NotFound();
    }

    _applicationRepo.Delete(existingModel);

    return NoContent();
}


 

    
}
}