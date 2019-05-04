using ITI.Smart.UI.EF.BBL;
using ITI.Smart.UI.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.lab1_DBF_
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unit = UnitOfWork.CreateUnitOfWork();
            unit.CountryManger.Add(new Country
            {
                Name = "Greece"
            });
            var c = unit.CountryManger.GetById(1);
            unit.CityManager.Add(new City
            {
                FK_Country_Id = c.id,
                Name = "Athens",
            });
            unit.CityManager.Add(new City
            {
                Country = c,
                Name = "Patras",
            });
            unit.CityManager.Add(new City
            {
                Name = "Piraeus",
                FK_Country_Id = c.id
            });

            unit.CityManager.Update(new City
            {
                id = 1,
                Name = "Thessalonik",
                FK_Country_Id = c.id

            });
            var cities=  unit.CityManager.GetAll().ToList();

        }
    }
}
