namespace Pattern.Creational.FactoryMethod.Database
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }
}
