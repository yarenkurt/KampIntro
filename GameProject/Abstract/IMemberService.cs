using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IMemberService
    {
        void Save(Member member);
        void Update(Member member, string newUserName);
        void Delete(Member member);
    }
}
