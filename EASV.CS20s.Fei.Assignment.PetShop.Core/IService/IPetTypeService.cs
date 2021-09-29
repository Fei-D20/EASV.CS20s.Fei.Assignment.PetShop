using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IPetTypeService
    {
        public PetType Add(PetType petType);
        public PetType Delete(int id);
        public PetType Modify(int id, PetType petType);
        public PetType Get(int id);
        public List<PetType> GetAll();
    }
}