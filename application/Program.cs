using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem nMensagem = new Mensagem("Tupi", "Guedes", "Olá, Luana!");
            Console.WriteLine(nMensagem);

            Console.WriteLine("Digite o nome: ");
            String Nome = Console.ReadLine();
            Console.WriteLine("Digite uma mensagem: ");
            String Mensagem = Console.ReadLine();
            nMensagem.addMensagem(Nome, Mensagem);

            Console.WriteLine("Digite o nome: ");
            String NovoNome = Console.ReadLine();
            Console.WriteLine("Digite uma mensagem: ");
            String NovaMensagem = Console.ReadLine();
            nMensagem.addMensagem(NovoNome, NovaMensagem);

            nMensagem.MostrarMensagens();

            Console.WriteLine("Digite o nome da pessoa para remover a mensagem");
            String NomeParaRemover = Console.ReadLine();
            Console.WriteLine($"A mensagem de {Nome}, foi removida com sucesso!");
            nMensagem.removerMensagem(NomeParaRemover);

            nMensagem.MostrarMensagens();
        }
    }
}
