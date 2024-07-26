

public class ExistDataException : Exception
{
    public string ErrorMessage { get; set; } = string.Empty;

    public ExistDataException(string errorMessage): base("Ya existen datos en las base de datos")
    {
        this.ErrorMessage = ErrorMessage;

    }
}