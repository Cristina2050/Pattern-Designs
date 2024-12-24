namespace Pattern.Creational.FactoryMethod.Database
{
    public abstract class CreatorDataAnalysisEngine
    {
        public abstract IDatabase CreateDatabase();

        public void ProcessData(string query)
        {
            IDatabase database = CreateDatabase();
            database.Connect();
            database.ExecuteQuery(query);
        }
    }
}
