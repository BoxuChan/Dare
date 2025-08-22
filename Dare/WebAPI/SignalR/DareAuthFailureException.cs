namespace Dare.WebAPI.SignalR;

public class DareAuthFailureException : Exception
{
    public DareAuthFailureException(string reason)
    {
        Reason = reason;
    }

    public string Reason { get; }
}