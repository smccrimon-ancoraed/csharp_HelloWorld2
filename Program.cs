using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApplication
{
    class HelloWorld2
    {

        String name;
     

        public HelloWorld2()
        { }


        public HelloWorld2(String v)
        {
            name = v;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String aname)
        {
            name = aname;
        }


        public override string ToString()
        {
            return "Hello " + name+ "! Welcome to C#";
        }


        static void Main(String[] args)
        {

            HelloWorld2 student1 = new HelloWorld2();
            Console.WriteLine(student1.getName());
            student1.setName("Kenya beans");
            Console.WriteLine(student1.getName());


            HelloWorld2 student2 = new HelloWorld2("Coffee");
            Console.WriteLine(student2.getName());

            Console.WriteLine("1st Student: " + student1.getName() + " and 2nd Student: " + student2.getName());

            if (args.Length == 1)
            {
                HelloWorld2 memyselfi = new HelloWorld2(args[0]);
                Console.WriteLine(memyselfi);
            }

            Console.ReadKey();


        }
    }
}
