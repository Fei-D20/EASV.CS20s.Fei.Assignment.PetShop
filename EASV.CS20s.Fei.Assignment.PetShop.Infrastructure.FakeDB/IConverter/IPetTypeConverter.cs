using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter
{
    public interface IPetTypeConverter
    {
        public PetType Convert(PetTypeEntity petTypeEntity);
        public PetTypeEntity Convert(PetType petType);

    }
}