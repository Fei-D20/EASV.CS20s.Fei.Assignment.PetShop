using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.PetGetDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.PostDTO;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.UpdateDTO;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PetsController : ControllerBase
    {
        private readonly IPetService _iPetService;
        private readonly IOwnerService _iOwnerService;
        private readonly IPetTypeService _iPetTypeService;

        public PetsController(IPetService petService, IOwnerService ownerService,IPetTypeService petTypeService  )
        { 
            _iPetService = petService;
            _iOwnerService = ownerService;
            _iPetTypeService = petTypeService;
        }

       

        [HttpPost]
        public ActionResult<PetPostDto> Post(PetPostDto petPostDto)
        {
            try
            {
                var owner = _iOwnerService.Get(petPostDto.OwnerId);
                var petType = _iPetTypeService.Get(petPostDto.PetTypeId);
                

                var pet = new Pet()
                {
                    Birthdate = petPostDto.Birthdate,
                    Color = petPostDto.Color,
                    Name = petPostDto.Name,
                    Price = petPostDto.Price,
                    SoldDate = petPostDto.SoldDate,
                    Owner = owner,
                    PetType = petType
                };

                var addPet = _iPetService.Add(pet);
                return Ok(new PetPostDto()
                {
                    Birthdate = addPet.Birthdate,
                    Color = addPet.Color,
                    Name = addPet.Name,
                    Price = addPet.Price,
                    SoldDate = addPet.SoldDate,
                    PetTypeId = addPet.PetType.Id,
                    OwnerId = addPet.Owner.Id
                });

            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public ActionResult<PetGetDto> Get([FromQuery] Filter filter)
        {
           
            try
            {
                var pets = _iPetService.GetAll(filter);
                var petGetDtos = new List<PetGetDto>();
                
                if (filter.Count <= 0 || filter.Count > 500)
                {
                    return BadRequest("bad");
                }

                var totalCount = _iPetService.GetTotalCount();
                if (filter.Page < 1 || filter.Count * (filter.Page - 1) > totalCount)
                {
                    return BadRequest($"please input the page number smaller or equal than {(totalCount / filter.Count) + 1}");
                }

                foreach (var pet in pets)
                {
                    petGetDtos.Add(new PetGetDto()
                    {
                        // Birthdate = pet.Birthdate,
                        // Color = pet.Color,
                        Id = pet.Id,
                        Name = pet.Name,
                        // Price = pet.Price,
                        // SoldDate = pet.SoldDate,
                        
                        // OwnerFirstName = _iOwnerService.Get(pet.Owner.Id).FirstName,
                        
                        // Type = _iPetTypeService.Get(pet.PetType.Id).Type
                        TotalCount = totalCount
                    });
                }
                return Ok(petGetDtos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<PetGetDto> Get(int id)
        {

            try
            {
                var pet = _iPetService.Get(id);
                
                return Ok(new PetGetDto()
                {
                    Name = pet.Name,
                    Birthdate = pet.Birthdate,
                    Color = pet.Color,
                    Type = _iPetTypeService.Get(pet.PetType.Id).Type,
                    OwnerFirstName = _iOwnerService.Get(pet.Owner.Id).FirstName,
                    Price = pet.Price,
                    SoldDate = pet.SoldDate
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(int id,PetUpdateDto petUpdateDto)
        {
            try
            {
                var modify = _iPetService.Modify(id, new Pet()
                {
                    Name = petUpdateDto.Name,
                    Owner = petUpdateDto.Owner,
                    Price = petUpdateDto.Price,
                    SoldDate = petUpdateDto.SoldDate

                });
                return Ok("good");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _iPetService.Delete(id);
                return Ok("The pet has been removed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}