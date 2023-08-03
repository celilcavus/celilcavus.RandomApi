using _02_DataAccess.Dapper;
using Bussines.Interfaces;
using celilcavus.RandomApi.Entity;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace _03_Bussines.Repository
{
    public class UserRepository : IBaseRepository<User>
    {
        public void Add(User item)
        {
            DapperContext.connection.Execute($@"INSERT INTO `randomdb`.`user`
            (
            `Name`,
            `Surname`,
            `Age`,
            `Email`,
            `Gender`,
            `PhoneNumber`
            )
            VALUES                    ('{item.Name}','{item.Surname}','{item.Age}','{item.Email}','{item.Gender}','{item.PhoneNumber}')");
        }

        public List<User> All()
        {
            return DapperContext.connection.Query<User>("SELECT * FROM user").ToList();
        }

        public void Del(int? id)
        {
            if (id.HasValue && id > 0)
            {
                DapperContext.connection.Query($"Delete from user where id = {id.Value}");
            }
        }

        public User Get(int? id)
        {
            if (id.HasValue && id > 0)
            {
                return DapperContext.connection.QueryFirstOrDefault<User>($"SELECT * FROM user where id = {id.Value}");
            }
            else
                return null;
        }

        public void Update(User item)
        {
            DapperContext.connection.Execute($@"UPDATE `randomdb`.`user`
            SET
            `Name` = '{item.Name}',
            `Surname` = '{item.Surname}',
            `Age` = '{item.Age}',
            `Email` = '{item.Email}',
            `Gender` = '{item.Gender}',
            `PhoneNumber` = '{item.PhoneNumber}'
            WHERE `id` = {item.Id};
            ");
        }
    }
}
