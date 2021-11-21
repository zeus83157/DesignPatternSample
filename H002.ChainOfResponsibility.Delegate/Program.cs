using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H002.ChainOfResponsibility.Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var _data = new List<string>()
            {
                  "96500000000002015092919830912",
                  "96500000000009999999919830912",
                  "96500000000002015092919890330",
                  "96500000000012015092919870814",
                  "96511111111112015092819600808",
                  "96511111111112015092919820830",
                  "96512345678912015092819490704",
                  "96519570474632015092719541212",
                  "96519570474642015092719571115",
                  "96522222222222015092819561105",
                  "96522796416272015092819530520",
                  "96523008787902015092919340404",
                  "96523008787912015092919430520",
                  "96523008878462015092820121111",
                  "96523008977612015092719770403",
                  "96523009027852015092719580106",
                  "96523009056322015092719831119",
                  "96523009056332015092719460418",
                  "96523009056342015092719520122",
                  "96523009067372015092719920805",
                  "96523009085172015092719900402",
                  "96523009119722015092719571104",
                  "68000000000000000000000000000",
                  "69500000000002015182919830912",
                  "9999889",
                  "96523009085172015092719900402",
                  "96523009085172015092799999999"
            };

            var checkers = GetCheckers().ToList();

            _data.ForEach(x =>
            {
                if (checkers.Any(y => !y.Invoke(x)))
                    Console.WriteLine("Check Fail");
                else
                    Console.WriteLine("Check Success");
            });

            Console.ReadLine();
        }

        static IEnumerable<Func<string, bool>> GetCheckers()
        {
            // LengthChecker
            yield return x => x.Length > 7;

            // HeadChecker
            yield return x => x.Substring(0, 3) == "965";

            // DateChecker
            yield return x => DateTime.TryParse($"{x.Substring(13, 4)}/{x.Substring(17, 2)}/{x.Substring(19, 2)}", out DateTime date);
        }
    }
}
