using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class SuatManager : ISuatService
    {
        ISuatDal _suatDal;
        public SuatManager(ISuatDal suatDal)
        {
            _suatDal = suatDal;
        }
        public void Add(Suat entity)
        {
            _suatDal.Add(entity);
        }

        public void Delete(Suat entity)
        {
            _suatDal.Delete(entity);
        }

        //public Suat Get()
        //{
        //   return _suatDal.Get();
        //}

        public List<Suat> GetAll()
        {
            return _suatDal.GetAll();
        }

        public void Update(Suat entity)
        {
            _suatDal.Update(entity);
        }
    }
}
