using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IPetService
    {
        public bool Add(Pet pet);
        public bool Delete(Pet pet);
        public Pet Modify(Pet pet);
        public Pet Get(Pet pet);
        public List<Pet> GetAll();
    }
}