// See https://aka.ms/new-console-template for more information


namespace DelegatesMatematica;

class Program
{
    
    public delegate double Operacao(double a, double b);
    
    static void Main()
    {
        
        // passo aqui a função que quero que seja executada
        Operacao op = new Operacao(Somar);
        //ou Operacao op = Somar;
        Console.WriteLine(op(3, 2));
        
        op = Multiplicar;
        Console.WriteLine(op(3, 2));
        
        op = Diminuir;
        Console.WriteLine(op(3, 2));
        
        //ou
        
        Operacao op2 = delegate(double a, double b)
        {
            return a / b;
        };
        
        Console.WriteLine(op2(3, 2));
        
        //ou
        
        int area = calculaArea(5, 4); // área = 20
        
        Console.WriteLine("Área do retângulo: " + area);
        
        Action<string> saudacao = nome => Console.WriteLine("Olá, " + nome + "!");
        saudacao("Patrick"); // Saída: "Olá, Patrick!"
        
    }
    
    
    static Func<int, int, int> calculaArea = (largura, altura) =>
    {
        Console.WriteLine("Calculando área do retângulo...");
        return largura * altura;
    };
    
    static double Somar(double a, double b)
    {
        var resultado = a + b;
        Console.WriteLine("Somar: " + resultado);
        return resultado;
    }
    
    static double Multiplicar(double a, double b)
    {
        var resultado = a * b;
        Console.WriteLine("Multiplicação: " + resultado);
        return resultado;
    }
    
    static double Diminuir(double a, double b)
    {
        var resultado = a - b;
        Console.WriteLine("Subtração: " + resultado);
        return resultado;
    }
}