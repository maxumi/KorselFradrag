// Save this program as MainReturnValTest.cs.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Skriv hvor mange km bruger du i alt til og tilbagde fra arbejdet");
            try
            {
                int anwsr = Convert.ToInt32(Console.ReadLine());

                Befordring.BefordringClass beford = new(anwsr);

                Console.WriteLine("Skal du omkring en bro?");
                Console.WriteLine("1. Storebæltsbroen (Bil/motorcykel)");
                Console.WriteLine("2. Storebæltsbroen (Tog/offentlig transport)");
                Console.WriteLine("3. Øresundsbroen (Bil/motorcykel)");
                Console.WriteLine("4. Øresundsbroen (Tog/offentlig transport)");
                Console.WriteLine("5. Nej");

                anwsr = Convert.ToInt32(Console.ReadLine());


                double test = beford.ReturnQA(anwsr);

                Console.Write("Hvor mange dage?\nDage: ");
                anwsr = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Fradrag per dag: "+ test + "kr.");

                Console.WriteLine("Fradrag i alt: "+ test * anwsr+ "Kr.");

                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

    }
}