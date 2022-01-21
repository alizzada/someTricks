namespace test
{
    public interface ICar
    {
        public int Age { get; set; }

        public string GetNames()
        {
            return "Name";
        }

        public static void Check()
        {

        }

         string GetUser();

        public int Sum(int x,int y)
        {
            return x + y;
        }

    }
}
