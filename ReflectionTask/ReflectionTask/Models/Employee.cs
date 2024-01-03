namespace ReflectionTask.Models
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
