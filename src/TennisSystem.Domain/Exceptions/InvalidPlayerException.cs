namespace TennisSystem.Domain.Exceptions
{
    public class InvalidPlayerException : BaseDomainException
    {
        public InvalidPlayerException()
        {
        }

        public InvalidPlayerException(string error) => this.Error = error;
    }
}