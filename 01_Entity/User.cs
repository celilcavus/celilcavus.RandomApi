﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace celilcavus.RandomApi.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

    }
}