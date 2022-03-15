using System;
namespace assignment
{
    public class Program{

        static void methodCalled(object sender, string functionName){
            Console.WriteLine("{0} method called",functionName);
        }
        static void Main(string[] args){
            int Id = 0;
            string Name = "";
            string DepartmentName = "";
            Employee emp;
            
                Console.WriteLine("Enter Your ID: ");
                Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Name: ");
                Name = Console.ReadLine();
                if(String.IsNullOrEmpty(Name)){
                    throw new ArgumentException("Name can't be empty");
                }

                Console.WriteLine("Enter Your Department Name: ");
                DepartmentName = Console.ReadLine();
                if(String.IsNullOrEmpty(DepartmentName))
                {
                    throw new ArgumentException("DepartmentName Name can't be empty");
                }
                emp = new Employee(Id,Name,DepartmentName);
                emp.getDetailsCalled += methodCalled;
                Console.WriteLine("Your ID: {0}",emp.getId());
                Console.WriteLine("Your Name:{0}",emp.getName());
                Console.WriteLine("Your DepartmentName:{0}",emp.getDepartmentName());
                emp.update(12,"kapil","IT");
                System.Console.WriteLine(emp.getId());
                System.Console.WriteLine(emp.getName());
                System.Console.WriteLine(emp.getDepartmentName());
                
            }   
        }
}
