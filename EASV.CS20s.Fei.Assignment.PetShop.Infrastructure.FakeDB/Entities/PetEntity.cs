using System;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetTypeEntity PetTypeEntity { get; set; }

        public OwnerEntity OwnerEntity { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? SoldDate { get; set; }
        public string Color { get; set; }
        public double? Price { get; set; }
    }
}