using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public static List<PetTypeEntity> PetTypeEntities { get; set; } = new();
        private static int _id = 1;
        private readonly IPetTypeConverter _petTypeConverter;

        public PetTypeRepository(IPetTypeConverter iPetTypeConverter)
        {
            _petTypeConverter = iPetTypeConverter;
        }

        public PetType Create(PetType petType)
        {
            var petTypeEntity = _petTypeConverter.Convert(petType);
            petTypeEntity.Id = _id++;
            PetTypeEntities.Add(petTypeEntity);
            return _petTypeConverter.Convert(petTypeEntity);
        }

        public PetType Remove(PetType petType)
        {
            var petTypeEntity = _petTypeConverter.Convert(petType);
            foreach (var VARIABLE in PetTypeEntities)
            {
                if (VARIABLE.Id == petTypeEntity.Id)
                {
                    PetTypeEntities.Remove(petTypeEntity);
                    return _petTypeConverter.Convert(petTypeEntity);
                }
            }

            return null;
        }

        public PetType Update(PetType petType)
        {
            var petTypeEntity = _petTypeConverter.Convert(petType);
            foreach (var VARIABLE in PetTypeEntities)
            {
                if (VARIABLE.Id == petTypeEntity.Id)
                {
                    PetTypeEntities.Insert(petTypeEntity.Id - 1 , petTypeEntity);
                    return _petTypeConverter.Convert(petTypeEntity);
                }
            }

            return null;
        }

        public PetType Read(PetType petType)
        {
            var petTypeEntity = _petTypeConverter.Convert(petType);
            foreach (var VARIABLE in PetTypeEntities)
            {
                if (VARIABLE.Id == petTypeEntity.Id)
                {
                    return _petTypeConverter.Convert(VARIABLE);
                }

            }
            return null;
        }

        public List<PetType> ReadAll()
        {
            List<PetType> petTypes = new List<PetType>();
            foreach (var VARIABLE in PetTypeEntities)
            {
               
                petTypes.Add( _petTypeConverter.Convert(VARIABLE));
            }

            return petTypes;
        }
    }
}