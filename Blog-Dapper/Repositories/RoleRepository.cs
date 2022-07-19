using System.Collections.Generic;

using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

using Blog_Dapper.Models;

namespace Blog_Dapper.Repositories
{
    public class RoleRepository
    {
        


        public IEnumerable<Role> Get()
            => _connection.GetAll<Role>();

        public Role Get(int id)
            => _connection.Get<Role>(id);

        public void Create(Role role)
            => _connection.Insert<Role>(role);

        public void Update(Role role)
        {
            if (role.Id != 0)
                _connection.Update<Role>(role);
        }

        public void Delete(Role role)
        {
            if (role.Id != 0)
                _connection.Delete<Role>(role);
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var role = _connection.Get<Role>(id);
            _connection.Delete<Role>(role);
        }
    }
}
