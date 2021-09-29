using System;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi.DTOs.GetDto.PetGetDto
{
    public class PetGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Type { get; set; }
        public string OwnerFirstName { get; set; }
        
        public DateTime? Birthdate { get; set; }
        public DateTime? SoldDate { get; set; }
        
        public string Color { get; set; }
        public double? Price { get; set; }

        public int TotalCount { get; set; }
    }
}