namespace TennisSystem.Domain.Exceptions
{
    public class InvalidTournamentException : BaseDomainException
    {
        public InvalidTournamentException()
        {
        }

        public InvalidTournamentException(string error) => this.Error = error;
    }
}
