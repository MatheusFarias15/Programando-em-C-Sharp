// Screen Sound 

void ExibirMensagem ()
{
    string mensagemDeBoasVindas = ("𝐵𝑜𝑎𝑠 𝑉𝑖𝑛𝑑𝑎𝑠 𝑎𝑜 𝑆𝑐𝑟𝑒𝑒𝑛 𝑆𝑜𝑢𝑛𝑑 \n" ); 
    Console.WriteLine(mensagemDeBoasVindas); 
}
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
        case 1: Console.WriteLine("Opção escolhida: " + opcaoEscolhidaNuemerica); 
            break; 
        case 2: Console.WriteLine("Opção escolhida: " + opcaoEscolhidaNuemerica); 
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

OpcoesDoMenu(); 