using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SQLconnector : IDataconnectioncs
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
            model.Id = 1;
            return model;
     
        }
    }
}
