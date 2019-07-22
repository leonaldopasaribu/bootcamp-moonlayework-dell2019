using Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Data.Entities
{
    public class Checkin : Entity
    {
        public DateTimeOffset Time { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }
        //public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
