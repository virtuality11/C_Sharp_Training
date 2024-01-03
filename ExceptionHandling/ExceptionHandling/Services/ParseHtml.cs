using ParsingHtml.Models;

namespace ParsingHtml.Services
{
	public class ParseHtml
	{

		public static void AddDataToFile(Employee e)
		{
			string path = @"C:\Users\ayush\Desktop\htmldata.txt";

			string[] data = File.ReadAllLines(path);

			for (int i = 0; i<data.Length; i++)
			{
				int pos = data[i].IndexOf("{{");
				if (pos == -1) continue;

				string prop = "";
				pos += 2;

				while (data[i][pos] != '}')
				{
					prop += data[i][pos++];
				}


				if (prop == "Name")
				{
					data[i] =  data[i].Replace("{{" + prop + "}}", e.Name);
					Console.WriteLine(e.Name);
				}

				else if (prop == "Age")
				{
					data[i] = data[i].Replace("{{"+ prop + "}}", e.Age.ToString());
				}
				else if (prop == "Occupation")
				{
					data[i] = data[i].Replace("{{"+ prop + "}}", e.Occupation);
				}

				else if (prop == "Salary")
				{
					data[i] = data[i].Replace("{{"+ prop + "}}", e.Salary.ToString());
				}

				else if (prop == "PolicyNumber")
				{
					data[i] = data[i].Replace("{{"+ prop + "}}", e.PolicyNumber);
				}
				else if (prop == "ProductCode")
				{
					data[i] = data[i].Replace("{{"+ prop + "}}", e.ProductCode);
				}

			}
			File.WriteAllLines(path, data);

		}
	}
}
