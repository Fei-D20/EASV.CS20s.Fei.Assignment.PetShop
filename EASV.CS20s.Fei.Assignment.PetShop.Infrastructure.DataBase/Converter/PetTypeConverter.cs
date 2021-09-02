using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Converter
{
    public class PetTypeConverter :IPetTypeConverter
    {
        public PetType Convert(PetTypeEntity petTypeEntity)
        {
            return new PetType
            {
                Id = petTypeEntity.Id,
                Type = petTypeEntity.Type
            };
        }

        public PetTypeEntity Convert(PetType petType)
        {
            return new PetTypeEntity
            {
                Id = petType.Id,
                Type = petType.Type
            };
        }
    }
}