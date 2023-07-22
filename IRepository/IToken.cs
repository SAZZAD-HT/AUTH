namespace TaskList.IRepository
{
    public interface IToken
    {
        public string GenerateToken(string userId);
    }
}
