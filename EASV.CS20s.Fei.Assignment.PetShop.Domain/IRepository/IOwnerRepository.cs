using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IOwnerRepository
    {
        public Owner Create(Owner owner);
        public Owner Remove(Owner owner);
        public Owner Update(Owner owner);
        public Owner Read(Owner owner);
        public List<Owner> ReadAll();
    }
}