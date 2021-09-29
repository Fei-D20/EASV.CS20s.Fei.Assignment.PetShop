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

        public PetType Delete(int id)
        {
            return _iPetTypeRepository.Remove(id);
        }

        public PetType Modify(int id, PetType petType)
        {
            return _iPetTypeRepository.Update(id, petType);
        }

        public PetType Get(int id)
        {
            return _iPetTypeRepository.Read(id);
        }

        public List<PetType> GetAll()
        {
            return _iPetTypeRepository.ReadAll();
        }
    }
}