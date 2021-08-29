using System;


namespace AccessSpacifier
{
    public class Class1
    {
        public int publicvar = 10;
        private int privatevar = 20;
        protected int protectedvar = 30;
        internal int intrnalvar = 40;
        protected internal int protectedinternalvar = 50;

        public void publicmethod()
        {
            Console.WriteLine("This is Public Method");
            Console.WriteLine("Public Variable :" + publicvar);
            Console.WriteLine("Private Variable :" + privatevar);
            Console.WriteLine("protected Variable :" + protectedvar);
            Console.WriteLine("Internal Variable :" + intrnalvar);
            Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
        }
        private void privatemethod()
        {
            Console.WriteLine("This is private Method");
            Console.WriteLine("Public Variable :" + publicvar);
            Console.WriteLine("Private Variable :" + privatevar);
            Console.WriteLine("protected Variable :" + protectedvar);
            Console.WriteLine("Internal Variable :" + intrnalvar);
            Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
        }
        protected void protectedmethod()
        {
            Console.WriteLine("This is protected Method");
            Console.WriteLine("Public Variable :" + publicvar);
            Console.WriteLine("Private Variable :" + privatevar);
            Console.WriteLine("protected Variable :" + protectedvar);
            Console.WriteLine("Internal Variable :" + intrnalvar);
            Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
        }
        internal void intrnalmethod()
        {
            Console.WriteLine("This is intrnal Method");
            Console.WriteLine("Public Variable :" + publicvar);
            Console.WriteLine("Private Variable :" + privatevar);
            Console.WriteLine("protected Variable :" + protectedvar);
            Console.WriteLine("Internal Variable :" + intrnalvar);
            Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
        }
        protected internal void protintmeth()
        {
            Console.WriteLine("This is protected internal Method");
            Console.WriteLine("Public Variable :" + publicvar);
            Console.WriteLine("Private Variable :" + privatevar);
            Console.WriteLine("protected Variable :" + protectedvar);
            Console.WriteLine("Internal Variable :" + intrnalvar);
            Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
        }
    }
    public class Demo
    {
        Class1 c = new Class1();
        public void print()
        {
            int a = c.publicvar;
            //int b = c.privatevar; // can not access or call private method out side its classs
            //int d = c.protectedvar; ///can not access or call private method out side its classs
            int e = c.intrnalvar;
            int f = c.protectedinternalvar;
            c.publicmethod();
            c.intrnalmethod();
            c.protintmeth();
            //  c.privatemethod(); // can not access or call private method out side its classs
            //  c.protectedmethod(); //can not access or call protected methos out side its class
        }
    }
    //private class Demo1 //Can not create private class
    //{
    //    public void print()
    //    {
    //        console.writeline("this is private class");
    //    }
    //}
    //protected class demo2 // can not create protected class
    //{
    //    public void print()
    //    {
    //        console.writeline("this is protected class");
    //    }
    //}
    //internal class demo3 // can not create intrnal class
    //    public void print()
    //    {
    //        console.writeline("this is internal class");
    //    }
    //}
    //protected internal class demo4 // can not create protected intrnal class
    //{
    //    public void print()
    //    {
    //        console.writeline("this is protected internal class");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl1 = new Class1();
            cl1.publicmethod();
            //cl1.intrnalmethod(); // can not access or call private method out side its namespace
            //cl1.protintmeth();   // can not access or call private method out side its namespace
            //cl1.privatemethod(); // can not access or call private method out side its namespace
            //cl1.protectedmethod(); // can not access or call private method out side its namespace
            Demo D = new Demo();
            D.print();
        }
    }

}
