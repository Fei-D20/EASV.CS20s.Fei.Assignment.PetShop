using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Converter
{
    public class PetConverter : IPetConverter
    {
        public Pet Convert(PetEntity petEntity)
        {
            return new Pet
            {
                Id = petEntity.Id,
                Birthdate = petEntity.Birthdate,
                Color = petEntity.Color,
                Name = petEntity.Name,
                PetType = new PetTypeConverter().Convert(petEntity.PetTypeEntity),
                Owner= new OwnerConverter().Convert(petEntity.OwnerEntity),
                Price = petEntity.Price,
                SoldDate = petEntity.SoldDate
            };
        }

        public PetEntity Convert(Pet pet)
        {
            return new PetEntity
            {
                Id = pet.Id,
                Birthdate = pet.Birthdate,
                Color = pet.Color,
                Name = pet.Name,
                PetTypeEntity = new PetTypeConverter().Convert(pet.PetType),
                OwnerEntity = new OwnerConverter().Convert(pet.Owner),
                Price = pet.Price,
                SoldDate = pet.SoldDate
            };
        }
    }
}