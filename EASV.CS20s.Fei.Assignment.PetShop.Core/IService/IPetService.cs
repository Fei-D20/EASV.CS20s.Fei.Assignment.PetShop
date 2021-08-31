using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IPetService
    {
        public Pet Add(Pet pet);
        public Pet Delete(Pet pet);
        public Pet Modify(Pet pet);
        public Pet Get(Pet pet);
        public List<Pet> GetAll();
    }
}