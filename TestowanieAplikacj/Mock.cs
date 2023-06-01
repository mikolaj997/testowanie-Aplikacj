using System;
namespace TestowanieAplikacj
{
    public class Mock: IMock, IMock1 , IMock2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Devide(int a, int b)
        {
            return a / b;
        }
        public int Power(int a, int b)
        {
            return a ^ b;
        }

    }
    public interface IMock
    {
        int Add(int a, int b);
    }
    public interface IMock1
    {
        int Devide(int a, int b);
    }
    public interface IMock2
    {
        int Power(int a, int b);
    }
}

