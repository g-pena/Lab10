using System;
class Employee {

  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

//Properties
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public int Age {
    get{ return age;}
    set{ 
      if (value >= 18)
        age=value;
      else 
        {
        age = 18;
        }

      }
    }
  public double YearlySalary 
    {
    get {return yearlysalary;}
    set {
      if (value >= 1000)
        yearlysalary = value;
      else  
          {
        yearlysalary = 1000;
          }
        } 
    }
  public string Id {get; set;}
  public string EmploymentStatus {get;set;}

  public Employee ()
    {
    FirstName = "unknown";
    LastName = "unknown";
    Id = "unknown";
    Age = 0;
    EmploymentStatus = "active";
    YearlySalary = 1000;
    }

  public Employee (string first, string last, string employeeid, int employeeage, double salary)
    {
    FirstName = first;
    LastName = last;
    Id = employeeid;
    Age = employeeage;
    EmploymentStatus = "active";
    YearlySalary = salary;
    }

  public void Intro()
    {
    Console.WriteLine("First Name: "+FirstName);
    Console.WriteLine("Last Name: "+LastName);
    Console.WriteLine("ID: "+Id);
    Console.WriteLine("Age: "+Age);
    Console.WriteLine("Employment status: "+EmploymentStatus);
    }

  public double IncreaseSalary(double percent)
    {
      if (percent >= 0)
      {
       YearlySalary = (percent*YearlySalary)+YearlySalary;
       Console.WriteLine("Yearly salary updated to "+YearlySalary);
      }
      else
      {
        Console.WriteLine("Invalid input. Yearly salary not updated.");
      }
    return YearlySalary;
    }

  public void RemoveEmployee()
  {
    if (EmploymentStatus == "active")
    {
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed successfully!");
    }

    else
    {
      Console.WriteLine("Employee already inactive.");
    }
  }

}