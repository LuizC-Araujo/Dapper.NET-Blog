using System.Collections.Generic;

using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace Blog_Dapper.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<TModel> Get()
            => _connection.GetAll<TModel>();
    }
}
