using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CNP_MVVM.Utilities
{
    class UserDatabase
    {
        private List<User> _userDatabase = new List<User>();

        #region Singleton
        private static readonly UserDatabase _instance = new UserDatabase(); // oriunde in proiect va primi acelasi obiect

        private UserDatabase()
        {
            LoadDatabase();
        }

        public static UserDatabase GetInstance()
        {
            return _instance;
        }
        #endregion

        private void LoadDatabase()
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\ProjectCNP.json";

            using (StreamReader sr = new StreamReader(path))//deschide fisierul
            {// citeste fisierul si lucreaza cu el
                string y = sr.ReadToEnd();
                _userDatabase = JsonConvert.DeserializeObject<List<User>>(y);
            }//inchide fisierul
        }

        public List<User> GetUserList()
        {
            return _userDatabase;
        }
    }
}
