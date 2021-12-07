using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IMemberCheckService
    {
        bool IsRealPerson(Member member);
    }
}
