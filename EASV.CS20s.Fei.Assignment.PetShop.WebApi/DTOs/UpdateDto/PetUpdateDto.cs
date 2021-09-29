using System;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.UpdateDTO
{
    public class PetUpdateDto
    {
        public string Name { get; set; }
        public Owner Owner { get; set; }
        public DateTime? SoldDate { get; set; }
        public double? Price { get; set; }
    }
}