using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter
{
    public interface IOwnerConverter
    {
        public Owner Convert(OwnerEntity ownerEntity);
        public OwnerEntity Convert(Owner owner);
    }
}