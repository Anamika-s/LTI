using System; 
class Employee 
 { 
     int id;
     string name;
     public void Get()
     { 
      Console.Write("Enter ID");
      id = int.Parse(Console.ReadLine());
      Console.Write("Enter Name");
      name = Console.ReadLine();
     }
     public void Display()
     { 
      Console.Write("ID is " + id);
      Console.Write("Name is " + name);
     }
}
class PartTimeEmployee 
 { 
     string projectName;
     public void Get()
     { 
     
      Console.Write("Enter projectName");
      projectName = Console.ReadLine();
     }
     public void Display()
     { 
      
      Console.Write("projectName is " + projectName);
     }
}
 class FullTimeEmployee 
 { 
     string manager;
     public void Get()
     { 
     
      Console.Write("Enter Manager");
      manager = Console.ReadLine();
     }
     public void Display()
     { 
      
      Console.Write("Manager is " + manager);
     }
}
 
 class Program
{
 static void Main()
{
   Employee emp = new Employee();
   emp.Get();
   emp.Display();
}
}      