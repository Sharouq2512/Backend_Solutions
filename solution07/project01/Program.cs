namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Error Type
            //Sentax error ( code will not run until fix it )
            // runtime error ( happen when run the code (exception) ,not logical method )
            //Logical error (output not the result I want it but the codes correct)
            //compilation time error ( syntax error,Wrong data type ,Missing semicolon ,
            //Undeclared variable ,Method not found ,argument/parameter mismatch)
            //indentation(محاذاه يعني الاسطر و المسافات )
            #endregion

            //---------------------------------------------
            #region Error handling
            //dividing by 0 exception
            // null reference exception
            try
            {
                Console.WriteLine("Enter number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //-----------------------
                int number = int.Parse("sharouq");
                String name = null;

            }
            catch
            {
                Console.WriteLine("Error has been shown");
            }
            finally
            {
                Console.WriteLine("no error");
            }
            #endregion


            int say(int x, int y)
            {
                return x + y;
            }
            say(23);
        }

    }
}
