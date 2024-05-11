namespace PracticaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == 'a')
                {
                    palabra[i] = char.ToUpper(palabra[i]);
                }
            }

            foreach (char item in palabra)
            {
                Console.Write(item);
            }
        }
    }
}
