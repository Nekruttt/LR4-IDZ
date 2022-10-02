using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class ГрузовойАвтомобиль : Автомобиль
    {
        protected float loadCapacity;
        public ГрузовойАвтомобиль(string pName, int pReseaseYear, bool pHighPass, int pWheelsNumber, float pLoadCapacity) : base(pName, pReseaseYear, pHighPass, pWheelsNumber)
        {
            loadCapacity = pLoadCapacity;
        }
    }
}
