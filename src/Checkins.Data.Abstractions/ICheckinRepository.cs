using Checkins.Data.Entities;
using Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Data.Abstractions
{
    public interface ICheckinRepository : IRepository<Checkin>
    {
    }
}
