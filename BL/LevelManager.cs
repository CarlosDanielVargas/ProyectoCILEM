using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;
using DAO;

namespace BL
{
    public class LevelManager
    {
        private DAO_Level daoLevel = new DAO_Level();

        public List<Level> loadAllFromDB()
        {
            try
            {
                return daoLevel.loadAllFromDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Level level)
        {
            try
            {
                daoLevel.saveToDB(level);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(Level level)
        {
            try
            {
                daoLevel.updateInDB(level);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(Level level)
        {
            try
            {
                daoLevel.deleteFromDB(level.LevelID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Level> searchOnDB(string keyword)
        {
            try
            {
                return daoLevel.searchFromDB(keyword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
    }
}
