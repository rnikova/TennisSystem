namespace TennisSystem.Domain.Exceptions
{
    public class InvalidStatisticException : BaseDomainException
    {
        public InvalidStatisticException()
        {
        }

        public InvalidStatisticException(string error) => this.Error = error;
    }
}
