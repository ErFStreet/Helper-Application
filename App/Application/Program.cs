namespace Application;

public class Program
{
    static void Main(string[] args)
    {
        // Generate Random Number With NumberEnum

        var randomNumber =
            ProducerRandomNumber.GenerateRandomNumber
                (minNumber: (int)Constants.Enums.NumberEnum.MinFourDigitNumber,
                     maxNumber: (int)Constants.Enums.NumberEnum.MaxFourDigitNumber);

        if (!randomNumber.IsSuccess)
        {
            Console.WriteLine(randomNumber.Message);
        }
        else
        {
            Console.WriteLine(randomNumber.Value);
        }


        // Generate Random Number Without NumberEnum

        var randomNumberWithoutNumberEnum =
            ProducerRandomNumber.GenerateRandomNumber(minNumber: 300, maxNumber: 1000);

        if (!randomNumberWithoutNumberEnum.IsSuccess)
        {
            Console.WriteLine(randomNumberWithoutNumberEnum.Message);
        }
        else
        {
            Console.WriteLine(randomNumberWithoutNumberEnum.Value);
        }
    }
}
