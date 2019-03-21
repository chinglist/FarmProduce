using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  
    public class User
    {
        t_user_dal user_Dal = new t_user_dal();

        public List<t_user> Select()
        {
            return user_Dal.Select();
        }
    }
}
