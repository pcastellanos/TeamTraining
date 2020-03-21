using SOLID.DependencyInversion.Good.Enumeration;
using SOLID.DependencyInversion.Good.Persistence;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;

namespace SOLID.DependencyInversion.Good
{
    /// <summary>
    /// Factory to create the corresponding database provider
    /// </summary>
    public class FactoryDatabaseProvider
    {
        /// <summary>
        /// Database provider type
        /// </summary>
        DatabaseProvider _enumProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="FactoryDatabaseProvider"/> class
        /// </summary>
        /// <param name="provider"></param>
        public FactoryDatabaseProvider(DatabaseProvider provider)
        {
            _enumProvider = provider;
        }

        /// <summary>
        /// Gets the Database Provider to persist to the Database
        /// </summary>
        /// <returns>Database provider</returns>
        public IDatabaseGood GetProvider()
        {
            IDatabaseGood database = null;

            switch (_enumProvider)
            {
                case DatabaseProvider.SqlDatabase:
                    database = new SqlDatabaseGood();
                    break;
                case DatabaseProvider.MongoDatabase:
                    database = new MongoDatabase();
                    break;
                default:
                    break;
            }

            return database;
        }
    }
}
