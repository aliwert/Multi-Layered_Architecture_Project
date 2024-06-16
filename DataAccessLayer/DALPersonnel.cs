using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALPersonnel
    {
        public static List <EntityPersonnel> PersonnelList()
        {
            List<EntityPersonnel> deger = new List<EntityPersonnel>();
            SqlCommand cmd = new SqlCommand("Select * From TBL_INFORMATION", Connect.cn);
            if (cmd .Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonnel ent = new EntityPersonnel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Name = dr["NAME"].ToString();
                ent.Surname = dr["SURNAME"].ToString();
                ent.Duty = dr["DUTY"].ToString();
                ent.Maas = short.Parse(dr["SALARY"].ToString());
                deger.Add(ent);
                
            }
            dr.Close();
            return deger;
        }
    }
}
