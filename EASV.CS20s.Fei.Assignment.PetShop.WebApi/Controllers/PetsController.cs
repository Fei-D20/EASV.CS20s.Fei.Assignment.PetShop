using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PetsController : ControllerBase
    {
        IPetService IPetService;

        public PetsController(IPetService _iPetService )
        {
            _iPetService = IPetService;
        }
        [HttpGet]
        public List<Pet> ReadAll()
        {
            return IPetService.GetAll();
        }

        [HttpPost]
        public Pet Create(Pet pet)
        {
            if (pet == null)
            {
                return null;
            }

            return null;
        }
    }
}