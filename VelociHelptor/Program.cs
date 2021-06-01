using System;
using System.Collections.Generic;

namespace VelociHelptor
{
    class Program
    {
        static List<Usuario> listUsuario = new List<Usuario>();  // Lista para armazenar meus usuário enquanto não temos um BD.
        static List<Chamado> listChamado = new List<Chamado>();  // Lista para armazenar meus chamados enquanto não temos um BD.

        static void Main(string[] args)
        {
            Console.ForegroundColor = (ConsoleColor.Green);

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        CadastrarUsuario(); // Opção para cadastrar novo usuário
                        break;
                    case "2":
                        ListarUsuarios(); // Opção para listar usuários cadastras
                        break;

                    case "3":
                        CriarChamado(); // Opção para criar novo chamado
                        break;

                    case "4":
                        ListarChamados(); // Opção para listar chamados cadastrados
                        break;

                    case "C":
                        Console.Clear(); // Opção para limpar console
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Obrigado por utilizar nossos serviços.");

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

     
        private static void CadastrarUsuario() // Para cadastrar novo usuário
        {
            Console.WriteLine("Cadastrar novo usuário");

            Console.WriteLine("Digite o nome: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o email: ");
            string entradaEmail = Console.ReadLine();

            Console.WriteLine("Digite seu tipo de usuário. 1 -Técnico, 2 - Administrador, 3 - Funcionário: ");
            int entradatipousuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua senha: ");
            string entradasenha = Console.ReadLine();



            Usuario novoUsuario = new Usuario(Tipo: (Tipo)entradatipousuario,
                                        Nome: entradaNome,
                                        Email: entradaEmail,
                                        Senha: entradasenha);

            listUsuario.Add(novoUsuario);


        }

        private static void ListarUsuarios() // Para listar usuários
        {
            Console.WriteLine("Listar usuários");

            if (listUsuario.Count == 0)
            {
                Console.WriteLine("Nenhuma usuário cadastrado.");
                return;
            }

            for (int i = 0; i < listUsuario.Count; i++)
            {
                Usuario Usuario = listUsuario[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(Usuario);
            }
        }

        private static void CriarChamado() // Para criar novo chamado
        {
            Console.WriteLine("Crie um novo chamado");
           

            Console.WriteLine("Digite a prioridade do chamado: 1-Baixa, 2-Media, 3-Alta, 4-Bloqueante \n");
            int entradaPrioridade = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite título do chamado: \n");
            string entradaTitulo = Console.ReadLine();
            

            Console.WriteLine("Digite a descrição do chamado: \n");
            string entradaDescricao = Console.ReadLine();
            


            Console.WriteLine("Digite seu usuário: \n");
            string entradaUsuario = Console.ReadLine();
           
      
            Console.WriteLine("Status chamado: 1- Novo, 2 -Em análise, 3- Finalizado");
            int entradaStatus = int.Parse(Console.ReadLine());



            Chamado novoChamado = new Chamado(Prioridade: (Prioridade)entradaPrioridade,
                                        Titulo: entradaTitulo,
                                        Descricao: entradaDescricao,
                                        Usuario: entradaUsuario,
                                        StatusChamado: (StatusChamado)entradaStatus);

            listChamado.Add(novoChamado);

        }


        private static void ListarChamados() // Para listar chamados cadastrados
        {
            Console.WriteLine("Listar chamado");

            if (listChamado.Count == 0)
            {
                Console.WriteLine("Nenhuma chamado cadastrado.");
                return;
            }

            for (int i = 0; i < listChamado.Count; i++)
            {
                Chamado Chamado = listChamado[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(Chamado);
            }
        }

        private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("Seja bem vindo ao VelociHeptor \n");
                Console.WriteLine("Informe a opção desejada: ");


                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Criar chamado");
                Console.WriteLine("4 - Listar chamados");
                Console.WriteLine("C - Limpar tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }

        }

    }

