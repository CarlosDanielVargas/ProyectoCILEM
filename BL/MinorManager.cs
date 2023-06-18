using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;
using DAO;

namespace BL
{
    public class MinorManager
    {
        private DAO_Minor daoMinor = new DAO_Minor();

        public List<Minor> loadAllFromDB()
        {
            try
            {
                return daoMinor.loadAllFromDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Minor minor)
        {
            try
            {
                daoMinor.saveToDB(minor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(Minor minor)
        {
            try
            {
                daoMinor.updateToDB(minor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(Minor minor)
        {
            try
            {
                daoMinor.deleteFromDB(minor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Minor searchByID(string id)
        {
            try
            {
                return daoMinor.searchByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Minor> searchByRepresentativeID(string id)
        {
            try
            {
                return daoMinor.searchMinorsByRepresentativeID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
