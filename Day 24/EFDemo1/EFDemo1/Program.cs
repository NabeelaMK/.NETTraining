using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FETCHING THE DETAILS PRESENT IN CORRESPONDING TABLE

            ExercisesDBEntities e1 = new ExercisesDBEntities();
            foreach(var item in e1.DEPARTMENTS)
            {
                Console.WriteLine(item.department_name);
            }

            //ADDING DETAILS

            /* using(var context = new ExercisesDBEntities())
             {
                 var emp = new EMPLOYEE()
                 {
                     first_name = "Bill",
                     last_name = "Gates"
                 };
                 context.EMPLOYEES.Add(emp);
                 context.SaveChanges();
             }*/

            /* using (var context = new ExercisesDBEntities())
             {
                 var emp1 = new EMPLOYEE()
                 {
                     employee_id = 2000,
                     first_name="Raju",
                     last_name="Rajan",
                     email="rajurajan123@gmail.com",
                     phone_number=2345678,
                     salary=150000,
                     commision_pct=6
                 };
                 context.EMPLOYEES.Add(emp1);
                 context.SaveChanges();
             }*/

            //DELETE THE FIRST ROW

            /* using (var context = new ExercisesDBEntities())
             {
                 var emp = context.EMPLOYEES.First<EMPLOYEE>();
                 context.EMPLOYEES.Remove(emp);

                 context.SaveChanges();
             }*/

            //UPDATE THE FIRST ROW

            /* using (var context = new ExercisesDBEntities())
             {
                var emp = context.EMPLOYEES.First<EMPLOYEE>();
                 emp.first_name = "Steve";
                 emp.last_name = "Jobs";
                context.SaveChanges();
             }*/

            //UPDATING AN EXISTING ROW USING LINQ

            /*using (var context = new ExercisesDBEntities())

            {
                var query = context.EMPLOYEES
                    .Where(s=>s.first_name =="Bada")
                    .FirstOrDefault<EMPLOYEE>();
                query.first_name = "Chotta";
                context.SaveChanges();
            }*/

            using (var context = new ExercisesDBEntities())

            {
                var query = context.EMPLOYEES
                    .Where(s => s.employee_id == 2004)
                    .FirstOrDefault<EMPLOYEE>();
                query.first_name = "Adam";
                context.SaveChanges();
            }
        }
    }
}
