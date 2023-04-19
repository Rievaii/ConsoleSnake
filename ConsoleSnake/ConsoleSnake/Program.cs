namespace ConsoleSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Field = new List<string>();

            for (int i = 0; i < 25; i++)
            {
                if(i % 5 == 0)
                {
                    Field.Add("\n");
                }
                Field.Add(new FieldCell().value);
            }
            foreach (var item in Field)
            {
                
                Console.Write(item);
            }
        }
    }
}