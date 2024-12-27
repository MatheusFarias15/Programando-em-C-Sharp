// Screen Sound 

void ExibirMensagem ()
{
    string mensagemDeBoasVindas = ("𝐵𝑜𝑎𝑠 𝑉𝑖𝑛𝑑𝑎𝑠 𝑎𝑜 𝑆𝑐𝑟𝑒𝑒𝑛 𝑆𝑜𝑢𝑛𝑑 \n" ); 
    Console.WriteLine(mensagemDeBoasVindas); 
}
List<string> ListaDasBandas = new List<string>(); 

ExibirMensagem();

void OpcoesDoMenu ()
{
    Console.WriteLine("Digite 1 para criar uma banda \n "); 
    Console.WriteLine("Digite 2 para mostrar todas as bandas \n"); 
    Console.WriteLine("Digite 3 para avaliar uma banda \n");
    Console.WriteLine("Digite 4 para exibir a media \n"); 
    Console.WriteLine("Digite 5 para sair \n");
    Console.Write("Digite a opção que dele selecionar: "); 
    string opcaoEscolhida =     Console.ReadLine()!;
    int opcaoEscolhidaNuemerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNuemerica){
        case 1: RegistrarBanda();
            break; 
        case 2: MostrarBandasRegistradas(); 
            break; 
        case 3: Console.WriteLine("Opção escolhida: " + opcaoEscolhidaNuemerica); 
            break; 
        case 4: Console.WriteLine("Opção escolhida: " + opcaoEscolhidaNuemerica); 
            break; 
        case 5: Console.WriteLine("Opção escolhida: " + opcaoEscolhidaNuemerica); 
            break; 
        default: Console.WriteLine("Opção Invalida"); 
            break; 
    }
}

void RegistrarBanda(){
    Console.Clear();
    ExibirTituloOpcoes("Registrar Bandas"); 
    Console.Write("Digite o nome da banda que deseja ser registrada: "); 
    string nomeDaBanda = Console.ReadLine()! ; 
    ListaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda foi {nomeDaBanda} registrada com sucesso"); 
    Thread.Sleep(2000);
    Console.Clear(); 
    OpcoesDoMenu();  

}

void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTituloOpcoes("Exibindo todas as bandas registradas!!");
    // for (int i = 0; i < ListaDasBandas.Count; i++){
    //     Console.WriteLine($"Banda: {ListaDasBandas[i]}");

    // }

    foreach (string banda in ListaDasBandas) // Outra forma de fazer loop me C# 
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\n Digite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear(); 
    OpcoesDoMenu(); 
}

void ExibirTituloOpcoes(string titulo){
    int QuantidadeDeLetras = titulo.Length;
    string Asteriscos = string.Empty.PadLeft(QuantidadeDeLetras, '*');  
    Console.WriteLine(Asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(Asteriscos); 
}

ExibirMensagem();
OpcoesDoMenu(); 