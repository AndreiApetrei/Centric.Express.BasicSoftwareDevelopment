using System;

namespace CentricExpressDemo.Polymorphism
{
    public abstract class Vehicle
    {
        public abstract void Gas();

        public virtual void SwitchGear()
        {
            Console.WriteLine("Switching in the next gear..");
        }
    }

    public class Car : Vehicle
    {
        public override void Gas()
        {
            Console.WriteLine("VRRRRRRRRRRRRRRRRRUM");
        }
    }

    public class MotorBike : Vehicle
    {
        public override void Gas()
        {
            Console.WriteLine("PRRRRRRRRRRRRRRRRRRRRRRRRRR");
        }

        public override void SwitchGear()
        {
            base.SwitchGear();
            Console.WriteLine("I'm a motorbike, so I have to push down for the first gear");
        }
    }
}