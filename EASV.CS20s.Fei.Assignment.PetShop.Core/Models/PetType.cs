using System.Collections.Generic;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.Models
{
    public class PetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Pet> Pets { get; set; }
    }
}