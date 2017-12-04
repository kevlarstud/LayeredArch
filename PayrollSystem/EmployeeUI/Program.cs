using System;
using System.Reflection;
using EmpEnt;
using EMPUtility;
namespace EmployeeUI
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static bool ValidateEmployee(EmpBEntity employee)
        {
            PropertyInfo[] properties = employee.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                object[] customAtt = property.GetCustomAttributes(typeof(IAttributes), true);

                foreach (object att in customAtt)
                {
                    IAttributes valAtt = (IAttributes)att;
                    if (valAtt == null) continue;

                    if (valAtt.IsValid(property.GetValue(employee, null))) continue;
                    ErrorMessage error = new ErrorMessage(property.Name, valAtt.message);
                    employee.ErrorList.Add(error);

                }

            }

            return (employee.ErrorList.Count == 0);

        }
    }
}
