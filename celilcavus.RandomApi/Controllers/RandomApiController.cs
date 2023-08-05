using _01_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace celilcavus.RandomApi.Controllers
{
    public class RandomApiController : ApiController
    {
        private readonly Email _email;
        private readonly FullName _fullname;
        private readonly Adress _adress;
        private readonly Phone _phone;

        public RandomApiController()
        {
            _email = new Email();
            _fullname = new FullName();
            _adress = new Adress();
            _phone = new Phone();
        }

        [HttpGet]
        public Email Email()
        {
            _email.email = FakeData.NetworkData.GetEmail();
            return _email; 
        }
        [HttpGet]
        public FullName FullName()
        {
            _fullname.name = FakeData.NameData.GetFirstName();
            _fullname.surName = FakeData.NameData.GetSurname();
            return _fullname;
        }
        [HttpGet]
        public Adress Adress()
        {
            _adress.country = FakeData.PlaceData.GetCountry();
            _adress.state = FakeData.PlaceData.GetState();
            _adress.county = FakeData.PlaceData.GetCounty();
            _adress.city = FakeData.PlaceData.GetCity();
            _adress.zipCode = FakeData.PlaceData.GetZipCode();
            _adress.streetNumber = FakeData.PlaceData.GetStreetNumber();
            _adress.streetName = FakeData.PlaceData.GetStreetName();
            _adress.adress = FakeData.PlaceData.GetAddress();
            return _adress;
        }
        [HttpGet]
        public Phone Phone()
        {
            _phone.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
            return _phone;
        }
    }
}
