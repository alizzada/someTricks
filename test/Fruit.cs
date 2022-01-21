using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public  class Fruit
    {
        private string GetApple()
        {
            return "Apple";
        }

        public string GetOrange()
        {

            return "Orange";
        }

        internal string GetInternalApple()
        {
            return "InternalApple";
        }

        protected string GetProtectedApple()
        {
            return "ProtectedApple";
        }

        protected internal string GetPIApple()
        {
            return "PIApple";
        }
    }
}
