using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_again_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int x = 15;
			//int y = x;
			//         Console.WriteLine("x "+ x);
			//Console.WriteLine("y " + y);
			//x = 20;
			//Console.WriteLine("x " + x);
			//Console.WriteLine("y " + y);

			//int[] arr= {2, 3,5,8,9};
			//int[] arr2= arr;
			//Console.WriteLine(arr[0]);
			//Console.WriteLine(arr2[0]);
			//arr[0] = 30;
			//Console.WriteLine(arr[0]);
			//Console.WriteLine(arr2[0]);


			//Casting
			//Upcast and Downcast
			//Casting value typelar arsında gedir.
			//Upcast
			//byte data = 15;   
			//int bigData = data;

			//Downcast burda mütleq data itkisi olur.
			//int intData = 100; 
			//byte smallData = (byte) intData;  //byte max deyeri 256 
			//Console.WriteLine(smallData);

			//int intData2 = 300;
			//byte smallData2 = (byte)intData;   
			//Console.WriteLine(smallData);   //300-256=44

			//double dbl = 109.22;
			//int i = (int)dbl;
			//Console.WriteLine(i);

			Calculate(2.5,2.5);

            Console.WriteLine(Math.Ceiling(2.999999999999));

			string name = "salam";
			Console.WriteLine(name.ToUpper());

			string data = " ";
			IsNullOrEmpty(data);
        }
		public static void IsNullOrEmpty(string data)
		{
			if (data.Length == 0)
			{
				Console.WriteLine("nulldir");
			}
			else
			{
				Console.WriteLine("null deyil");
			}
		}

		public static int Calculate(int num1,int num2)
		{
			int result=num1+num2;
            Console.WriteLine(result);
            return result;
		}
		public static double Calculate(double num1, double num2)
		{
			double result = num1 + num2;
			Console.WriteLine(result);
			return result;
		}
		public static double Calculate(int num1, double num2)
		{
			double result = num1 + num2;
			Console.WriteLine(result);
			return result;
		}
		public static double Calculate(int num1, double num2,double num3)
		{
			double result = num1 + num2;
			Console.WriteLine(result);
			return result;
		}
		//Overload nedir?
		//1.Eyni adli method return type gore ferqlidirse
		//2.Parametr sayi ferqli
		//3 Parametr tipi

	}
}
