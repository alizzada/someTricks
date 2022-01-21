using System;

namespace test
{
    public class Bmw : Car,ICar
    {
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string GetModel()
        {
            throw new NotImplementedException();
        }

        public string GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
