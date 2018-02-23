namespace CentricExpressDemo.Polymorphism
{
    public abstract class Employee
    {
        private readonly int sallary = 1500;

        public double GetSallary()
        {
            return sallary;
        }
    }

    public class Developer : Employee
    {
        
    }

    public class Tester : Employee
    {
        
    }

    public class Manager : Employee
    {
        
    }
}