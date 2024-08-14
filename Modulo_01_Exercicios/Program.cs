namespace modulo01Exercicios;

class Program
{
    

    static void Main()
    {
        // Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida.

        Console.WriteLine("Digite o seu nome: ");

        var nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}. Seja bem vindo!");



        // Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

        Console.WriteLine("Digite o seu nome: ");

        var nome_02 = Console.ReadLine();

        Console.WriteLine("Digite o seu sobrenome: ");

        var sobrenome = Console.ReadLine();

        Console.WriteLine(nome + " " + sobrenome);


        /* Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
        - A soma entre esses dois números;
        - A subtração entre os dois números;
        - A multiplicação entre os dois números;
        - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
        - A média entre os dois números.*/

        double numero_01 = 10;
        double numero_02 = 20;

        var soma = numero_01 + numero_02;
        var subtracao = numero_01 - numero_02;
        var multiplicacao = numero_01 * numero_02;
        var divisao = numero_01 / numero_02;

        var media = (numero_01 + numero_02) / 2;

        Console.WriteLine($"Soma: {numero_01} + {numero_02} = {soma}"); 
        Console.WriteLine($"Subtração: {numero_01} - {numero_02} = {subtracao}"); 
        Console.WriteLine($"Multiplicação: {numero_01} x {numero_02} = {multiplicacao}"); 
        Console.WriteLine($"Divisão: {numero_01} / {numero_02} = {divisao}"); 
        Console.WriteLine($"A média é {media}"); 


        // Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

        Console.WriteLine("Digite algo aqui:");

        var quantidade_carateres = Console.ReadLine();

        Console.WriteLine($"A palavra inserida possui {quantidade_carateres.Count()} caracteres.");



        /* Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        - A placa deve ter 7 caracteres alfanuméricos;
        - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
        - Os quatro últimos caracteres são números;

        Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.*/

        Console.WriteLine("Digite a placa de um veículo:");

        var placa = Console.ReadLine();

        if (placa.Count() == 7 && char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]) && char.IsDigit(placa[3]) && char.IsDigit(placa[4]) && char.IsDigit(placa[5]) && char.IsDigit(placa[6]))
        {
            Console.WriteLine(true);
        }
        else { 
            Console.WriteLine(false);
        }




        /*  Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        - Apenas a data no formato "01/03/2024".
        - Apenas a hora no formato de 24 horas.
        - A data com o mês por extenso.*/



        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha o formato para exibição da data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"dd/MM/yyyy\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        var opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.WriteLine(dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        }
        else if (opcao == "2")
        {
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        }
        else if (opcao == "3")
        {
            Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
        }
        else if (opcao == "4")
        {
            Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
        }
        else {
            Console.WriteLine("Opção inválida!");
        }


    }

}


