using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class t_user_dal : DalBase
    {
        public List<t_user> Select()
        {
            return this.Select<t_user>();
        }
    }
}
