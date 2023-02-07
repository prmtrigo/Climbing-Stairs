namespace Climbing_Stairs;
class Program
{
    public int SubindoEscadas(int numerodeDegraus){

        //criando exceções
        if(numerodeDegraus > 45){
            Console.WriteLine("Não foi possível realizar a operação");
            return numerodeDegraus;
        }

        if(numerodeDegraus == 1 || numerodeDegraus == 2){

            Console.WriteLine(numerodeDegraus);
            return numerodeDegraus;
        }

        int[] passos = new int[numerodeDegraus];

        passos[0] = 1;
        passos[1] = 2;

        for (int i = 2; i < numerodeDegraus; i++){
            passos[i] = passos[i -1] + passos[i-2];
        }

        Console.WriteLine(passos[numerodeDegraus-1]);
        return passos[numerodeDegraus-1];
    }   

    static void Main(string[] args)
    {

        Program programa = new Program();

        //descrevendo o número de degraus
        Console.WriteLine("Qual o número de Degraus? ");
        int numerodeDegraus = Convert.ToInt32(Console.ReadLine());

        programa.SubindoEscadas(numerodeDegraus);
    }
}
