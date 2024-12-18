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
}

OpcoesDoMenu(); 