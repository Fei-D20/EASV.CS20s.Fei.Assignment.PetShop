using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.Service
{
    /// <summary>
    ///     This class is use for offer the function to CRUD the Pet Object.
    /// </summary>
    public class PetService : IPetService
    {
        private readonly IPetRepository _iPetRepository; // declare the variable 

        public PetService(IPetRepository iPetRepository) // trans from outside to inside
        {
            _iPetRepository = iPetRepository; // initialize the variable when the class be instantiate 
        }


        public Pet Add(Pet pet)
        {
            return _iPetRepository.Create(pet);
        }

        public Pet Delete(int id)
        {
            return _iPetRepository.Remove(id);
        }

        public Pet Modify(int id, Pet pet)
        {
            return _iPetRepository.Update(id,pet);
        }

        public Pet Get(int id)
        {
            return _iPetRepository.Read(id);
        }

        public List<Pet> GetAll(Filter filter)
        {
            return _iPetRepository.ReadAll(filter);
        }

        public int GetTotalCount()
        {
            return _iPetRepository.GetTotalCount();
        }
    }
}