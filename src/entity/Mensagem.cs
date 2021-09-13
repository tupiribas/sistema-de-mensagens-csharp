using System;
using System.Collections;

namespace Exercício
{
    public class Mensagem
    {
        public String Nome;
        public String Sobrenome;
        public String Mensagens;

        public ArrayList ListaDeMensagens = new ArrayList();

        public Mensagem(String Nome, String Sobrenome, String Mensagens)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Mensagens = Mensagens;
        }

        public void addMensagem(String Nome, String Msg)
        {
            ListaDeMensagens.Add(Nome);
            ListaDeMensagens.Add(Msg);
        }

        public void removerMensagem(String Nome)
        {
            int PosicaoMensagem = ListaDeMensagens.IndexOf(Nome);
            ListaDeMensagens.RemoveAt(PosicaoMensagem + 1);
            ListaDeMensagens.Remove(Nome);
        }

        public void MostrarMensagens()
        {
            Console.WriteLine("\n");
            foreach (String item in ListaDeMensagens)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }

        public override String ToString()
        {
            return "Nome: " + Nome + " " + Sobrenome +
            "\nMensagem: " + Mensagens;
        }
    }
}