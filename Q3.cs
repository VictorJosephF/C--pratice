
namespace Q3 {
    class program {

        public static void Main(String[] args)
    {      
            Console.Write("Digite um numero: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            Console.Write("Digite um numero: ");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            int soma = num + num2;

            Console.WriteLine("O numero "+num+" somado com "+num2+" resulta ao valor de: "+ soma);
    }

 }
}
    
