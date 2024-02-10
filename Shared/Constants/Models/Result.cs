namespace Constants.Models;

public class Result<T>
{
    public Result(bool isSuccess = true)
    {
        IsSuccess = isSuccess;
    }

    public bool IsSuccess { get; set; }

    public string Message { get; set; }

    public T Value { get; set; }
}
