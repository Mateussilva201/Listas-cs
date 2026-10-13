// Adicionar e remover tarefas


        List<string> tarefa = new List<string>();
        string task;

        do
        {
            Console.Write("Adicione uma tarefa: ");
            task = Console.ReadLine();

            if (task == "fim" || task == "Fim" || task == "FIM")
            {
                break;
            }

            tarefa.Add(task);

        } while (true);

        for (int i = 0; i < tarefa.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {tarefa[i]}");
        }

        string escolha;

        while (tarefa.Count > 0)
        {
            Console.Write("Deseja remover um item da lista? s/n: ");
            escolha = Console.ReadLine();

            if (escolha == "n" || escolha == "N" || escolha == "Não" || escolha == "NÃO" || escolha == "nao")
            {
                break;
            }
            else if (escolha == "s" || escolha == "S" || escolha == "Sim" || escolha == "SIM")
            {
                Console.Write("Digite o número ou nome da tarefa que você quer remover: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int posicao))
                {
                    int indice = posicao - 1;

                    if (indice >= 0 && indice < tarefa.Count)
                    {
                        Console.WriteLine($"Tarefa {posicao} removida");
                        tarefa.RemoveAt(indice);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                    }
                }
                else
                {
                    if (tarefa.Remove(entrada))
                    {
                        Console.WriteLine($"Tarefa {entrada} removida");
                    }
                    else
                    {
                        Console.WriteLine("Tarefa não encontrada pelo nome.");
                    }
                }

                if (tarefa.Count == 0)
                {
                    Console.WriteLine("Sua lista está vazia");
                }
                else
                {
                    Console.WriteLine("\n--- Lista Atualizada ---");
                    for (int i = 0; i < tarefa.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {tarefa[i]}");
                    }
                }
            }
        }
    
