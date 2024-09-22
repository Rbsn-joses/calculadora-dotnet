﻿public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public double Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return (double)a / b;
    }
}