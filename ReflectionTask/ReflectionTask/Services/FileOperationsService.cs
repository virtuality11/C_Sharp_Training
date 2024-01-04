using System.Reflection;
using ReflectionTask.Models;

namespace ReflectionTask.Services
{
    public class FileOperationsService
    {
        public static void PopulateDataToFile<T> (T classobj) where T : class
        {
            string path = @"C:\Users\ayush\Desktop\htmldata.txt";

            string[] data = File.ReadAllLines(path);

            Type t = classobj.GetType();
            PropertyInfo[] props = t.GetProperties();

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

                foreach (PropertyInfo pi in props)
                {
                    if (pi.Name == prop)
                    {
                        data[i] = data[i].Replace("{{" + prop + "}}", pi.GetValue(classobj).ToString());
                        break;
                    }
                }
            }

            File.WriteAllLines(path, data);
        }
    }
}
