using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.Service
{
    public class PetTypeService : IPetTypeService
    {
        private readonly IPetTypeRepository _iPetTypeRepository;

        public PetTypeService(IPetTypeRepository iPetTypeRepository)
        {
            _iPetTypeRepository = iPetTypeRepository;
        }

        public PetType Add(PetType petType)
        {
            return _iPetTypeRepository.Create(petType);
        }

        public PetType Delete(PetType petType)
        {
            return _iPetTypeRepository.Remove(petType);
        }

        public PetType Modify(PetType petType)
        {
            return _iPetTypeRepository.Update(petType);
        }

        public PetType Get(PetType petType)
        {
            return _iPetTypeRepository.Read(petType);
        }

        public List<PetType> GetAll()
        {
            return _iPetTypeRepository.ReadAll();
        }
    }
}