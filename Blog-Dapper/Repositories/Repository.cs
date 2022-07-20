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

        public TModel Get(int id)
            => _connection.Get<TModel>(id);

        public void Create(TModel model)
            => _connection.Insert<TModel>(model);

        public void Update(TModel model)
        {
           _connection.Update<TModel>(model);
        }

        public void Delete(TModel Model)
        {
           _connection.Delete<TModel>(Model);
        }

        public void Delete(int id)
        {
            var user = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(user);
        }
    }
}
