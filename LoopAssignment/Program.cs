namespace LoopAssignment
{
    internal class Program
    {
        class BeerSong
        {
            public void sing() 
            {

                for (int i = 99; i > 0; i--)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer, Take one down and pass it around,");
                }
            }
               
               
        }
        static void Main(string[] args)
        {
            BeerSong star = new BeerSong();
            star.sing();
        }
    }
}
