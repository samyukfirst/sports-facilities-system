using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsFacilities
{
    class memberController
    {
        public member1 Getmember(int memberId)
        {
            MemberBroker mb = new MemberBroker();
            member1 mem = mb.GetMember(memberId);
            return mem;
        }

        public void Deletemember(int memberId)
        {
            MemberBroker mb = new MemberBroker();
            mb.delete(memberId);
        }
        public void ModifymemberInfo(member1 mem)
        {
            MemberBroker mb = new MemberBroker();
            mb.update(mem);
        }

        public void Addmember(member1 mem)
        {
            MemberBroker mb = new MemberBroker();
            mb.insert(mem);
        }
        public List<member1> GetAllmember()
        {
            MemberBroker mb = new MemberBroker();
            List<member1> memlist = mb.GetAllMember();
            return memlist;
        }
    }
}
