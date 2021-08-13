namespace _01_BooklandQuery.Contract.Status
{
    public interface IStatusQuery
    {
        int GetAllBooksCount();
        int GetAllUsersCount();
        int GetHappyUsersCount();
    }
}
