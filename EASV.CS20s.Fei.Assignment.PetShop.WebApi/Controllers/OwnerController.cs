using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.DeleteDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.OwnerGetDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.PetGetDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.PostDTO;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.UpdateDTO;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _iOwnerService;
        private readonly IPetService _iPetService;

        public OwnerController(IOwnerService ownerService, IPetService iPetService)
        {
            _iOwnerService = ownerService;
            _iPetService = iPetService;
        }

        [HttpPost]
        public ActionResult<Owner> Post([FromBody]OwnerPostDto dto)
        {
            try
            {
                var owner = new Owner()
                {
                    Address = dto.Address,
                    Email = dto.Email,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber
                };

                return Ok($"The owner {_iOwnerService.Add(owner).FirstName} is be created now...");

            }
            catch (ArgumentException argumentException)
            {
                return BadRequest(argumentException.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
           

        }

        [HttpGet]
        public ActionResult<OwnerGetDto> Get()
        {
            try
            {

                var owners = _iOwnerService.GetAll();
                var ownerGetDtos = new List<OwnerGetDto>();
                
                foreach (var VARIABLE in owners)
                {
                    ownerGetDtos.Add(new OwnerGetDto()
                    {
                        FirstName = VARIABLE.FirstName,
                        LastName = VARIABLE.LastName,
                    });
                }

                return Ok(ownerGetDtos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<GetOwnerByIdDto> Get(int id)
        {
            // try
            // {
            //     var owner = _iOwnerService.Get(id);
            //
            //     var pets = _iPetService.GetAll().FindAll(v => v.Owner.Id == id);
            //
            //     List<PetGetNameDto> petsName = new List<PetGetNameDto>();
            //
            //     foreach (var pet in pets)
            //     {
            //         petsName.Add(new PetGetNameDto()
            //         {
            //             id = pet.Id.ToString(),
            //             name = pet.Name
            //         });
            //     }
            //
            //
            //
            //     return Ok(new GetOwnerByIdDto()
            //     {
            //         Firstname = owner.FirstName,
            //         lastname = owner.LastName,
            //         Pets = petsName
            //     });
            // }
            // catch (Exception e)
            // {
            //     return BadRequest(e.Message);
            // }
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, OwnerUpDateDto ownerUpDateDto)
        {
            try
            {
                
                return Ok(_iOwnerService.Modify(id, new Owner()
                {
                    Id = id,
                    Address = ownerUpDateDto.Address,
                    Email = ownerUpDateDto.Email,
                    PhoneNumber = ownerUpDateDto.PhoneNumber
                }));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        

        [HttpDelete("{id}")]
        public ActionResult<OwnerDeleteDto> Delete(int id)
        {
            try
            {
                var delete = _iOwnerService.Delete(id);
                
                return Ok(new OwnerDeleteDto()
                {
                    FirstName = delete.FirstName
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}