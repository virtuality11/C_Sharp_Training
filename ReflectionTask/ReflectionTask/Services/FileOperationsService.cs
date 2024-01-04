using System.Reflection;
using ReflectionTask.Models;
namespace ReflectionTask.Services
{
    public class FileOperationsService
    {
        public static void PopulateDataToFile<T>(T classobj, string path) where T : class
        {
            string data = File.ReadAllText(path);

            Type t = classobj.GetType();
            PropertyInfo[] props = t.GetProperties();

            foreach (PropertyInfo pi in props)
            {
                data = data.Replace("{{" + pi.Name + "}}", pi.GetValue(classobj).ToString());
            }

            File.WriteAllText(path, data);
        }
    }
}
