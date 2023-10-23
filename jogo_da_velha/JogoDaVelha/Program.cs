using System;

namespace JogoDaVelha
{
    internal class Program
    {
        static char[,] tabuleiro;

        static void Main(string[] args)
        {
            bool novoJogo = true;
            while (novoJogo)
            {
                Console.Write("Jogar contra a Máquina? (s/n): ");
                char resposta = char.Parse(Console.ReadLine());
                bool contraMaquina = resposta == 's';

                tabuleiro = new char[3, 3];
                InicializarTabuleiro();

                jogo(contraMaquina);

                Console.WriteLine("\n");
                Console.Write("Jogar Novamente? (s/n): ");
                char respostaJogoNovo = char.Parse(Console.ReadLine());
                if (respostaJogoNovo == 'n') novoJogo = false;
            }

            Console.WriteLine("FIM DO JOGO!");
        }

        static void InicializarTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '-';
                }
            }
        }

        static void jogo(bool contraMaquina)
        {
            char jogador1 = 'X';
            char jogador2 = contraMaquina ? 'O' : 'O';

            int movimentosRestantes = 9;
            int linha = -1;
            int coluna = -1;
            char jogadorAtual = jogador1;

            while (movimentosRestantes > 0)
            {
                Console.Clear();

                // Receber coordenadas do usuário ou da máquina
                Console.WriteLine($"\n\nVez do Jogador {jogadorAtual}: ");

                if (jogadorAtual == jogador1 || !contraMaquina)
                {
                    ObterCoordenadas(out linha, out coluna);
                }
                else
                {
                    // Lógica da Máquina (jogador 2)
                    ObterCoordenadasMaquina(out linha, out coluna);
                }

                // Verificar se o tabuleiro está vazio naquele local
                if (tabuleiro[linha, coluna] != '-')
                {
                    mensagem("## Movimento Inválido posição ocupada! ##");
                    continue;
                }

                // Anotando valor no tabuleiro
                tabuleiro[linha, coluna] = jogadorAtual;

                // Verificar se houve vencedor
                if (VerificarVencedor())
                {
                    Console.Clear();
                    Console.WriteLine($"\n\tO Jogador {jogadorAtual} Ganhou! =) \n");
                    MostrarTabuleiro();
                    break;
                }

                // Trocando os Jogadores
                jogadorAtual = (jogadorAtual == jogador1) ? jogador2 : jogador1;
                movimentosRestantes--;

                // Empate
                if (movimentosRestantes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t  Deu Empate =( ");
                    MostrarTabuleiro();
                    break;
                }
            }
        }

        static void ObterCoordenadas(out int linha, out int coluna)
        {
            bool isOk = false;
            linha = -1;
            coluna = -1;

            while (!isOk)
            {
                Console.Clear();
                MostrarTabuleiro();
                Console.Write("Digite a Linha (1 2 3): ");
                try
                {
                    linha = int.Parse(Console.ReadLine()) - 1;
                }
                catch (System.FormatException)
                {
                    mensagem("Precisa informar um valor para a linha.");
                    continue;
                }

                if ((linha < 0 || linha > 2))
                {
                    mensagem("Linha Inválida!");
                }
                else
                {
                    isOk = true;
                }
            }

            isOk = false;
            while (!isOk)
            {
                Console.Clear();
                MostrarTabuleiro();
                Console.Write("Digite a Coluna (1 2 3): ");
                try
                {
                    coluna = int.Parse(Console.ReadLine()) - 1;
                }
                catch (System.FormatException)
                {
                    mensagem("Precisa informar um valor para a coluna.");
                    continue;
                }

                if ((coluna < 0 || coluna > 2))
                {
                    mensagem("Coluna Inválida!");
                }
                else
                {
                    isOk = true;
                }
            }
        }

        static void ObterCoordenadasMaquina(out int linha, out int coluna)
        {
            Random random = new Random();
            linha = random.Next(0, 3);
            coluna = random.Next(0, 3);
        }

        static bool VerificarVencedor()
        {
            // Verificar linhas e colunas
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] != '-' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                    return true;

                if (tabuleiro[0, i] != '-' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                    return true;
            }

            // Verificar diagonais
            if (tabuleiro[0, 0] != '-' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
                return true;

            if (tabuleiro[0, 2] != '-' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                return true;

            return false;
        }

        static void MostrarTabuleiro()
        {
            int dimensao = tabuleiro.GetLength(0);
            for (int i = -1; i < dimensao; i++)
            {
                for (int j = -1; j < dimensao; j++)
                {
                    int indiceLinha = j;
                    if (i < 0)
                    {
                        indiceLinha++;
                        if (indiceLinha < dimensao)
                        {
                            Console.Write($"\t({indiceLinha + 1})");
                        }
                    }
                    else
                    {
                        if (j < 0)
                        {
                            Console.Write($"({i + 1}) ");
                        }
                        else
                        {
                            Console.Write($"\t{tabuleiro[i, j]}");
                        }
                    }
                }
                Console.WriteLine("\n");
            }
        }

        static void mensagem(string texto)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n## {texto} ##");


            Console.BackgroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(2000);
        }
    }
}
