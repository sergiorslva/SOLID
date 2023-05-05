namespace SOLID.SRP.Violation
{
    
    //Nesse exemplo temos a classe employee assumindo a responsabilidade de calcular pagamento,
    //calcular horas e persistir o employee. Logo está assumindo responsabilidades de diferentes atores, por exemplo:
    //CalcutePay é uma responsabilidade do ator CFO.
    //ReportHours é uma responsabilidade do ator COO.
    //Save é uma responsabilidade do ator CTO



    public class EmployeeViolation
    {
        public decimal CalcutePay(int employeeId)
        {         
            return 0;
        }

        public decimal ReportHours(int employeeId)
        {            
            return 0;
        }

        public void Save(EmployeeModel employee)
        {
        }
    }
}
