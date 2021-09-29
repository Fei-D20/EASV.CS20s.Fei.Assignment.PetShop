using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.PetGetDto;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.OwnerGetDto
{
    public class GetOwnerByIdDto
    {
        public string  Firstname { get; set; }
        public string  lastname { get; set; }

        public List<PetGetNameDto> Pets { get; set; }
    }
}