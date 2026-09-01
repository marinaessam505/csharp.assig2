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

    //class Program
    //{
    //    static void Main()
    //    {
    //        //PART ONE MN ALSO2AL
    //        string yearText = "2023";
    //        int year = int.Parse(yearText);

    //        Console.WriteLine(year);

    //         // PART TWO

    //        string badText = "abc";
    //        int number;

    //        if (int.TryParse(badText, out number))
    //        {
    //            Console.WriteLine(number);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid number");
    //        }
    //    }
    //}

    #endregion



    #region Question 3

    //class Program
    //{
    //    static void Main()
    //    {
    //        int pages = 464;

    //        string pagesText = pages.ToString();

    //        Console.WriteLine(pagesText);
    //        Console.WriteLine(pagesText.GetType());
    //    }
    //}

    #endregion



    #region Question 4

    //class Program
    //{
    //    static void Main()
    //    {
    //        int copies = 100;

    //         //BOXING

    //        object obj = copies;    

    //        //UNBOXING

    //        int newCopies = (int)obj; 

    //        Console.WriteLine(copies);
    //        Console.WriteLine(newCopies);
    //    }
    //}

    #endregion



    #region Question 5

    class Program
    {
        static void Main()
        {
            int pages = 464;

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
        }
    }

    #endregion






}
