using ReflectionTask.CustomAttributes; 

namespace ReflectionTask.Models
{
    public class Employee
    {
        [MapHtmlData("name")]
        public string Name { get; set; }

        [MapHtmlData("age")]
        public int Age { get; set; }

        [MapHtmlData("PolNumber")]
        public string PolicyNumber { get; set; }

        [MapHtmlData("Salary")]
        public int Salary { get; set; }

        [MapHtmlData("Occupation")]
        public string Occupation { get; set; }

        [MapHtmlData("ProductCode")]
        public string ProductCode { get; set; }

        public Employee() { }

        public Employee(string Name, int Age, string PolicyNumber, int Salary, string Occupation, string ProductCode)
        {
            this.Name = Name;
            this.Age = Age;
            this.PolicyNumber = PolicyNumber;
            this.Salary = Salary;
            this.Occupation = Occupation;
            this.ProductCode = ProductCode;
        }
    }
}
