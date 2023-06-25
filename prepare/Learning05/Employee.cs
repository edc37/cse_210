using System;
namespace Employees
{
    public abstract class Employee
    {
        /*private float salary = 100f;

        public virtual float CalculatePay()
        {
            return salary;
        }*/
        private string _employeeName;

        /* Notive the abstract method doesn't have a 
        body at all (not even an empty one) and
        it is followed by a semicolon */
        public abstract float CalculatePay();
    }
}