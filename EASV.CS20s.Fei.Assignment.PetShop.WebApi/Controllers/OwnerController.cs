using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _iOwnerService;

        public OwnerController(IOwnerService ownerService)
        {
            _iOwnerService = ownerService;
        }

        [HttpPost]
        public ActionResult<Owner> Post(Owner owner)
        {
            if (owner == null)
            {
                return BadRequest("Please input the information in...");
            }
            
            return Ok($"The owner {_iOwnerService.Add(owner).FirstName} is be created now...");
        }

        [HttpGet]
        public List<Owner> Get()
        {
            return _iOwnerService.GetAll();
        }

        [HttpGet("{id}")]
        public Owner Get(int id)
        {
            
            return _iOwnerService.Get(new Owner()
            {
                Id = id
            });
        }

        [HttpPut("{id}")]
        public Owner Put(int id)
        {
            return _iOwnerService.Modify(new Owner()
            {
                Id = id
            });
        }

        [HttpDelete("{id}")]
        public Owner Delete(int id)
        {
            return _iOwnerService.Delete(new Owner()
            {
                Id = id
            });
        }
        
    }
}