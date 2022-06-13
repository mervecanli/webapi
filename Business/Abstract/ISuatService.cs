using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISuatService
    {
        List<Suat> GetAll();
        //Suat Get();

        void Add(Suat entity);

        void Delete(Suat entity);

        void Update(Suat entity);
    }
}
