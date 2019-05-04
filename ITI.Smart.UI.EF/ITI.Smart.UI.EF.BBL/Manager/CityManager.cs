using ITI.Smart.UI.EF.Models;
using ITI.Smart.UI.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.BBL.Manager
{
   public class CityManager : Repository<City, Entities>
    {
        public CityManager(Entities context) : base(context)
        {
        }
    }
}
