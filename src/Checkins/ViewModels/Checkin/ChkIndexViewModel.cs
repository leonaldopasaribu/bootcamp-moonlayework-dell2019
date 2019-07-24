using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    public class ChkIndexViewModel
    {
        public ChkIndexViewModel(IEnumerable<Data.Entities.Checkin> data)
        {
            Checkins = data ?? new List<Data.Entities.Checkin>();
        }

        public IEnumerable<Data.Entities.Checkin> Checkins { get; }
    }
}
