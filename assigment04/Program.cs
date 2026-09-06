namespace assigment04
{
    internal class Program
    {

        static void applydiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        static void Main(string[] args)
        {
            #region question1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region question2
            //can not answer
            #endregion

            #region qusetion3
            //printwelcomemessage();
            #endregion

            #region question4
            //printbooktitle("clean code");
            #endregion

            #region question5
            //int pages = 400;
            //addbounspages(pages);
            //Console.WriteLine(pages);

            //450 لاني في الميثود pages= +50
            //الكود مش عايز يرن ومش عارف المشكله 


            #endregion

            #region question6
            double[] prices = { 25.5, 40, 0 };
            applydiscount(prices);
            Console.WriteLine(prices[0]);
            // 20.5 لان بعمل - من اول اندكس 
            #endregion
        }
    }
}
