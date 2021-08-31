using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.Service
{
    public class PetTypeService : IPetTypeService
    {
        private readonly IPetTypeRepositoryService _iPetTypeRepositoryService;

        public PetTypeService(IPetTypeRepositoryService iPetTypeRepositoryService)
        {
            _iPetTypeRepositoryService = iPetTypeRepositoryService;
        }

        public PetType Add(PetType petType)
        {
            return _iPetTypeRepositoryService.Create(petType);
        }

        public PetType Delete(PetType petType)
        {
            return _iPetTypeRepositoryService.Remove(petType);
        }

        public PetType Modify(PetType petType)
        {
            return _iPetTypeRepositoryService.Update(petType);
        }

        public PetType Get(PetType petType)
        {
            return _iPetTypeRepositoryService.Read(petType);
        }

        public List<PetType> GetAll()
        {
            return _iPetTypeRepositoryService.ReadAll();
        }
    }
}