using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public static List<OwnerEntity> _owners { get; set; } = new ();
        // public static List<OwnerEntity> _owners = new List<OwnerEntity>();
        private static int _id = 1;
        private readonly IOwnerConverter _iOwnerConverter;

        public OwnerRepository(IOwnerConverter ownerConverter)
        {
            _iOwnerConverter = ownerConverter;
        }


        public Owner Create(Owner owner)
        {
            var ownerEntity = _iOwnerConverter.Convert(owner);
            ownerEntity.Id = _id++;
            _owners.Add(ownerEntity);
             return _iOwnerConverter.Convert(ownerEntity);
        }

        public Owner Remove(Owner owner)
        {
            var ownerEntity = _iOwnerConverter.Convert(owner);
            foreach (var entity in _owners)
            {
                if (entity.Id == ownerEntity.Id)
                {
                    _owners.Remove(entity);
                    return _iOwnerConverter.Convert(entity);
                }
            }

            return null;
        }

        public Owner Update(Owner owner)
        {
            var ownerEntity = _iOwnerConverter.Convert(owner);
            foreach (var entity in _owners)
            {
                if (entity.Id == ownerEntity.Id)
                {
                    _owners.Insert(ownerEntity.Id -1 , ownerEntity);
                    return _iOwnerConverter.Convert(entity);
                }
            }

            return null;
        }

        public Owner Read(Owner owner)
        {
            var ownerEntity = _iOwnerConverter.Convert(owner);
            foreach (var entity in _owners)
            {
                if (entity.Id == ownerEntity.Id)
                {
                    return _iOwnerConverter.Convert(entity);
                }
            }

            return null;
        }

        public List<Owner> ReadAll()
        {
            var owners = new List<Owner>();
            foreach (var ownerEntity in _owners)
            {
                var convert = _iOwnerConverter.Convert(ownerEntity);
                owners.Add(convert);
            }

            foreach (var owner in owners)
            {
                Console.WriteLine(owner);
            }
            return owners;
        }
    }
}