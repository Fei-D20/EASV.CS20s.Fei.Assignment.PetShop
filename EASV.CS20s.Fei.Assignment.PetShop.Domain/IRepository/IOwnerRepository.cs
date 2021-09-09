using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository
{
    public interface IOwnerRepository
    {
        public Owner Create(Owner owner);
        public Owner Remove(int id);
        public Owner Update(int id, Owner owner);
        public Owner Read(int id);
        public List<Owner> ReadAll();
    }
}