using System;
using Employees.Data.Entities;

namespace Employees.Controllers.Api
{
    public class UpdateViewModel
    {
        public UpdateViewModel() { }

        private readonly Employee _entity;

        public string FirstName { get; set; }

        internal Employee ToEntity(Employee entity)
        {
            entity.FirstName = this.FirstName;

            return entity;
        }
    }
}