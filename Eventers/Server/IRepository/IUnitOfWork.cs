
using Eventers.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventers.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Eventer> Eventers { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Eventee> Eventees { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Company> Companies { get; }
    }
}