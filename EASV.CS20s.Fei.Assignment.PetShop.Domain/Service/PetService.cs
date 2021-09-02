using System.Collections.Generic;
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

        public Pet Delete(Pet pet)
        {
            return _iPetRepository.Remove(pet);
        }

        public Pet Modify(Pet pet)
        {
            return _iPetRepository.Update(pet);
        }

        public Pet Get(Pet pet)
        {
            return _iPetRepository.Read(pet);
        }

        public List<Pet> GetAll()
        {
            return _iPetRepository.ReadAll();
        }
    }
}