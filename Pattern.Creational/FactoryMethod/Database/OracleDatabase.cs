namespace Pattern.Creational.FactoryMethod.Database
{
    public class OracleDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Oracle DataBase ...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing Oracle query {query} ...");
        }
    }
}
