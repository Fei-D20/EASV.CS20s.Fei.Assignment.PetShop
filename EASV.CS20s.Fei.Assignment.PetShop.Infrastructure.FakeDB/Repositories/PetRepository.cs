using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.FakeDB.Repositories
{
    public class PetRepository : IPetRepository
    {
        public static List<PetEntity> PetEntities { get; set; } = new();
        private static int _id = 1;
        private readonly IPetConverter _petConverter;
        private IPetTypeRepository _petTypeRepository;

        
        public PetRepository(IPetConverter iPetConverter,IPetTypeRepository petTypeRepository)
        {
            _petConverter = iPetConverter;
            _petTypeRepository = petTypeRepository;

        }

        public Pet Create(Pet pet)
        {
            var petEntity = _petConverter.Convert(pet);
            petEntity.Id = _id++;

            var newType = new PetType()
            {
                Type = petEntity.PetTypeEntity.Type
            };
            
            var petType = _petTypeRepository.Read(newType.Id);

            if (petType == null)
            {
                _petTypeRepository.Create(newType);
            }


            PetEntities.Add(petEntity);
            return _petConverter.Convert(petEntity);
        }

        public Pet Remove(int id)
        {
            foreach (var VARIABLE in PetEntities)
            {
                if (VARIABLE.Id == id)
                {
                    PetEntities.Remove(VARIABLE);
                    return _petConverter.Convert(VARIABLE);
                }
            }

            return null;
        }

        public Pet Update(int id, Pet pet)
        {
            var petEntity = _petConverter.Convert(pet);
            foreach (var VARIABLE in PetEntities)
            {
                if (VARIABLE.Id == id)
                {
                    PetEntities.Insert(petEntity.Id - 1, petEntity);
                    return _petConverter.Convert(petEntity);
                }
            }

            return null;
        }

        public Pet Read(int id)
        {
            foreach (var VARIABLE in PetEntities)
            {
                if (VARIABLE.Id == id)
                {
                    return _petConverter.Convert(VARIABLE);
                }
            }

            return null;
        }

        public List<Pet> ReadAll(Filter filter)
        {
            List<Pet> pets = new List<Pet>();
            foreach (var VARIABLE in PetEntities)
            {
                pets.Add(_petConverter.Convert(VARIABLE));
            }

            return pets;
        }

        public int GetTotalCount()
        {
            throw new System.NotImplementedException();
        }
    }
}