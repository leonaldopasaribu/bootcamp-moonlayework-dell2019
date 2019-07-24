using Checkins.Data.Abstractions;
using Checkins.Data.Entities;
using Data.EntityFramework.SqlServer;

namespace Checkins.Data.EntityFramework.SqlServer
{
    public class CheckinRepository : Repository<Checkin>, ICheckinRepository
    {
    }
}
