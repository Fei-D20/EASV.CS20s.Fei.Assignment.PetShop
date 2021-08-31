using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService
{
    public interface IPetRepositoryService
    {
        public Pet Create(Pet pet);
        public Pet Remove(Pet pet);
        public Pet Update(Pet pet);
        public Pet Read(int id);
        public List<Pet> ReadAll();
    }
}