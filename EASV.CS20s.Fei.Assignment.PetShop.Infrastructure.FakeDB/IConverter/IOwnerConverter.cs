using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter
{
    public interface IOwnerConverter
    {
        public Owner Convert(OwnerEntity ownerEntity);
        public OwnerEntity Convert(Owner owner);
    }
}