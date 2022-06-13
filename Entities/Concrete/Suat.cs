using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Suat:IEntity
    {
        public string Isim { get; set; }
        public string Soyad { get; set; }
    }
}
