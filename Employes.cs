class Employes
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employes(int id, string name, int salary){
        Id = id;
        Name = name;
        Salary = salary;
    }
    public void IncreaseSalary(int value) {
            Salary = Salary+value;
    }
}