     // TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
        string titulo, descricao, dataVencimento;

        // Obtém o titulo e a descricao a partir da entrada do console  
        Console.Write("Digite o título da tarefa: ");
        titulo = Console.ReadLine();

        Console.Write("Digite a descrição da tarefa: ");
        descricao = Console.ReadLine();

        // TODO: Crie uma estrutura condicional 'if' para verificar se a descrição da tarefa excede 50 caracteres.
        if (descricao.Length > 50)
        {
            Console.WriteLine("A descrição ultrapassa o limite de caracteres permitidos.");
            Environment.Exit(0);
        }

        // Caso a descricao esteja dentro do limite, é solicitado a entrada pelo console:
        Console.Write("Digite a data de vencimento: ");
        dataVencimento = Console.ReadLine();

        // Imprime a descricao e a data de vencimento
        Console.WriteLine($"{descricao} até {dataVencimento}");