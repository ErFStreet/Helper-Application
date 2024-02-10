namespace Constants;

public static class ProducerRandomNumber
{
    static ProducerRandomNumber()
    {
    }

    public static Result<int> GenerateRandomNumber(int minNumber, int maxNumber)
    {
        var rnd = new Random();

        var result = new Result<int>();

        if (maxNumber <= minNumber)
        {
            result = new Result<int>(isSuccess: false)
            {
                Value = (int)NumberEnum.None,
                Message = Message.BadRequest
            };
        }
        else
        {
            result = new Result<int>(isSuccess: true)
            {
                Value =
                    rnd.Next(minValue: minNumber, maxValue: maxNumber),

                Message = Message.SuccessRequest,
            };
        }

        return result;
    }
}
