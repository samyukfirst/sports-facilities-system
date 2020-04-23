using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SportsFacilities
{
    class MemberBroker
    {
        SqlConnection cn;
        SqlCommand cmInsert;
        SqlCommand cmUpdate;
        SqlCommand cmDelete;
        SqlCommand cmSelbyPK;
        SqlCommand cmSelAll;

        public MemberBroker()
        {
            string con = "data source=(local);integrated security=SSPI;initial catalog=sports";
            cn = new SqlConnection(con);
            cmInsert = new SqlCommand();
            cmUpdate = new SqlCommand();
            cmDelete = new SqlCommand();
            cmSelbyPK = new SqlCommand();
            cmSelAll = new SqlCommand();
            cmInsert.Connection = cn;
            cmUpdate.Connection = cn;
            cmDelete.Connection = cn;
            cmSelbyPK.Connection = cn;
            cmSelAll.Connection = cn;
            cmInsert.CommandText = "insert into members values(@MemberId,@MemberName,@Address1,@Phone,@DateOfBirth,@Gender)";
            cmUpdate.CommandText = "update members set MemberName=@MemberName,Address1=@Address1,Phone=@Phone,DateOfBirth=@DateOfBirth,Gender=@Gender where MemberId=@MemberId";
            cmDelete.CommandText = "delete from members where MemberId=@MemberId";
            cmSelbyPK.CommandText = "select * from members where MemberId=@MemberId";
            cmSelAll.CommandText = "select * from members";

        }

        public member1 GetMember(int MemberId)
        {
            SqlParameter pMemberId = new SqlParameter("@MemberId", SqlDbType.Int);
            cmSelbyPK.Parameters.Add(pMemberId);
            pMemberId.Value = MemberId;

            member1 mem = new member1();

            cn.Open();
            SqlDataReader dr = cmSelbyPK.ExecuteReader();
            if (dr.Read())
            {
                mem.MemberId = Convert.ToInt32(dr["MemberId"]);
                mem.MemberName = (dr["MemberName"]).ToString();
                mem.Address1 = (dr["Address1"]).ToString();
                mem.Phone = (dr["Phone"]).ToString();
                mem.DateOfBirth = (dr["DateOfBirth"].ToString());
                mem.Gender = (dr["Gender"]).ToString();
            }
            else
            {
            }
            cn.Close();
            return mem;

        }

        public void update(member1 mem)
        {

            SqlParameter pMemberId = new SqlParameter("@MemberId", SqlDbType.Int);
            SqlParameter pMemberName = new SqlParameter("@MemberName", SqlDbType.VarChar, 50);
            SqlParameter pAddress1 = new SqlParameter("@Address1", SqlDbType.VarChar, 100);
            SqlParameter pPhone = new SqlParameter("@Phone", SqlDbType.VarChar, 50);
            SqlParameter pDateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.VarChar, 100);
            SqlParameter pGender = new SqlParameter("@Gender", SqlDbType.VarChar, 1);
            cmUpdate.Parameters.AddRange(new SqlParameter[] { pMemberId, pMemberName, pAddress1, pPhone, pDateOfBirth, pGender });
            pMemberId.Value = mem.MemberId;
            pMemberName.Value = mem.MemberName;
            pAddress1.Value = mem.Address1;
            pPhone.Value = mem.Phone;
            pDateOfBirth.Value = mem.DateOfBirth;
            pGender.Value = mem.Gender;

            cn.Open();
            cmUpdate.ExecuteNonQuery();
            cn.Close();
        }

        public void insert(member1 mem)
        {
            SqlParameter pMemberId = new SqlParameter("@MemberId", SqlDbType.Int);
            SqlParameter pMemberName = new SqlParameter("@MemberName", SqlDbType.VarChar, 50);
            SqlParameter pAddress1 = new SqlParameter("@Address1", SqlDbType.VarChar, 100);
            SqlParameter pPhone = new SqlParameter("@Phone", SqlDbType.VarChar, 50);
            SqlParameter pDateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.VarChar, 100);
            SqlParameter pGender = new SqlParameter("@Gender", SqlDbType.VarChar, 1);
            cmInsert.Parameters.AddRange(new SqlParameter[] { pMemberId, pMemberName, pAddress1, pPhone, pDateOfBirth, pGender });
            pMemberId.Value = mem.MemberId;
            pMemberName.Value = mem.MemberName;
            pAddress1.Value = mem.Address1;
            pPhone.Value = mem.Phone;
            pDateOfBirth.Value = mem.DateOfBirth;
            pGender.Value = mem.Gender;

            cn.Open();
            cmInsert.ExecuteNonQuery();
            cn.Close();

        }
        public void delete(int MemberId)
        {
            SqlParameter pMemberId = new SqlParameter("@MemberId", SqlDbType.Int);
            cmDelete.Parameters.Add(pMemberId);
            pMemberId.Value = MemberId;

            cn.Open();
            cmDelete.ExecuteNonQuery();
            cn.Close();
        }


        public List<member1> GetAllMember()
        {
            cn.Open();
            SqlDataReader dr = cmSelAll.ExecuteReader();
            List<member1> memlist = new List<member1>();
            while (dr.Read())
            {
                member1 mem = new member1();
                mem.MemberId = Convert.ToInt32(dr["MemberId"]);
                mem.MemberName = (dr["MemberName"]).ToString();
                mem.Address1 = (dr["Address1"]).ToString();
                mem.Phone = (dr["Phone"]).ToString();
                mem.DateOfBirth = (dr["DateOfBirth"].ToString());
                mem.Gender = (dr["Gender"]).ToString();

                memlist.Add(mem);
            }
            cn.Close();
            return memlist;
        }
    }
}
