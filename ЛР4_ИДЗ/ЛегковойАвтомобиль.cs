using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ_ТС
{
    internal class ЛегковойАвтомобиль : Автомобиль
    {
        protected int seatsNumber;
        public ЛегковойАвтомобиль(string pName, int pReseaseYear, bool pHighPass, int pWheelsNumber, int pSeatsNumber) : base(pName, pReseaseYear, pHighPass, pWheelsNumber)
        {
            seatsNumber=pSeatsNumber;
        }
    }
}
