namespace Pattern.Creational.FactoryMethod.Database
{
    public class ConcreteSqlServerDatabase : CreatorDataAnalysisEngine
    {
        public override IDatabase CreateDatabase()
        {
            return new SqlServerDatabase();
        }
    }
}
