using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;
using DAO;

namespace BL
{
    public class UserManager
    {
        private DAO_User daoUser = new DAO_User();

        public List<User> LoadAllFromDB()
        {
            try
            {
                return daoUser.LoadAllFromDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveToDB(User user)
        {
            try
            {
                daoUser.SaveToDB(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateToDB(User user)
        {
            try
            {
                daoUser.UpdateToDB(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFromDB(User user)
        {
            try
            {
                daoUser.DeleteFromDB(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User SearchByID(string id)
        {
            try
            {
                return daoUser.SearchByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User AuthenticateUser(string IDCard, string password)
        {
            try
            {
                return daoUser.AuthenticateUser(IDCard, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeactivateUser(int userID)
        {
            try
            {
                daoUser.DeactivateUser(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActivateUser(int userID)
        {
            try
            {
                daoUser.ActivateUser(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LogoutUser(int userID)
        {
            try
            {
                daoUser.LogoutUser(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ResetPassword(User user)
        {
            try
            {
                daoUser.ResetPassword(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
