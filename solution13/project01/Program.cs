namespace project01
{
    internal class Program
    {

        ////overloading: same function but using different number of parameters
        ////write it out of main 
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static double Add(double a, double b, double c)
        //{
        //    return a * b * c;
        //}

        //static int Add(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

        //============================================
        //static void Increase(ref int x)
        //{
        //    //reference: used when I want to send prameters to function and i want change parameters , change effect in variable that I sent and the params should have initial value
        //    x =x+1;
        //}
        

        //static void Main(string[] args)
        //{
            //Console.WriteLine(Add(7, 3));
            //Console.WriteLine(Add(2.1, 9.7, 4.3));
            //Console.WriteLine(Add(2, 3, 9, 3));
            //int num = 5;
            //Increase(ref num);
            //Console.WriteLine(num);

        //}

        //--------------------------------------------------------------
        /*    Diff between reference & Out  
        _____________________________________________
                          |   ref      |    out
        ----------------------------------------------
          initial value   |   true     |   false
        ----------------------------------------------
          change value    |   may      |   must
        ----------------------------------------------
          Usage           |  change    |   Assign
                          |    exist   |    new
                          |    value   |    value
        ----------------------------------------------
       */

        // Recursion : A method that calls itself to solve a problem.

        //static void Hello()
        //{
        //      Console.WriteLine("Plz enter your age");
        //      int age = Convert.ToInt32(Console.ReadLine());

        //      if (age < 18 ) 
        //           Hello();
        //      else
        //           return;
        //}

        //static void Main(string[] args)
        //{
        //    Hello();
        //}

        //---------------------------------------------


    }
}