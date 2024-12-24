namespace Pattern.Creational.FactoryMethod.Database
{
    public class SqlServerDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQLServer DataBase ...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing SQLServer query {query} ...");
        }
    }
}
