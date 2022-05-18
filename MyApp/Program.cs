// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

if(5>3){
    Console.WriteLine("5 es mayor que 3");
}else{
    Console.WriteLine("5 es menor que 3");
}
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
int resultado = Convert.ToInt32(num1)+Convert.ToInt32(num2);
Console.WriteLine("La suma de "+num1+" + "+num2+" = "+resultado);

int resultado2 = Convert.ToInt32(num1)-Convert.ToInt32(num2);
Console.WriteLine("La resta de "+num1+" - "+num2+" = "+resultado2);

int resultado3 = Convert.ToInt32(num1)*Convert.ToInt32(num2);
Console.WriteLine("El producto de "+num1+" * "+num2+" = "+resultado3);