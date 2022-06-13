using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSuatDal : ISuatDal
    {
        public void Add(Suat entity)
        {
            using (SuatContext context = new SuatContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Suat entity)
        {
            using (SuatContext context = new SuatContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Suat Get(Expression<Func<Suat, bool>> filter)
        {
            using (SuatContext context = new SuatContext())
            {
                return context.Set<Suat>().SingleOrDefault(filter);
            }
        }

        public List<Suat> GetAll(Expression<Func<Suat, bool>> filter = null)
        {
            using (SuatContext context = new SuatContext())
            {
                return filter == null ? context.Set<Suat>().ToList() : context.Set<Suat>().Where(filter).ToList();
            }
        }

        public void Update(Suat entity)
        {
            using (SuatContext context = new SuatContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
