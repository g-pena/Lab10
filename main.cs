using System;

class Program {
  public static void Main (string[] args) {
    
    Employee unknown = new Employee();
    unknown.Intro();
    
    Employee robertdowney = new Employee("Robert","Downey","12321", 12, 100);
    robertdowney.Intro();
   
    Employee johnsmith = new Employee("John","Smith","S0089",38,50000);
    johnsmith.IncreaseSalary(-.02);
    johnsmith.RemoveEmployee();

    Employee marialambert = new Employee("Maria", "Lambert","S0100",26,80000);
    marialambert.IncreaseSalary(0.07);
    marialambert.RemoveEmployee();
    marialambert.RemoveEmployee(); 
   
    Employee willjohnson = new Employee("Will", "Johnson","15984",5,50);
    willjohnson.IncreaseSalary(0.25);
    willjohnson.RemoveEmployee();
    willjohnson.Intro();
  
  
  }
}