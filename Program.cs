using System;
using AccessModifierDemo;

namespace AccessSpacifier
{
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
