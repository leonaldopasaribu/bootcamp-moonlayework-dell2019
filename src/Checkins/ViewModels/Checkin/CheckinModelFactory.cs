using Checkins.Data.Abstractions;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    internal class CheckinModelFactory
    {
        public CheckinModelFactory()
        {

        }

        internal ChkIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var checkinRepo = storage.GetRepository<ICheckinRepository>();

            return new ChkIndexViewModel(checkinRepo.All(page, size));
        }
    }
}
