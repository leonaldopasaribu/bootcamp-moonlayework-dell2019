using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    public class CreateViewModels
    {
        //[Required()]
        public DateTimeOffset Time { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }

        public IFormFile Image { get; set; }

        //public Image
        internal Data.Entities.Checkin ToEntity()
        {
            return new Data.Entities.Checkin
            {
                Time = this.Time,
                Location = this.Location,
                Remark = this.Remark,
                //Image = this.Image,
            };
        }
    }
}
