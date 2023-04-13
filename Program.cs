using System.Collections.Generic;

namespace exercicioaula5;
class Program
{
    static void Main(string[] args)
    {
        List<Employes> employeslist = new List<Employes>();


        Console.Write("how many employees will be registered ? ");
        int n = int.Parse(Console.ReadLine());

         for(int i=0; i < n; i++){
            
        Console.Write("Employee ID: ");
            int id = int.Parse(Console.ReadLine());
        Console.Write("Employee name : ");
            string name = Console.ReadLine();
        Console.Write("Employee salary: ");
            int salary = int.Parse(Console.ReadLine());
            employeslist.Add(new Employes(id,name,salary));
        }
        foreach (Employes obj in employeslist)
        {
            Console.WriteLine("id : " +obj.Id + " - Name : " + obj.Name + " - Salary : " + obj.Salary);
        }

        Console.WriteLine("to increase salary type 1 if you dont type 0");
        string option = Console.ReadLine();
        
        if(option == "1"){
            Console.WriteLine("type the Employee id : ");
            int idtosearch = int.Parse(Console.ReadLine());
            Employes v = employeslist.Find(x => x.Id == idtosearch);
            Console.WriteLine("type the value to increase (this operation will sum the salary to the value) : ");
            int value = int.Parse(Console.ReadLine());
            v.IncreaseSalary(value);
        }
        else
        {
            Console.WriteLine("program exit...");
        }
        foreach (Employes obj in employeslist)
        {
            Console.WriteLine("id : " +obj.Id + " - Name : " + obj.Name + " - Salary : " + obj.Salary);
        }
    }
}
