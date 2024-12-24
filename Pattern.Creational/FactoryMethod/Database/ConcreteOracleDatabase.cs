
namespace Pattern.Creational.FactoryMethod.Database
{
    public class ConcreteOracleDatabase : CreatorDataAnalysisEngine
    {
        public override IDatabase CreateDatabase()
        {
            return new OracleDatabase();
        }
    }
}
