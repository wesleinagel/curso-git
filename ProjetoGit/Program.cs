using System;

namespace ProjetoGit
{
    class Program
    {
        // vermelho: arquivos não rastreados (untracked)
        // verde: arquivo pronto para ser "commitados " (stage)

        /*git add - colocar arquivos modificados na área de "stage"
         *  git status - verificar quais são os arquivos no "stage" ou e "untracked"
         * 
         * git commit -m "nome do arquivos"
         * git log
         */


        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            Console.WriteLine(" Bom dia!");
            Console.ReadLine();

        }
    }
}
