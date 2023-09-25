using System.Diagnostics;
using System.Linq.Expressions;

Decimal valorCarro, NumerosParcelas, valorPago=0;
Console.WriteLine("digite o valor do carrro:  ");

valorCarro = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escolha o numero de parcelas desejada \n");
Console.WriteLine("Para pagamento a vista opção 1 :  \n");
Console.WriteLine("Para pagamento em 6 opção 2 :  \n");
Console.WriteLine("Para pagamento em 12 opção 3 :  \n");
Console.WriteLine("Para pagamento em 18 opção 4 :  \n");
Console.WriteLine("Para pagamento em 24 opção 5 :  \n");
Console.WriteLine("Para pagamento em 30 opção 6 :  \n");
Console.WriteLine("Para pagamento em 36 opção 7 :  \n");
Console.WriteLine("Para pagamento em 42 opção 8 :  \n");
Console.WriteLine("Para pagamento em 48 opção 9 :  \n");
Console.WriteLine("Para pagamento em 54 opção 10 :  \n");
Console.WriteLine("Para pagamento em 60 opção 11 :  \n");
Console.WriteLine("Digite a opção desejada");

NumerosParcelas = Convert.ToDecimal(Console.ReadLine());

switch (NumerosParcelas)
{
    case 1:
        valorPago = valorCarro * 0.8m;
        break;
    case 2:
        valorPago = valorCarro * 1.03m;
        break;
    case 3:
        valorPago = valorCarro * 1.06m;
        break;
    case 4:
        valorPago = valorCarro * 1.09m;
        break;
    case 5:
        valorPago = valorCarro * 1.12m;
        break;
    case 6:
        valorPago = valorCarro * 1.15m;
        break;
    case 7:
        valorPago = valorCarro * 1.18m;
        break;
    case 8:
        valorPago = valorCarro * 1.21m;
        break;
    case 9:
        valorPago = valorCarro * 1.24m;
        break;
            case 10:
        valorPago = valorCarro * 1.27m;
        break;
    case 11:
        valorPago = valorCarro * 1.3m;
        break;
     default:
        Console.WriteLine("Codigo invalido");
        break;
}
Console.WriteLine("O valor pago pelo carro é  :" + valorPago);


