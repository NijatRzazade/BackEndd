using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_again_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Methodlar
			//continue yazdığımız reqemin üzerinden keçir
			//for(int i=0; i<10; i++)
			//{
			//	if (i == 3)
			//	{
			//		continue;
			//	}
			//	Console.WriteLine(i);
			//}


			//Break ise qırır
			//for (int i = 0; i < 10; i++)
			//{
			//	if (i == 3)
			//	{
			//		break;
			//	}
			//	Console.WriteLine(i);
			//}
			//////////////////////////////////////////////////////////

			//Console.WriteLine("Balı qeyd et:");
			//int bal= Convert.ToInt32(Console.ReadLine());
			//HelloMethod(bal);

			// Eyer davamlı bizden qiymet istemesini isteyirikse onda while(true)istifade edirik.
			//while (true)
			//{
			//	Console.WriteLine("Balı qeyd et:");
			//	int bal = Convert.ToInt32(Console.ReadLine());
			//	HelloMethod(bal);
			//}



			//HelloMethod(90);
			//HelloMethod(83);
			//HelloMethod(62);


			//while (true)
			//{
			//	Console.WriteLine("1-ci ededi daxil edin:");
			//	float x1 = (float)Convert.ToDouble(Console.ReadLine());
			//	Console.WriteLine("2-ci ededi daxil edin:");
			//	float x2 = (float)Convert.ToDouble(Console.ReadLine());
			//	Console.WriteLine("symbol daxil edin:");
			//	string symbol = Console.ReadLine();

			//	Calculate(symbol, x1, x2);
			//}

			//int toplaVar = Toplama(20, 25);
			//Console.WriteLine(toplaVar + 10);
			#endregion

			//fixed size
			int[] array = { 5, 3, 6, 91, 24, 103, 78, 1, 63 };

			//1 arrayin en boyuk    ++++++++
			//2 en kicik elementi   ++++++++
			//3 arraydeki datalarin cemi  +++++
			//4 2e bolunenleri cixar      ++++++++++++
			//5 ortalama ededi cixar       ++++++++++

			//2e bolunenleri cixar
			//foreach (int i in array)
			//{
			//	if (i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}


			//arrayin en boyuk && En kiçik
			//int maxNum = array[0];   //5
			//int maxNum = array[0];   //5
			//int minNum = array[0];   //5
			//foreach (var item in array)
			//{
			//    //if (item > maxNum)   
			//    //{
			//    //    maxNum = item;   
			//    //}
			//    if (item < minNum)
			//    {
			//        minNum = item;
			//    }
			//}
			//Console.WriteLine(minNum);

			//arraydeki datalarin cemi
			//int sum = 0;
			//foreach (int i in array)
			//{
			//	sum+= i;
			//}
			//Console.WriteLine(sum);

			//ortalama ededi cixar
			//int sum = 0;
			//foreach (var item in array)
			//{
			//	sum += item;
			//}
			//int avg = sum / array.Length;
			//Console.WriteLine("avg = " + avg);
			//Console.WriteLine(sum);

			//string data = "salam";
			//for (int i = data.Length - 1; i >= 0; i++)
			//{
			//	Console.WriteLine(data[i]);
			//}

			//azalan sıra ile
			//for (int i =10; i>0; i--)
			//{
			//	Console.WriteLine(i);
			//}

			//string data = "salam";
			//string reverse = "";
			//for (int i = data.Length - 1; i >= 0; i--)
			//{
			//	reverse += data[i];
			//	//Console.WriteLine(data[i]);
			//}
			//if (reverse == data)
			//{
			//	Console.WriteLine("Palindromdur");
			//}
			//else
			//{
			//	Console.WriteLine("Palindrom deyil");
			//}

			int[] x = { 6, 9, 18 };
			//SumArr(x);
			//SumArr(array);
			FindNumInArr(x, 9);

		}

		#region Methodlar
		public static void HelloMethod(int grade)
		{
			//Console.WriteLine("Hello Word");

			//switch (grade)
			//{
			//	case int g when (g >= 90 && g <= 100):
			//		Console.WriteLine($"Grade: {grade} - Letter Grade: A");
			//		break;
			//	case int g when (g >= 80 && g <= 89):
			//		Console.WriteLine($"Grade: {grade} - Letter Grade: B");
			//		break;
			//	case int g when (g >= 70 && g <= 79):
			//		Console.WriteLine($"Grade: {grade} - Letter Grade: C");
			//		break;
			//	case int g when (g >= 60 && g <= 69):
			//		Console.WriteLine($"Grade: {grade} - Letter Grade: D");
			//		break;
			//	default:
			//		Console.WriteLine($"Grade: {grade} - Letter Grade: F");
			//		break;
			//}
		}

		public static void Calculate(string symbol, float x1, float x2)
		{
			switch (symbol)
			{
				case "+":
					Console.WriteLine("Result :" + (x1 + x2));
					break;
				case "-":
					Console.WriteLine("Result :" + (x1 - x2));
					break;
				case "*":
					Console.WriteLine("Result :" + x1 * x2);
					break;
				case "/":
					Console.WriteLine("Result :" + x1 / x2);
					break;
				default:
					Console.WriteLine("Duzgun simbol daxil edilmeyib");
					break;

			}

		}

		public static int Toplama(int data1, int data2)
		{
			int result = data1 + data2;
			return result;
		}
		#endregion

		public static void SumArr(int[] array)
		{
			int sum = 0;
			foreach (var item in array)
			{
				sum += item;
			}
			int avg = sum / array.Length;
			Console.WriteLine("avg = " + avg);
			Console.WriteLine(sum);
		}

		public static void FindNumInArr(int[] array, int searchNum)
		{
			foreach (var item in array)
			{
				if (item == searchNum)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}