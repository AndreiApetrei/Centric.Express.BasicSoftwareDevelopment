using System;

namespace CentricExpressDemo.Polymorphism
{
    public abstract class Singer
    {
        public virtual void Sing()
        {
            Console.WriteLine("I'm singing..");
        }
    }

    public class Bariton : Singer
    {
        public override void Sing()
        {
            Console.WriteLine("I'm singing in low pitch..");
        }
    }

    public class Tenor : Singer
    {
        public new void Sing()
        {
            Console.WriteLine("I'm singing in low pitch..");
        }
    }
}