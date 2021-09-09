using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Core.IService
{
    public interface IOwnerService
    {
        public Owner Add(Owner owner);
        public Owner Delete(int id);
        public Owner Modify(int id, Owner owner);
        public Owner Get(int id);
        public List<Owner> GetAll();
    }
}