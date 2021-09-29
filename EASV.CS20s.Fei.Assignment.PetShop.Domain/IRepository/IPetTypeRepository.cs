using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IPetTypeRepository
    {
        public PetType Create(PetType petType);
        public PetType Remove(int id);
        public PetType Update(int id, PetType petType);
        public PetType Read(int id);
        public List<PetType> ReadAll();
    }
}