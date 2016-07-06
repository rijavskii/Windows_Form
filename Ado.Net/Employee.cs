using System;

namespace Ado.Net
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0};{1}Name: {2}; {1}Birthday: {3}; {1}Email: {4};{1}Salary: {5}{1}",
                                Id, Environment.NewLine, Name, Birthday, Email, Salary);
        }
    }
}