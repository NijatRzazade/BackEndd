using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_3_again_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string name = "Eli";
			//int x = 15;
			//string[] BackEnd118 = { "Ferid", "R.Nicat", "H.Nicat", "Metanet" };
			//int[] numbers = { 3, 7, 9, 2, 1, 6, 5 };
			//Console.WriteLine(BackEnd118); Sehv
			//for loop
			//foreach(var x in BackEnd118 )
			//{
			//	Console.WriteLine(x);
			//}

			//Console.WriteLine(BackEnd118[1]); // 5 nefer var
			//Console.WriteLine(BackEnd118.Length); // 4 nefer var

			// Sonuncu index ekrana çıxarmaq istesek
			//Console.WriteLine(BackEnd118 [BackEnd118.Length-1]);

			// For
			//for (int i = 0; i<BackEnd118.Length; i++)
			//{
			//	Console.WriteLine(i); // Sayını çıxarır
			//	Console.WriteLine(BackEnd118[i]); //Adları çıxarır
			//}

			//for (int i = 2; i < 4; i++)
			//{
			//	Console.WriteLine(i); 
			//	Console.WriteLine(BackEnd118[i]); 
			//}

			//string data = "Nicat";
			//if (data.Length == 0)
			//{
			//	Console.WriteLine("Düzdür");
			//}
			//else
			//{
			//	Console.WriteLine("Sehvdir");
			//}

			//foreach(var item in BackEnd118)
			//{
			//	if (item == "Eli")
			//	{
			//		Console.WriteLine("Bu qrupda Eli adında telebe var");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Bu qrupda Eli adında telebe yoxdur");
			//	}
			//}

			//int count = 0;
			//foreach (var item in BackEnd118)
			//{
			//	if (item == "Eli")
			//	{
			//		count++;
			//		Console.WriteLine("Bu qrupda Eli adında telebe var");
			//	}
			//}
			//Console.WriteLine(count);
			//if (count == 0)
			//{
			//	Console.WriteLine("Bu qrupda Eli adında telebe yoxdur");
			//}


			// + - * /
			//Console.WriteLine("1-ci ededi daxil et:");
			//float x1 = (float)Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("2-ci ededi daxil et:");
			//float x2 = (float)Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("symbol daxil et:");
			//string symbol = Console.ReadLine();

			//if (symbol == "+")
			//{
			//	Console.WriteLine("Resault: " +x1 + x2);
			//}
			//else if (symbol == "-")
			//{
			//	Console.WriteLine("Resault: " + (x1 - x2));
			//}
			//else if (symbol == "*")
			//{
			//	Console.WriteLine("Resault: " + x1 * x2);
			//}
			//else if (symbol == "/")
			//{
			//	Console.WriteLine("Resault: " + x1 / x2);
			//}
			//else
			//{
			//	Console.WriteLine("Düzgün symbol daxil edilmeyib");
			//}

			//double doubleX = 1D / 3;
			//float floatX = 1F / 3;
			//decimal decimalX = 1M / 3;
			//Console.WriteLine(floatX);
			//Console.WriteLine(doubleX);
			//Console.WriteLine(decimalX);


			//Console.WriteLine("1-ci ededi daxil et:");
			//float x1 = (float)Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("2-ci ededi daxil et:");
			//float x2 = (float)Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("symbol daxil et:");
			//string symbol = Console.ReadLine();

			//switch (symbol)
			//{
			//	case "+":
			//		Console.WriteLine("Result :" + x1 + x2);
			//		break;
			//	case "-":
			//		Console.WriteLine("Result :" + (x1 - x2));
			//		break;
			//	case "*":
			//		Console.WriteLine("Result :" + x1 * x2);
			//		break;
			//	case "/":
			//		Console.WriteLine("Result :" + x1 / x2);
			//		break;
			//	default:
			//		Console.WriteLine("Duzgun simbol daxil edilmeyib");
			//		break;
			//}

			DayOfWeek tarix = DateTime.Now.DayOfWeek;

			const double pi = 3.14;


			switch (tarix.ToString())
			{
				case "Tuesday":
					Console.WriteLine("Cersenbe axsami");
					break;
				case "Monday":
					Console.WriteLine("Bazar ertesi");
					break;

				default:
					Console.WriteLine("Bele heftenin gunu yoxdur");
					break;
			}
		}
	}
}
