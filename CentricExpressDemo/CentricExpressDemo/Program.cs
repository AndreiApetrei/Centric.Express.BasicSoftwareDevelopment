using System;
using System.Collections.Generic;
using CentricExpressDemo.Polymorphism;

namespace CentricExpressDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            #region abstract example

            ////var vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle bike = new MotorBike();

            car.Gas();
            bike.Gas();

            car.SwitchGear();
            bike.SwitchGear();
            Console.WriteLine();
            #endregion

            #region override virtual new
            Singer bariton = new Bariton();
            bariton.Sing();

            Singer tenor = new Tenor();
            tenor.Sing();
            Console.WriteLine();

            #endregion

            #region avoid if else
            List<Employee> employees = new List<Employee>{ new Developer(), new Tester(), new Manager(), new Developer()};
            foreach (var employee in employees)
            {
                var sallary = employee.GetSallary();
                if (employee is Tester)
                {
                    sallary *= 1.5;
                } else if (employee is Developer)
                {
                    sallary *= 2;
                } else if (employee is Manager)
                {
                    sallary *= 10;
                }
                Console.WriteLine("{0} sallary: {1}", employee.ToString(), sallary);
            }
            Console.WriteLine();

            #endregion
        }
    }
}
