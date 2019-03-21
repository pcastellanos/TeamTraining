using SOLID.DependencyInversion.Good.Enumeration;
using SOLID.DependencyInversion.Good.Persistence;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Good
{
    public class FactoryProvider
    {
        EnumProvider _enumProvider;
        public FactoryProvider(EnumProvider provider)
        {
            _enumProvider = provider;
        }


        public IDatabaseGood GetProvider()
        {
            IDatabaseGood database = null;
            switch (_enumProvider)
            {
                case EnumProvider.SqlDatabase:
                    database = new SqlDatabaseGood();
                    break;
                case EnumProvider.MongoDatabase:
                    database = new MongoDatabase();
                    break;
                default:
                    break;
            }
            return database;
        }
    }
}
