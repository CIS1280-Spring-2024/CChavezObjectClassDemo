//  Program name: CchavezObjectClassDemo

//  Programed by: Colby Chhavez
//  Contact Email: cchavez572@cnm.edu
//  
//  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        //  3.1.	Change main to:
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Inigo";
            emp.LastName = "Montoya";
            Console.WriteLine("\nPaysummery" + emp.PaySummary);
            Console.WriteLine("\nemp: " + emp);
            Console.WriteLine("\nemp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("\nemp.GetType: " + emp.GetType());
            Console.WriteLine("\nemp.ToString: " + emp.ToString());

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Tyrone";
            hourEmp.LastName = "Rugen";
            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine($"\n\n{hourEmp.FirstName} {hourEmp.LastName} Pay summery {hourEmp.PaySummary}");
            Console.WriteLine($"\n{hourEmp.FirstName} {hourEmp.LastName} hourEmp: {hourEmp}");
            Console.WriteLine($"\n{hourEmp.FirstName} {hourEmp.LastName} hourEmp.GetHashCode: {hourEmp.GetHashCode()}");
            Console.WriteLine($"\n{hourEmp.FirstName} {hourEmp.LastName} hourEmp.GetType: {hourEmp.GetType()}");
            Console.WriteLine($"\n{hourEmp.FirstName} {hourEmp.LastName} hourEmp.ToString: {hourEmp.ToString()}");

            //  3.1.1.Notice that the members we are writing to the console are not defined in the classes we wrote. They come from the object class!
            //  3.2.	Run the program with Ctrl-F5:
            //  3.3.Notice that ToString() returns the same thing as GetType().


            //  5.1.Add the following code
            //Boxing
            Object athing = hourEmp;
            Console.WriteLine("\nathing hourEmp.ToString: " + athing);
            //  5.2.Run the program and notice that athing displays HourlyEmployee’s ToString.
            //  5.3.Type athing.and look at the intellisence drop down:
            //  5.4.Noticet that FirstName and LastName do not appear. This is because athing is just an object and the object class does not have those properties.But we know that athing is storing that data.
            //  5.5.	How can we access the HourlyEmployee data in athing?
            //  5.6.Add the following code
            //Unboxing
            //  HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
            //  var unboxeHourlyRate = unboxedEmp.HourlyRate;
            //  Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            //  5.7.Run it and notice that unboxedEmp does give us access to the data that athing doesn’t.
            //  5.8.The cast operation(HourlyEmployee) is called unboxing.
            //  .It is dangerous to unbox an object if you are not sure of it’s type.
            //  5.10.Try the following code:
            //Unboxing
            //  SalaryEmployee unboxedEmp = (SalaryEmployee)athing;
            //  Console.WriteLine("\nUnboxed First Name: " + unboxedEmp.FirstName);

            if (athing is HourlyEmployee)
            {
                HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
            }
            else if (athing is Employee) 
            {
                Employee unboxedEmp = (Employee)athing;
                Console.WriteLine($"UnboxedEmp: {unboxedEmp.FirstName} {unboxedEmp.LastName} " +
                    $"does not yet have a pay method");
            }
            Console.Write("\nPress any key to continue");
            Console.ReadLine();

        }

    }
}
