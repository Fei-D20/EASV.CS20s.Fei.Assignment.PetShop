using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IPetTypeRepository
    {
        public PetType Create(PetType petType);
        public PetType Remove(PetType petType);
        public PetType Update(PetType petType);
        public PetType Read(PetType petType);
        public List<PetType> ReadAll();
    }
}