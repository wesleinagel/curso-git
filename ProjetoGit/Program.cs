using System;

namespace ProjetoGit
{
    class Program
    {
        /* Github: é um serviço de armazenamento remoto de repositórios Git
        
        Repositório, ou repo, é um diretório onde os arquivos do seu projeto ficam armazenados. Ele pode ficar em um depósito do GitHub ou em seu computador.
        Você pode armazenar códigos, imagens, áudios, ou qualquer outra coisa relacionada ao projeto no diretório.

        padrão da indústria para armazenamento de projetos de código aberto

        Maior hospedeiro de código fonte do mundo

        É um "rede social" de repositórios Git. Dica: currículo!
         */

        // vermelho: arquivos não rastreados (untracked)
        // verde: arquivo pronto para ser "commitados " (stage)

        /* iniciar com botão direito "git bash here"
         * 
         * git add - colocar arquivos modificados na área de "stage"
         *  git status - verificar quais são os arquivos no "stage" ou e "untracked"
         * 
         * git commit -m "nome do arquivos"
         * git log
         * 
         * git push para atualizar diretamente no repositorio da pagina
         * 
         * 
         * git status -> untracked  ->(git add.) -> staged(pronto) -> git commit -m"msg" -> committed (salvo)
         * 
         * git log --oneline (oneline, é assim mesmo) - busca as alterações e atualizações feita ao longo de este unico projeto
         * git log - busca cada alteração feita ao longo do projeto com detalhes de quem e quando. 
         *
         * 
         * 
         */


        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            Console.WriteLine(" Como você está hoje?");
            Console.WriteLine("Tenha um bom dia");
            Console.ReadLine();

        }
    }
}
