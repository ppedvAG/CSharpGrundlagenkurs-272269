namespace SingleResponsibilityPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class BadEmployee
    {
        //Aufgabe 1: Die Struktur des Employee (Beschreibung) 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        //Datenbank-Operationen (CRUD = Create, Read, Update, Delete)
        public void CreateEmployeeInDB()
        {
            //Speichert Mitarbeiter in Datenbank 
        }

        public void UpdateEmployeeInDB()
        {
            //Updated Mitarbeiter in Datenbank
        }

        //Workflows (ServiceLayer): Erstellen eines Berichtes
        public void CreateMitarbeiterReport()
        {
            //Erstellt einen Mitarbeiterreport
        }


        //Anzeige eines Mitarbeiter an der Oberflächte (UI)
        public void ShowEmployeeDetailView()
        {
            //Zeige an der Oberfläche die Mitarbeiter an. 
        }
    }


    public class Employee
    {
        //Aufgabe 1: Die Struktur des Employee (Beschreibung) 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    //Ein Repository kümmert sich um EINE Tabelle
    public class EmployeeRepository
    {
        //Datenbank-Operationen (CRUD = Create, Read, Update, Delete)
        public void CreateEmployeeInDB(Employee employee)
        {
            //Speichert Mitarbeiter in Datenbank 
        }

        public void UpdateEmployeeInDB(int id, Employee modifiedEmployee)
        {
            //Updated Mitarbeiter in Datenbank
        }

        public void DeleteEmployeeInDB(int id)
        {
        }

        //public Employee GetById(int id) 
        //{
        //    return new Employee(); 
        //}

        //public List<Employee> GetAll()
        //{

        //}
    }


    public class EmployeeService
    {
        public void GenerateReport(Employee em)
        {
            //Erstelle ein Report
        }
    }

    public class EmployeeDetailView
    {
        public void Show(Employee employee)
        {
            //Zeige den Mitarbeiter an.
        }
    }
}
