namespace test
{
    public abstract class Car
    {
        public int Count { get; set; }
        string name = "BMW";
        public string GetName() 
        {
            return "BMW";
        }

        public abstract string GetModel();
        
    }
}
