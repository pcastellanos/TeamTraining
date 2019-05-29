namespace CSharpEight
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            string[] urls = {"http://localhost/sitetest/page1.html", "http://localhost/sitetest/page2.html"};
            Console.WriteLine("C Sharp 8.0");

            DefaultInterface();

            await AsyncStreams(urls);

            Console.WriteLine(SwitchExpression(2));

            RangeFeature();

            Console.ReadLine();
        }


        private static void NullableReferenceTypeMethod()
        {
            string? name = null;
        }

        private static void DefaultInterface()
        {
            IAnimal dog = new Dog();
            var dog2 = new Dog();
            IAnimal cat = new Cat();
            Cat cat2 = new Cat();
            Console.WriteLine(dog.EmitSound());
            Console.WriteLine(dog.Wee());
            Console.WriteLine(dog2.Wee());
            Console.WriteLine(cat.EmitSound());
            Console.WriteLine(cat.Wee());
            //Console.WriteLine(cat2.Wee()); this shows an error due to cat 2 hasn't implemented wee default method
        }

        private static string SwitchExpression(int opt)
        {
            string message;

            switch (opt)
            {
                case 1:
                    message = "one";
                    break;
                case 2:
                    message = "two";
                    break;
                case 3:
                    message = "three";
                    break;
                default:
                    message = "Undefined";
                    break;
            }

            string ordinal = opt switch

            {
                1 => "first",
                2 => "second",
                3 => "third",
                _ => "undefined"
            }
            ;

            Console.WriteLine(ordinal);

            return message;
        }

        private static async Task AsyncStreams(string[] urls)
        {
            await foreach (var content in GetContent(urls)) Console.WriteLine(content);
        }

        private static async IAsyncEnumerable<string> GetContent(string[] urls)
        {
            var client = new HttpClient();

            foreach (var url in urls) yield return await client.GetStringAsync(url);
        }

        private static void RangeFeature()
        {
            int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Range rangex = ^2..^0;
            Range rangey = 2..4;
            Range rangez = ..^2;
            Range rangew = 1..;
            int[] slice = array[rangew];

            for (var i = 0; i < slice.Length; i++) Console.WriteLine(slice[i]);
        }
    }
}