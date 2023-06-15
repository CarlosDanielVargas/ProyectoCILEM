using DAO;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RepresentativeManager
    {
        private DAO_Representative daoRepresentative = new DAO_Representative();

        public List<Representative> loadAllFromDB()
        {
            try
            {
                return daoRepresentative.loadAllFromDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Representative representative)
        {
            try
            {
                daoRepresentative.saveToDB(representative);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(Representative representative)
        {
            try
            {
                daoRepresentative.updateToDB(representative);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Representative> RepresentativeList()
        {
            return new DAO_Representative().loadAllFromDB();
        }
    }
}
