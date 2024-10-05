namespace OrderFish
{
    class Fish
    {
        public string Species{get; set;}
        public double PricePerFish{get; set;}
    }

    class FishUtility:Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;
        }

        public bool BuyFish()
        {
            if(Species=="Clownfish" || Species=="Goldfish")
            {
                return true;
            }
            else
            {
                
                Console.WriteLine($"{Species} species not found");
                return false;
            }

        }

        public double CalculatePrice(int numberOfFishes)
        {
            return PricePerFish*numberOfFishes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the species to buy");
            string speciesToBuy = Console.ReadLine();
            Console.WriteLine("Enter the price per fish");
            double pricePerFish = double.Parse(Console.ReadLine());


            FishUtility fu = new FishUtility();
            fu.AddFish(speciesToBuy, pricePerFish);

            if(fu.BuyFish())
            {
                Console.WriteLine("Enter the number of fishes you need to buy");
                int numberOfFishes = int.Parse(Console.ReadLine());

                double price = fu.CalculatePrice(numberOfFishes);
                Console.WriteLine(price);
            }
            
        }
    }
}