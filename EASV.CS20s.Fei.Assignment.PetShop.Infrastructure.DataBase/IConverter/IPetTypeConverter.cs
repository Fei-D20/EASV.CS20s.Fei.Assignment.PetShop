using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.IConverter
{
    public interface IPetTypeConverter
    {
        public PetType Convert(PetTypeEntity petTypeEntity);
        public PetTypeEntity Convert(PetType petType);

    }
}