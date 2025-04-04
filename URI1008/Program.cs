int funcionario = int.Parse(Console.ReadLine());
int horas = int.Parse(Console.ReadLine());
double preco_da_hora = double.Parse(Console.ReadLine());
double valor_das_horas = horas * preco_da_hora;
Console.WriteLine("NUMBER = " + funcionario);
Console.WriteLine("SALARY = U$ " + valor_das_horas.ToString("F2"));
