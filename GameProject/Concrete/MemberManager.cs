using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class MemberManager : BaseMemberManager
    {
        private IMemberCheckService memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            this.memberCheckService = memberCheckService;
        }

        public override void Save(Member member)
        {
            if (memberCheckService.IsRealPerson(member))
            {
                base.Save(member);
            }
            else
            {
                throw new Exception("Upps... There is no real person!");
            }
            
        }
    }
}
