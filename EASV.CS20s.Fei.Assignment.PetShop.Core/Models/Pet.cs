using System;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.Models
{
    /// <summary>
    /// </summary>
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }

        public Owner Owner { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? SoldDate { get; set; }
        public string Color { get; set; }
        public double? Price { get; set; }
    }
}