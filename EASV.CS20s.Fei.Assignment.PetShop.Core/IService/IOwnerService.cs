using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IOwnerService
    {
        public Owner Add(Owner owner);
        public Owner Delete(Owner owner);
        public Owner Modify(Owner owner);
        public Owner Get(Owner owner);
        public List<Owner> GetAll();
    }
}