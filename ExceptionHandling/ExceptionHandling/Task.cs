using System;
using System.IO;

namespace Task1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PolicyNumber { get; set; }

        public int Salary { get; set; }
        public string Occupation { get; set; }
        public string ProductCode { get; set; }
        public DateTime ExpiryDate { get; set; }

    }

    public class Task
    {

        public static void AddDataToFile()
        {
            string path = @"C:\Users\ayush\Desktop\htmldata.txt";
            Employee e = new Employee();

            e.Name = "Ayush";
            e.Age = 23;
            e.PolicyNumber = "123456";
            e.Occupation = "SDE";
            e.ProductCode = "DS1";
            e.Salary = 35000; 

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