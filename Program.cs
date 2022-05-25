using er6.Classes;

Console.WriteLine(@$"
================================================
|     Bem vindo ao sistema de cadastro de      |
|     Pessoas Fisicas e Pessoas Juridicas      |
================================================
");

BarraCarregamento("Carregando ",500);

string? opcao;

do
{

    Console.Clear();
    Console.WriteLine(@$"
================================================
|        Escolha uma das opções abaixo         |
|                                              |
|        1 - Pessoa Fisica                     |
|        2 - Pessoa Juridica                   |
|        0 - Sair                              |
================================================
    ");

opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();
            PessoaFisica novoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novoPf.nome = "Milton Augusto";
            novoPf.dataNascumento = "1981/11/17";
            novoPf.cpf="62349139387";
            novoPf.rendimento= 200.0f;

            novoEnd.logradouro  = "Rua dois";
            novoEnd.numero = 924;
            novoEnd.complemento = "Prox a Houston Bike";
            novoEnd.endComercial = false;

            novoPf.endereco = novoEnd;

            Console.WriteLine($"Nome: {novoPf.nome}");
            Console.WriteLine($"Cpf: {novoPf.cpf}");
            Console.WriteLine($"Data de Nascimento: {novoPf.dataNascumento}");
            Console.WriteLine($"Rendimento: {novoPf.rendimento}");
            Console.WriteLine($"Endereco: {novoPf.endereco.logradouro}, {novoPf.endereco.numero}");

            string retorno1 = metodoPf.validarDataNascimento(new String(novoPf.dataNascumento));
            Console.WriteLine($"Imposto a pagar: {metodoPf.PagarImposto(novoPf.rendimento)}");
            Console.WriteLine(retorno1);

            Console.WriteLine(" ");

            string retorno2 = novoPf.validarDataNascimento(new string("2021,01,01"));

            Console.WriteLine(retorno2);

            string retorno3 = novoPf.validarDataNascimento(new string("2021//01/01"));

            Console.WriteLine(retorno3);

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica novaPJ = new PessoaJuridica();
            PessoaJuridica metodoPJ = new PessoaJuridica();
            Endereco novoEndPJ = new Endereco();

            novaPJ.nome = "Fulano de tal";
            novaPJ.cnpj = "00.000.000/0001-00";
            novaPJ.razaoSocial = "Fulano de tal S/A";
            novaPJ.rendimento = 100000.0f;

            novoEndPJ.logradouro  = "Rua 11 de Junho";
            novoEndPJ.numero = 785;
            novoEndPJ.complemento = "Prox a Ambev";
            novoEndPJ.endComercial = true;

            novaPJ.endereco = novoEndPJ;

            Console.WriteLine($"Razao Social: {novaPJ.razaoSocial}");
            Console.WriteLine($"Nome Fantasia: {novaPJ.nome}");
            Console.WriteLine($"CNPJ: {novaPJ.cnpj}");
            Console.WriteLine($"CNPJ Valido: {metodoPJ.ValidarCnpj2(novaPJ.cnpj)}");

            Console.WriteLine($"Rendimento: {novaPJ.rendimento}");

            Console.WriteLine($"Endereco: {novaPJ.endereco.logradouro}, {novaPJ.endereco.numero}, {novaPJ.endereco.complemento}");
            Console.WriteLine($"Endereco comercial: {novaPJ.endereco.endComercial}");

            Console.WriteLine($"Imposto a pagar: {metodoPJ.PagarImposto(novaPJ.rendimento)}");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nosso sistema");
            BarraCarregamento("Finalizando", 200);
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção invalida, favor digitar outra opção");
            Thread.Sleep(2000);
            break;
    }

    
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo) {
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 5; contador++) {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();

}