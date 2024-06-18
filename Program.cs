using System.Security.Cryptography;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta; 
Console.WriteLine("---Estacionamento---\n"); 
Console.ResetColor();
Console.WriteLine("---Tamanho do veículo---(P/G)");
string digitado = Console.ReadLine()!.ToUpper();
string veiculo=digitado; 

if(digitado!="P"&&digitado!="G") 
{
    Console.WriteLine("Tamanho inválido.");
    return;

}
else if(digitado=="P")
{ 
    digitado="25";

}
else if(digitado=="G")
{
    digitado="50";

}

decimal PrecoHora=Convert.ToDecimal(digitado);
Console.WriteLine("---Tempo---(min)");
Double Tempo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("---Serviço Manobrista---(S/N)");
digitado = Console.ReadLine()!.ToUpper();
if(digitado!="S"&&digitado!="N")
{
    Console.WriteLine("Tempo inválido.");
    return;

}
else if(digitado=="S")
{
    digitado="0,20";

}
else if(digitado=="N")
{
    digitado="1";
    
}

decimal PrecoManobrista = Convert.ToDecimal(digitado);
Console.WriteLine("---Serviço Lavagem---(S/N)");
digitado = Console.ReadLine()!.ToUpper();

if(digitado!="S"&&digitado!="N")
{
    return;
    
}
else if(digitado=="S" && veiculo=="P")
{
    digitado="50";
    
} 
else if(digitado=="S" && veiculo=="G")
{
    digitado="100";
    
}
else
{
    digitado="0";
    
}

Double PrecoLavagem = Convert.ToDouble(digitado);
decimal PrecoFinalEstacionamento = 0; 
if(65 >= Tempo)
{
    PrecoFinalEstacionamento=20;
    
}
else if (veiculo=="P")
{
    PrecoFinalEstacionamento=Convert.ToDecimal(20+10*Math.Round((Tempo-60)/60));
    
}
else if (veiculo=="G")
{
    PrecoFinalEstacionamento=Convert.ToDecimal(20*Math.Round(Tempo/60));
    
}
PrecoManobrista = PrecoFinalEstacionamento*PrecoManobrista;
Console.WriteLine($"\nEstacionamento..: {PrecoFinalEstacionamento,14:C}");
Console.WriteLine($"Valet...........: {PrecoManobrista,14:C}");
Console.WriteLine($"Lavagem.........: {PrecoLavagem,14:C}");
Console.WriteLine("--------------------------------");
decimal Total = PrecoFinalEstacionamento+PrecoManobrista+Convert.ToDecimal(PrecoLavagem);
Console.WriteLine($"Total...........: {Total,14:C}");