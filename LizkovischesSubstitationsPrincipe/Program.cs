namespace LizkovischesSubstitationsPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region Bad Sample

    public class BadKirsche
    {
        private string color = "red";
        public string GetColor()
        {
            return color;
        }
    }

    public class BadErdbeere : BadKirsche
    {
        public string GetFarbe()
        {
            return GetColor();
        }
    }

    #endregion

    #region OpenClose
    public abstract class Fruits
    {
        public abstract string GetColor();
    }

    public class Cherry : Fruits
    {
        public override string GetColor()
        {
            return "red";
        }
    }

    public class Strawberry : Fruits
    {
        public override string GetColor()
        {
            return "red";
        }
    }
    #endregion
}
