using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IPetRepository
    {
        public Pet Create(Pet pet);
        public Pet Remove(int id);
        public Pet Update(int id, Pet pet);
        public Pet Read(int id);
        public List<Pet> ReadAll(Filter filter);
        int GetTotalCount();
    }
}