
namespace Q4 {
    class program {

        public static void Main(String[] args)
    {      
            Console.Write("Digite uma nota: ");
            string input = Console.ReadLine();
            int nota = int.Parse(input);
            Console.Write("Digite uma nota: ");
            string input2 = Console.ReadLine();
            int nota2 = int.Parse(input2);
            Console.Write("Digite uma nota: ");
            string input3 = Console.ReadLine();
            int nota3 = int.Parse(input3);
            Console.Write("Digite uma nota: ");
            string input4 = Console.ReadLine();
            int nota4 = int.Parse(input4);

            int media = (nota+nota2+nota3+nota4)/4;

            Console.WriteLine("A media das notas foi: "+ media);
    }

 }
}
    
