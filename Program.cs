namespace EmployeePayRollAdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to Employee payroll");

            EmployeeModel model = new EmployeeModel();
            EmployeeRepo repo = new EmployeeRepo();

            model.EmployeeName = "rita";
            model.PhoneNumber = 12347676880;
            model.Address = "Chanai";
            model.Department = "Production";
            model.Gender = 'F';
            model.BasicPay = 28000;
            model.Deduction = 1800;
            model.TaxablePay = 500;
            model.Tax = 700;
            model.NetPay = 2800;
            model.City = "Chanai";
            model.Country = "India";

            repo.AddEmployee(model);
            repo.GetAllEmployee();

            repo.GetAllEmployee();
            DataBaseFunction data = new DataBaseFunction();
            data.SumFunction();
            data.AvgFunction();
            data.MinFunction();
            data.MaxFunction();
            //data.CountFunction()
        }
    }
}