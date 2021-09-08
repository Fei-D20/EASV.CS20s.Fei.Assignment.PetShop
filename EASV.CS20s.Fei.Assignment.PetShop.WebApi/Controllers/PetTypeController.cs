using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeService _iPetTypeService;

        public PetTypeController(IPetTypeService petTypeService )
        { 
            _iPetTypeService = petTypeService;
        }

        [HttpPost]
        public PetType Post(PetType petType)
        {
            if (petType == null)
            {
                return null;
            }

            return _iPetTypeService.Add(petType);
        }

        [HttpGet]
        public List<PetType> Get()
        {
            return _iPetTypeService.GetAll();
        }

        [HttpGet("{id}")]
        public PetType Get(int id)
        {

            return _iPetTypeService.Get(new PetType()
            {
                Id = id
            });
        }

        [HttpPut("{id}")]
        public PetType Put(int id)
        {
            return _iPetTypeService.Modify(new PetType()
            {
                Id = id
            });
        }

        [HttpDelete("{id}")]
        public PetType Delete(int id)
        {
            return _iPetTypeService.Delete((new PetType()
            {
                Id = id
            }));
        }

    }
}