using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Converter
{
    public class OwnerConverter : IOwnerConverter
    {
        public Owner Convert(OwnerEntity ownerEntity)
        {
            return new Owner()
            {
                Id = ownerEntity.Id,
                Address = ownerEntity.Address,
                Email = ownerEntity.Email,
                FirstName = ownerEntity.FirstName,
                LastName = ownerEntity.LastName,
                PhoneNumber = ownerEntity.PhoneNumber
            };
        }

        public OwnerEntity Convert(Owner owner)
        {
            return new OwnerEntity()
            {
                Id = owner.Id,
                Address = owner.Address,
                Email = owner.Email,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                PhoneNumber = owner.PhoneNumber
            };
        }
    }
}