using ITI.Smart.UI.EF.BBL.Manager;
using ITI.Smart.UI.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.BBL
{
  public  class UnitOfWork
    {
      
        private static Entities context=new Entities();
        private static UnitOfWork unitOfWork;
        private UnitOfWork()
        {

        }

        //using to create obj from UnitOfWork
        public static UnitOfWork CreateUnitOfWork()
        {
            if (unitOfWork == null)
            {
                unitOfWork = new UnitOfWork();
            }
            return unitOfWork;
        }

        public CityManager CityManager {
            get {
                return new CityManager(context);
                 }
        }
        public CountryManger CountryManger
        {
            get {
                return new CountryManger(context);
            }
        }

      


    }
}
