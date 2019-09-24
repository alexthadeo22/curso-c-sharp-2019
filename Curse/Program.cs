using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Date 
            /*
           #region Time Span 

          TimeSpan t1d = new TimeSpan();
          TimeSpan t2d = new TimeSpan(900000000L);
          TimeSpan t3d = new TimeSpan(2, 11, 21);
          TimeSpan t4d = new TimeSpan(1, 2, 11, 21);
          TimeSpan t5d = new TimeSpan(1, 2, 11, 21, 321);
          Console.WriteLine(t1d);
          Console.WriteLine(t2d);
          Console.WriteLine(t3d);
          Console.WriteLine(t4d);
          Console.WriteLine(t5d);

          TimeSpan tf1 = TimeSpan.FromDays(1.5);
          TimeSpan tf2 = TimeSpan.FromHours(1.5);
          TimeSpan tf3 = TimeSpan.FromMinutes(1.5);
          TimeSpan tf4 = TimeSpan.FromSeconds(1.5);
          TimeSpan tf5 = TimeSpan.FromMilliseconds(1.5);
          TimeSpan tf6 = TimeSpan.FromTicks(900000000L);
          Console.WriteLine(tf1);
          Console.WriteLine(tf2);
          Console.WriteLine(tf3);
          Console.WriteLine(tf4);
          Console.WriteLine(tf5);
          Console.WriteLine(tf6);

          //OPERAÇÕES TIME SPAN
          TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
          Console.WriteLine(t);
          Console.WriteLine("Days: " + t.Days);
          Console.WriteLine("Hours: " + t.Hours);
          Console.WriteLine("Minutes: " + t.Minutes);
          Console.WriteLine("Milliseconds: " + t.Milliseconds);
          Console.WriteLine("Seconds: " + t.Seconds);
          Console.WriteLine("Ticks: " + t.Ticks);
          Console.WriteLine("TotalDays: " + t.TotalDays);
          Console.WriteLine("TotalHours: " + t.TotalHours);
          Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
          Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
          Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

          TimeSpan t1 = new TimeSpan(1, 30, 10);
          TimeSpan t2 = new TimeSpan(0, 10, 5);
          TimeSpan sum = t1.Add(t2);
          TimeSpan dif = t1.Subtract(t2);
          TimeSpan mult = t2.Multiply(2.0);
          TimeSpan div = t2.Divide(2.0);
          Console.WriteLine(t1);
          Console.WriteLine(t2);
          Console.WriteLine(sum);
          Console.WriteLine(dif);
          Console.WriteLine(mult);
          Console.WriteLine(div);
          #endregion

          #region Date Time
          DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
          Console.WriteLine(d);
          Console.WriteLine("1) Date: " + d.Date);
          Console.WriteLine("2) Day: " + d.Day);
          Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
          Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
          Console.WriteLine("5) Hour: " + d.Hour);
          Console.WriteLine("6) Kind: " + d.Kind);
          Console.WriteLine("7) Millisecond: " + d.Millisecond);
          Console.WriteLine("8) Minute: " + d.Minute);
          Console.WriteLine("9) Month: " + d.Month);
          Console.WriteLine("10) Second: " + d.Second);
          Console.WriteLine("11) Ticks: " + d.Ticks);
          Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
          Console.WriteLine("13) Year: " + d.Year);

        // Formatação(DateTime-> string)

          string s1 = d.ToLongDateString();
          string s2 = d.ToLongTimeString();
          string s3 = d.ToShortDateString();
          string s4 = d.ToShortTimeString();
          string s5 = d.ToString();
          string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
          string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
          Console.WriteLine(s1);
          Console.WriteLine(s2);
          Console.WriteLine(s3);
          Console.WriteLine(s4);
          Console.WriteLine(s5);
          Console.WriteLine(s6);
          Console.WriteLine(s7);

          DateTime d1 = new DateTime(2000, 8, 15);
          DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
          DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
          Console.WriteLine(d1);
          Console.WriteLine(d2);
          Console.WriteLine(d3);

          DateTime d4 = DateTime.Now;
          DateTime d5 = DateTime.UtcNow;
          DateTime d6 = DateTime.Today;
          Console.WriteLine(d4);
          Console.WriteLine(d5);
          Console.WriteLine(d6);

          DateTime d7 = DateTime.Parse("2000-08-15");
          DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
          DateTime d9 = DateTime.Parse("15/08/2000");
          DateTime d0 = DateTime.Parse("15/08/2000 13:05:58");
          Console.WriteLine(d7);
          Console.WriteLine(d8);
          Console.WriteLine(d9);
          Console.WriteLine(d0);

          DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
          DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
          CultureInfo.InvariantCulture);
          Console.WriteLine(d11);
          Console.WriteLine(d12);


           DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
           DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
           DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
           Console.WriteLine("d1: " + d1);
           Console.WriteLine("d1 Kind: " + d1.Kind);
           Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
           Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
           Console.WriteLine();
           Console.WriteLine("d2: " + d2);
           Console.WriteLine("d2 Kind: " + d2.Kind);
           Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
           Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
           Console.WriteLine();
           Console.WriteLine("d3: " + d3);
           Console.WriteLine("d3 Kind: " + d3.Kind);
           Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
           Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
           #endregion
            */
            #endregion

            #region condição tenaria
            /*
            double preco = double.Parse(Console.ReadLine());
            double desconto1;
            if (preco < 20.0)
            {
                desconto1 = preco * 0.1;
            }
            else
            {
                desconto1 = preco * 0.05;
            }

           double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto1);
            Console.WriteLine(desconto2);
            */
            #endregion

            #region execicio Conjuntos
            /*
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int NA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for (int i = 1; i <= NA; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                A.Add(cod);
            }

            Console.Write("O curso A possui quantos alunos? ");
            int NB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for (int i = 1; i <= NB; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                B.Add(cod);
            }

            Console.Write("O curso A possui quantos alunos? ");
            int NC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for (int i = 1; i <= NC; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                C.Add(cod);
            }
            B.UnionWith(C);
            A.UnionWith(B);
                Console.WriteLine("Total de alunos: "+ A.Count);
           */
            #endregion

            #region Conjuntos
            /*
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            Console.WriteLine("--------------------------A");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------------------------B");
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            B.Remove(4);
            Console.WriteLine("--------------------------B - Remove");
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            A.ExceptWith(B);
            Console.WriteLine("-------------------------A.ExceptWith(B)");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            A.UnionWith(B);
            Console.WriteLine("-------------------------A.UnionWith(B);");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            A.IntersectWith(B);
            Console.WriteLine("-------------------------  A.IntersectWith(B);");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

           Console.WriteLine("Digite um numero inteiro : ");
           int N = int.Parse(Console.ReadLine());

           if(B.Contains(N))
           {
               Console.WriteLine(N+" pertence a o conjunto B");
           }
           else
           {
               Console.WriteLine(N + " Não pertence a o conjunto B");
           }
           */
            #endregion

            #region matriz 
            /*
            int M, N;
            int[,] matriz;


            string[] ler = Console.ReadLine().Split(' ');
            M = int.Parse(ler[0]);
            N = int.Parse(ler[1]);

            matriz = new int[M, N];
            // Ler os dados
            for (int l = 0; l < M; l++)
            {
                string[] vs = Console.ReadLine().Split(' ');

                for (int c = 0; c < N; c++)
                {
                    matriz[l, c] = int.Parse(vs[c]);

                }
            }
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            // imprimir matriz
            for (int l = 0; l < M; l++)
            {

                for (int c = 0; c < N; c++)
                {

                    if(matriz[l, c] == num)
                    {
                        Console.WriteLine("Position " + l +","+c + ":");

                        if ((c - 1) >= 0 && (c - 1) <= (N -1))
                        {
                            Console.WriteLine("Left: " + matriz[l, (c - 1)]);
                        }
                        if ((c + 1) >= 0 && (c + 1) <= (N - 1))
                        {
                            Console.WriteLine("Right: " + matriz[l, (c + 1)]);
                        }
                        if ((l - 1) >= 0 && (l - 1) <= (M -1))
                        {
                            Console.WriteLine("Up: " + matriz[(l - 1), c]);
                        }
                        if ((l + 1) >= 0 && (l + 1) <= (M - 1))
                        {
                            Console.WriteLine("Down: " + matriz[(l + 1), c]);
                        }

                    }


                }

            }

            Console.Read();
        */
            #endregion

            #region Employee
            /*
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());


            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrement = int.Parse(Console.ReadLine());
            Employee emp = listEmployee.Find(x => x.Id == idIncrement);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee s in listEmployee)
            {
                Console.WriteLine(s);
            }

            */
            #endregion

            #region List
            /*
            //lista
            List<string> lista = new List<string>();
            //adiciona na lista
            lista.Add("maria");
            lista.Add("alex");
            lista.Add("bob");
            lista.Add("anna");
            //insert na posição
            lista.Insert(2, "marco");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Tamanho da lista : " + lista.Count);

            // expressão Lambda x => x[0] =='a' encontrar primeira 'a'
            string s1 = lista.Find(x => x[0] =='a');
            Console.WriteLine("first name with 'a' : "+s1);
            // expressão Lambda x => x[0] =='a' encontrar ultima 'a'
            string s2 = lista.FindLast(x => x[0] == 'a');
            Console.WriteLine("last name with 'a' : " + s2);

            int p1 = lista.FindIndex(x => x[0] == 'a');
            Console.WriteLine("first position with 'a' : " + p1);
            int p2 = lista.FindLastIndex(x => x[0] == 'a');
            Console.WriteLine("last position with 'a' : " + p2);
            //filtro
            List<string> filtro = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------");
            foreach (string s in filtro)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------");
            //remove na posição indicada
            lista.RemoveAt(3);
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------");
            //remove condição indicada
            lista.Remove("alex");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------");
            //remove tudo condição indicada
            lista.RemoveAll(x => x[0] == 'm');
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            lista.Add("alucard");
            lista.Add("andersen");
            lista.Add("victoria");
            lista.Add("valter");
            lista.Add("morigam");

            Console.WriteLine("---------------------------- new list");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            //remove no range indicada inicio,quantidade
            lista.RemoveRange(2,3);

            Console.WriteLine("---------------------------- ");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }

        //metodo s posição caractere  0 com 'a'
            static bool teste(string s)
            {
                return s[0] == 'a';
            }

       */

            #endregion

            #region Calculator
            /*
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */
            #endregion

            #region Quartos alugar
            /*
            Console.Write("Quantos quartos serão alugados?"); 
            int n = int.Parse(Console.ReadLine());

            Quartos[] vet = new Quartos[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" +(i+1));
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());           

               vet[quarto] = new Quartos {Nome = name, Email = email, Quarto = quarto };
            }
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if(vet[i] != null )
                { 
                Console.WriteLine(vet[i].Quarto.ToString()+": "+vet[i].Nome+", "+vet[i].Email);
                }
            }
    */
            #endregion

            #region Product
            /*
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                vet[i] = new Product { Nome = name, Price = price };
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */

            #endregion

            #region Nullable
            /*
           // Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            //operado coalecencia se null = valor;
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //se null = valor padrao;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //se boleano;
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            */
            #endregion

            #region conta bancária

            /*
               Console.Write("Entre o número da conta: ");
               int conta = int.Parse(Console.ReadLine());

              Console.Write("Entre o titular da conta: ");
              string titular = Console.ReadLine();

               Console.Write("Haverá depósito inicial (s/n)? ");
               char opcao = Console.ReadKey().KeyChar;

               Console.WriteLine();
               double valor = 0.0;
               if (opcao == 's')
               {
                   Console.Write("Entre o valor de depósito inicial: ");
                   valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               }


               Console.WriteLine();

              ContaBancaria contaBancaria = new ContaBancaria(conta,titular,valor);


              Console.WriteLine("Dados da conta: ");
              Console.WriteLine(contaBancaria);

               Console.Write("Entre um valor para depósito: ");
               valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               contaBancaria.Deposito(valor);
               Console.WriteLine("Dados da conta atualizados: ");
               Console.WriteLine(contaBancaria);

               Console.Write("Entre um valor para saque: ");
               valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               contaBancaria.Saque(valor);
               Console.WriteLine("Dados da conta atualizados: ");
               Console.WriteLine(contaBancaria);
               */
            #endregion

            #region ConversaoDeMoeda
            /*
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversaoDeMoeda = ConversorDeMoeda.CoverterMoeda(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais = " + conversaoDeMoeda.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Calculadora
            /*
             Console.Write("Entre o valor do raio: ");
             double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             double circ = Calculadora.Circunferencia(raio);
             double volume = Calculadora.Volume(raio);
             Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
             */
            #endregion

            #region Aluno
            /*
                       Aluno aluno  = new Aluno();

                       Console.Write("Nome do aluno: ");
                       aluno.Nome = Console.ReadLine();

                       Console.WriteLine("Digite as três notas do aluno:");
                       aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                       Console.WriteLine("NOTA FINAL ="+aluno.MediaNotas().ToString("F2",CultureInfo.InvariantCulture));

                       if (aluno.MediaNotas() > 60.0)
                       {
                           Console.WriteLine("APROVADO");
                       }
                       else
                       {
                           Console.WriteLine("REPROVADO");
                           Console.WriteLine("FALTARAM " + aluno.FaltaNota().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");

                       }



                       */
            #endregion

            #region Funcionario
            /*
            double qte;

            Funcionario funcionario  = new Funcionario();

            Console.Write("Nome:");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário:");
            qte = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(qte);

            Console.WriteLine("Dados atualizados: " + funcionario);
            */
            #endregion

            #region Retangulo
            // Retangulo
            /*
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");

            retangulo.Altura = double.Parse(Console.ReadLine());
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = "+retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Produto
            //Produto
            /*
            int qte; 

            Produto produto;
            produto = new Produto();


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço:");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque:");
            produto.QtdEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+produto);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.AdicionaProduto(qte);


            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoveProduto(qte);


            Console.WriteLine("Dados atualizados: " + produto);
            */
            #endregion

            #region Triangulo
            //triangulo
            /* 
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X :");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y :");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = x.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */
            #endregion
        }
    }
}
