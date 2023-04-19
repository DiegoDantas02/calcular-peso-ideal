using System;

class CalculadoraDePesoIdeal
{
    static void Main(string[] args)
    {
        double altura, pesoIdeal;
        string sexo;

        Console.Write("Digite a altura (em metros): ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F) em Maiúsculo: ");
        sexo = Console.ReadLine();

        if (sexo == "M")
        {
            pesoIdeal = 72.7 * altura - 58;
            Console.WriteLine("O peso ideal para um homem de " + altura.ToString("F2") + "m é " + pesoIdeal.ToString("F2") + "kg");
        }
        else if (sexo == "F")
        {
            pesoIdeal = 62.1 * altura - 44.7;
            Console.WriteLine("O peso ideal para uma mulher de " + altura.ToString("F2") + "m é " + pesoIdeal.ToString("F2") + "kg");
        }
        else
        {
            Console.WriteLine("Sexo inválido");
        }
    }
}
