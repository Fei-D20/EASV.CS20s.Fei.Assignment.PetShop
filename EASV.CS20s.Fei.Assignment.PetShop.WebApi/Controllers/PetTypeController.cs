using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.DeleteDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.PetTypeGetDto;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.PostDTO;
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
        public ActionResult<PetType> Post(PetTypePostDto petTypePostDto)
        { 
            try
            {
                var type = new PetType()
                {
                    Type = petTypePostDto.Type
                };
                
                return _iPetTypeService.Add(type);

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
        public ActionResult<PetTypeGetDto> Get()
        {
            try
            {
                var petTypes = _iPetTypeService.GetAll();
                var petTypeGetDtos = new List<PetTypeGetDto>();

                foreach (var VARIABLE in petTypes)
                {
                    petTypeGetDtos.Add(new PetTypeGetDto()
                    {
                        Type = VARIABLE.Type
                    });
                }
                return Ok(petTypeGetDtos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<PetTypeGetDto> Get(int id)
        {
            try
            {
                var petType = _iPetTypeService.Get(id);

                return Ok(new PetTypeGetDto()
                {
                    Type = petType.Type
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, PetTypeDeleteDto petTypeDeleteDto)
        {
            try
            {
                return Ok(_iPetTypeService.Modify(id, new PetType()
                {
                    Type = petTypeDeleteDto.Type
                }));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<PetTypeDeleteDto> Delete(int id)
        {
            try
            {
                var petType = _iPetTypeService.Delete(id);
                
                return Ok("The pet type have been delete. ");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}