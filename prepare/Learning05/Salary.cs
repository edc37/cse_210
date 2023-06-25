using System;
namespace Employees
{
    public class SalaryEmployee : Employee
    {
        /*private float _salary = 0;

        public float GetSalary()
        {
            return _salary;
        }
        void SetSalary(float salary)
        {
            _salary = salary;
        }*/

        private float salary = 100f;
        public override float CalculatePay()
        {
            return salary;
        }
    }
}