using System;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.EFSql.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DateTime? Birthdate { get; set; }
        public DateTime? SoldDate { get; set; }
        public string Color { get; set; }
        public double? Price { get; set; }
        
        public int PetTypeId { get; set; }
        public int OwnerId { get; set; }
    }
}