using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_again_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string[] studentArr = { "Nicat", "Ferid" };
			//string name = "Nicat";
			//int age = 21;

			//var nicatData = new { name = "Nİcat", age = 21, surname = "Rzazade" };
			//var FeridData = new { name = "Ferid", age = 20, surname = "Qedirli" };
			//Console.WriteLine(nicatData.name);
			//Console.WriteLine(nicatData.age);
			//Console.WriteLine(nicatData.surname);

			//dynamic[] studentData= {nicatData, FeridData};
			//Console.WriteLine(studentData[0].name);
			//foreach (var item in studentData)
			//{
			//	Console.WriteLine(item.surname);
			//}

			//Console.WriteLine("Telebenin adını daxil et.");
			//string nameSt = Console.ReadLine();
			//Console.WriteLine("Telebenin soyadını daxil et.");
			//string surnameSt = Console.ReadLine();
			//Console.WriteLine("Telebenin yaşını daxil et.");
			//byte ageSt = Convert.ToByte(Console.ReadLine());

			//var telebe = new { name = nameSt, age = ageSt, surname = surnameSt };
			//Console.WriteLine(telebe.name+" "+ telebe.surname + " "+telebe.age );



			dynamic[] studentList = new dynamic[0];
			int count = 0;
			while (true)
			{
				Console.WriteLine("1. Student add");
				Console.WriteLine("2. Student list");
				Console.WriteLine("3. Program close");
				Console.WriteLine("4. Search by student name ");

				int chose = Convert.ToInt32(Console.ReadLine());

				if (chose == 3)
				{
					break;
				}

				switch (chose)
				{
					case 1:
						Console.WriteLine("Telebenin adini daxil et");
						string nameSt = Console.ReadLine(); ;
						Console.WriteLine("Telebenin soyadini daxil et");
						string surnameSt = Console.ReadLine(); ;
						Console.WriteLine("Telebenin yasini daxil et");
						byte ageSt = Convert.ToByte(Console.ReadLine());

						var telebe = new { name = nameSt, age = ageSt, surname = surnameSt };
						count++;
						Array.Resize(ref studentList, count);

						studentList[count - 1] = telebe;

						Console.WriteLine("Telebe daxil edildi " + studentList[count - 1].name + " " + studentList[count - 1].surname + " " + studentList[count - 1].age);
						break;
					case 2:

						foreach (var item in studentList)
						{
							Console.WriteLine(item.name + " " + item.surname);
						}
						break;
					case 4:
						if (studentList.Length > 0)
						{
							Console.WriteLine("Axtardiginiz telebenin adini daxil edin");
							string searchSt = Console.ReadLine();
							foreach (var item in studentList)
							{
								if (item.name == searchSt)
								{
									Console.WriteLine(item.name + " " + item.surname + " " + item.age);
								}
							}
						}
						else
						{
							Console.WriteLine("Siyahida telebe yoxdur");
						}
						break;
					default:
						break;
				}
			}
		}
	}
}
