using _03_Bussines.Repository;
using celilcavus.RandomApi.Entity;
using System;
using System.Web.Http;

namespace celilcavus.RandomApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly UserRepository _repository;

        public UserController()
        {
            _repository = new UserRepository();
        }

        [HttpGet]
        public User GetUser()
        {
            User user = new User();
            Random random = new Random();
            int year = random.Next(1, 99);

            string[] gend = { "Famele", "Male" };
            int gendVal = random.Next(0, 2);

            user.Name = FakeData.NameData.GetFirstName();
            user.Surname = FakeData.NameData.GetSurname();
            user.Age = year.ToString();
            user.Email = string.Concat(user.Name, user.Surname + "@example.com");
            user.Gender = gend[gendVal];
            user.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
            
            return user;
        }
        [HttpGet]
        public User FindUser(int id)
        {
            int? _id = id;
            if (_id.HasValue)
            {
                //return _repository.Get(_id.Value);
                return default;
            }
            else
                return default;
        }
        [HttpPost]
        public IHttpActionResult PostUser(User user)
        {

            string[] gend = { "Famele", "Male" };
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int year = random.Next(1, 99);
                user.Name = FakeData.NameData.GetFirstName();
                user.Surname = FakeData.NameData.GetSurname();
                user.Age = year.ToString();
                user.Email = string.Concat(user.Name, user.Surname + "@example.com");
                user.Gender = gend[random.Next(0, 1)];
                user.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                //_repository.Add(user);
            }
            return Ok<String>("User Başarıyla eklenmiştri");
        }
        [HttpPut]
        public IHttpActionResult PutUser(User user)
        {
            //_repository.Update(user);
            return Ok<String>("User Başarıyla Güncellenmiştir");
        }
        [HttpDelete]
        public IHttpActionResult DelUser(int id)
        {
            int? _id = id;
            if (_id.HasValue)
            {
                //_repository.Del(_id.Value);
            }
            return Ok<String>("User Başarıyla silindi..");
        }

    }
}
