using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IPetService
    {
        public Pet Add(Pet pet);
        public Pet Delete(int id);
        public Pet Modify(int id, Pet pet);
        public Pet Get(int id);
        public List<Pet> GetAll(Filter filter);
        int GetTotalCount();
    }
}