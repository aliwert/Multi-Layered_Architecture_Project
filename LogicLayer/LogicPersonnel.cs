using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace LogicLayer
{
    public class LogicPersonnel
    {
        public static List<EntityPersonnel> LLPersonnelList()
        {

        return DALPersonnel.PersonnelList(); 
        
        }

    }
}
