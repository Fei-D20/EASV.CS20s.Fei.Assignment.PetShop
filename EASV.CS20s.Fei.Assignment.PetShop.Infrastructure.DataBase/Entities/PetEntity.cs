using System;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetTypeEntity PetTypeEntity { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? SoldDate { get; set; }
        public string Color { get; set; }
        public double? Price { get; set; }
    }
}