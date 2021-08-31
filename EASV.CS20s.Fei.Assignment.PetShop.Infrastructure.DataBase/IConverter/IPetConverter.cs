using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.IConverter
{
    public interface IPetConverter
    {
        public Pet Convert(PetEntity petEntity);
        public PetEntity Convert(Pet pet);

    }
}