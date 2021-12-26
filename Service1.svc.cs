using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarWCF
{
    
    public class Service1 : IService1
    {
        RentACarEntities baglan = new RentACarEntities();
        public List<ARAC> araclar()
        {
            var model = baglan.ARAC.ToList();

            return model;

        }
    }
}
