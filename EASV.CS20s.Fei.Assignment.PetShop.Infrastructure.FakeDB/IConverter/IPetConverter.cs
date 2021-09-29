using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter
{
    public interface IPetConverter
    {
        public Pet Convert(PetEntity petEntity);
        public PetEntity Convert(Pet pet);

    }
}