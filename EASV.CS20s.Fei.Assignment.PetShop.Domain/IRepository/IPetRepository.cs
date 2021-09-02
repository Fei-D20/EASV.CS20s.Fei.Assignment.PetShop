using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IPetRepository
    {
        public Pet Create(Pet pet);
        public Pet Remove(Pet pet);
        public Pet Update(Pet pet);
        public Pet Read(Pet pet);
        public List<Pet> ReadAll();
    }
}