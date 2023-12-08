namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            House myHouse = new House(2,true,6,"Pink");

            Console.WriteLine("How many doors? " + myHouse.GetDoors());
            Console.WriteLine("Does it have furniture? " + myHouse.GetFurniture() );
            Console.WriteLine("How many windows does it have? " + myHouse.GetWindows() );
            Console.WriteLine("What colour is it? " + myHouse.GetColour() );
        }
    }
}
