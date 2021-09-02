using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PetsController : ControllerBase
    {
        private readonly IPetService _iPetService;

        public PetsController(IPetService petService )
        { 
            _iPetService = petService;
        }
        
       

        [HttpPost]
        public Pet Post(Pet pet)
        {
            if (pet == null)
            {
                return null;
            }

            return _iPetService.Add(pet);
        }

        [HttpGet]
        public List<Pet> Get()
        {
            return _iPetService.GetAll();
        }

        [HttpGet("{id}")]
        public Pet Get(int id)
        {

            return _iPetService.Get(new Pet()
            {
                Id = id
            });
        }

        [HttpPut("{id}")]
        public Pet Put(int id)
        {
            return _iPetService.Modify(new Pet()
            {
                Id = id
            });
        }

        [HttpDelete("{id}")]
        public Pet Delete(int id)
        {
            return _iPetService.Delete((new Pet()
            {
                Id = id
            }));
        }
        
    }
}