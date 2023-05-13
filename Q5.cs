
namespace Q5 {
    class program {

        public static void Main(String[] args)
    {      
            Console.Write("Digite um valor em metros para transformar em cm: ");
            int meters = Convert.ToInt32(Console.ReadLine());
            int cm = meters * 100;
            Console.WriteLine("O valor em centimetros é : "+cm+"cm.");


    }

 }
}
    
