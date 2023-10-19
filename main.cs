using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas fases fáceis existem no jogo: ");
        int quantidade_fases_faceis = Convert.ToInt32(Console.ReadLine());

        int quantidade_fases_dificeis = 96 - quantidade_fases_faceis;

        int horas_fases_faceis = quantidade_fases_faceis;

        int horas_fases_dificeis = quantidade_fases_dificeis * 2;

        int total_horas = horas_fases_faceis + horas_fases_dificeis;

        int preco_por_hora = 5;
        int valor_jogatina = total_horas * preco_por_hora;

        Console.WriteLine("Quantidade fases fáceis: " + quantidade_fases_faceis);
        Console.WriteLine("Quantidade fases difíceis: " + quantidade_fases_dificeis);
        Console.WriteLine("Horas nas fases fáceis: " + horas_fases_faceis);
        Console.WriteLine("Horas nas fases difíceis: " + horas_fases_dificeis);
        Console.WriteLine("Total de horas gastas até concluir o jogo: " + total_horas);
        Console.WriteLine("Valor em reais da jogatina: R$ " + valor_jogatina);
    }
}