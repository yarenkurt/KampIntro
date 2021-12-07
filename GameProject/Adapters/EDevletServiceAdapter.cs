using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Adapters
{
    public class EDevletServiceAdapter : IMemberCheckService
    {
        public bool IsRealPerson(Member member)
        {
            return true;
        }
    }
}
