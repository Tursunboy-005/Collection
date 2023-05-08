using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int, string> person = new Person<int, string>();
            
            
        }
    }
}

class Person <T,K>
{
    public T Id { get; set; }
    public string Name { get; set; }

    //public T Calculate(KeyNotFoundException param)
    //{
    //    return Id;
    //}
    public bool IsEquel(K a,K b)
    {
        return a.Equals(b);
    }
}

class MyIdClass
{

}

