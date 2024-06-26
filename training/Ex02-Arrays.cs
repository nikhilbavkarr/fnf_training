using System;
namespace sampleConApp{
    class ArraysExample{
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter the size of array");
            int size=int.Parse(Console.ReadLine());

            int [] elements =new int[size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Enter the values at positions {0}", i);
                elements[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("all the values are set");
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }*/
            creatingArrayAtRuntime();
        }

        static void creatingArrayAtRuntime(){
            Console.WriteLine("Enter the Array size");
            int size=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS type for the type do array");
            Type arrayType=Type.GetType(Console.ReadLine());
            if(arrayType==null)
            {
                Console.WriteLine("Not a Valid Data Type of .NET");
                return;
            }
            Array array = Array.CreateInstance(arrayType,size);
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Enter the values for the position{0} of the type {1}", i, arrayType.FullName);
                object value=Convert.ChangeType(Console.ReadLine(),arrayType);
                array.SetValue(value,i);
            }
            Console.WriteLine("All the Values are set, Lets Read them");
            foreach(var item in array)
                Console.WriteLine(item);
        }
    }
}