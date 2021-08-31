using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IPetTypeService
    {
        public PetType Add(PetType petType);
        public PetType Delete(PetType petType);
        public PetType Modify(PetType petType);
        public PetType Get(PetType petType);
        public List<PetType> GetAll();
    }
}