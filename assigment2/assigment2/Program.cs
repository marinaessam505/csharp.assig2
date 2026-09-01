namespace assigment2
{

    #region Question 1

    //class Program
    //{
    //    static void Main()
    //    {


    //        string Text = "464";
    //        int pages = Convert.ToInt32(Text);

    //        Console.WriteLine(pages);


    //    }
    //}
    #endregion


    #region Question 2

    class Program
    {
        static void Main()
        {
            //PART ONE MN ALSO2AL
            string yearText = "2023";
            int year = int.Parse(yearText);

            Console.WriteLine(year);

             // PART TWO

            string badText = "abc";
            int number;

            if (int.TryParse(badText, out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }

    #endregion






}
