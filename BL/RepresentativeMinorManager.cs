using DAO;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RepresentativeMinorManager
    {
        private DAO_RepresentativeMinor daoRepresentativeMinor = new DAO_RepresentativeMinor();

        public List<RepresentativeMinor> loadAllFromDB()
        {
            try
            {
                return daoRepresentativeMinor.loadAllFromDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                daoRepresentativeMinor.saveToDB(representativeMinor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                daoRepresentativeMinor.updateToDB(representativeMinor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RepresentativeMinor> RepresentativeMinorList()
        {
            return new DAO_RepresentativeMinor().loadAllFromDB();
        }

        public void deleteFromDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                daoRepresentativeMinor.deleteFromDB(representativeMinor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RepresentativeMinor searchRepresentativeMinor(string representativeID, string minorID)
        {
            try
            {
                return daoRepresentativeMinor.searchInDB(representativeID, minorID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
