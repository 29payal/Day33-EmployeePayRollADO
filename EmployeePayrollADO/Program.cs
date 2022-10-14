namespace EmployeePayrollADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Employee payroll");
            EmployeeModel model = new EmployeeModel();
            EmployeeRepo repo = new EmployeeRepo();
            model.EmployeeName = "Sonu";
            model.PhoneNumber = 8887654321;
            model.Address = "Delhi";
            model.Department = "Marketing";
            model.Gender = 'M';
            model.BasicPay = 34000;
            model.Deduction = 1800;
            model.TaxablePay = 500;
            model.Tax = 600;
            model.NetPay = 2700;
            model.City = "Banglore";
            model.Country = "India";
           repo.AddEmployee(model);
          // repo.GetAllEmployee();


    }
    }
}