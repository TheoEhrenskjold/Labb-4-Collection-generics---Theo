using System.Reflection;

namespace Labb_4___Collection_generics___Theo
{
    internal class Program
    {
        static void Main(string[] args)
        {//I add my employees
            Employee E1 = new Employee(4586,"Stefan","male", 35000);
            Employee E2 = new Employee(8923,"Mats", "male", 29000);
            Employee E3 = new Employee(6542, "Kristin", "female", 37000);
            Employee E4 = new Employee(1050, "Ebba", "female", 45000);
            Employee E5 = new Employee(6328, "Filip", "male", 38000);

            //I create a stack and add my employees
            Stack<Employee> EmStack = new Stack<Employee>();
            EmStack.Push(E1);
            EmStack.Push(E2);
            EmStack.Push(E3);
            EmStack.Push(E4);
            EmStack.Push(E5);
            //In my foreach loop I write out all info and reduce the stack by one.
            int count = EmStack.Count;
            foreach (Employee e in EmStack)
            {
                Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", e._name, e._Id, e._gender, e._salary);
                Console.WriteLine($"Antal objekt kvar i stacken: {--count}");
            }
            Console.WriteLine("-----------------------------------------------");
            while (EmStack.Count > 0) //I found it easier to use While loops so here I add all employees back to the stack.
            {
                if (EmStack.Count > 0 )
                {
                    {
                        Employee E = EmStack.Pop();
                        EmStack.Clear();
                        Console.WriteLine("It is {0} persons left in the stack.", EmStack.Count);
                        Console.WriteLine("Let´s fill the stack again!");
                        EmStack.Push(E1);
                        Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", E1._name, E1._Id, E1._gender, E1._salary);
                        EmStack.Push(E2);
                        Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", E2._name, E2._Id, E2._gender, E2._salary);
                        EmStack.Push(E3);
                        Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", E3._name, E3._Id, E3._gender, E3._salary);
                        EmStack.Push(E4);
                        Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", E4._name, E4._Id, E4._gender, E4._salary);
                        EmStack.Push(E5);
                        Console.WriteLine("Name : {0}, ID : {1}, Gender : {2}, Salary : {3} KR", E5._name, E5._Id, E5._gender, E5._salary);
                        Console.WriteLine("The stack count is now {0}", EmStack.Count);
                        break;
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------");
            //I peek at the top of the stack and then remove the employee.
            Console.WriteLine("I peek at the top of the stack and see " +EmStack.Peek()._name);
            EmStack.Pop();
            Console.WriteLine("It is {0} obejct left in the stack.",EmStack.Count);
            Console.WriteLine("I peek at the top of the stack and see " + EmStack.Peek()._name);
            EmStack.Pop();
            Console.WriteLine("It is {0} obejct left in the stack.", EmStack.Count);

            if (EmStack.Contains(E3))
            {
                Console.WriteLine("Employee 3 exist in the stack");
            }
            else
            {
                Console.WriteLine("Employee 3 does not exist in the stack");
            }
            Console.WriteLine("--------------------------------------------------");
            //List part of the homework
            //I create my list and add the employees
            List<Employee> EmList = new List<Employee>();
            EmList.Add(E1);
            EmList.Add(E2);
            EmList.Add(E3);
            EmList.Add(E4);
            EmList.Add(E5);
            if (EmList.Contains(E2))
            {
                Console.WriteLine("Employee 2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exists in the list");
            }
            //I find the first employee with the gender "Male"
            Employee Findgender = EmList.Find(e => e._gender == "male");
            Console.WriteLine(Findgender._name + " Is the first in the list with the gender Male");
            //I find all of the employees with the gender Male.
            List<Employee> FindAllGender = EmList.FindAll(e => e._gender == "male");
            foreach (Employee em in FindAllGender)
            {
                Console.WriteLine(em._name + " Is a male");
            }
            
            Console.ReadKey();



        }
    }
}