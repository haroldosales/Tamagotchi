


        ServicesApi escolhar  = new ServicesApi();
        Console.WriteLine("Bem vindo ao Tamogtchi ");

        Console.WriteLine("Qual é seu nome?");
        string name = Console.ReadLine();

        Console.WriteLine("--------------Menu-----------------");

        Console.WriteLine(name + ", o que voce Deseja");
        Console.WriteLine(@"1 - Adotar um mascote virutal");

        Console.WriteLine(@"2 - ver os  mascote virutal");
        Console.WriteLine(@"3 - Sair");

        string funcao = Console.ReadLine();
        if (funcao == funcao)
        {
            escolhar.OneOne("1");
            escolhar.OneOne("2");
            escolhar.OneOne("3");
            Console.WriteLine("--------------Menu-----------------");

            Console.WriteLine(name + ", o que voce Deseja");
            Console.WriteLine(@"1 - Adotar um mascote virutal");

            Console.WriteLine(@"2 - ver os  mascote virutal");
            Console.WriteLine(@"3 - Sair");

             funcao = Console.ReadLine();

            switch (funcao)
            {

                case "1":
                    Console.WriteLine(name + ", o que voce Deseja");

                    funcao = Console.ReadLine();

                    escolhar.dadosPork(funcao);
                    break;
                case "2":
                    escolhar.OneOne("1");
                    escolhar.OneOne("2");
                    escolhar.OneOne("3");
                    Console.WriteLine(name + ", o que voce Deseja");


                    break;
                case "3":
                    break;

            }

        }

