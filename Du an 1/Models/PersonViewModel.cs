using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Du_an_1.Models
{
    public class PersonViewModel
    {
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Picture { get; set; }
    }
}
