using Projekt.DAL.Data;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DAL.Repositories
{
    internal class PaymentRepository : Repository<Payment>
    {
        public PaymentRepository(ProjektContext context) : base(context)
        {
        }
    }
}
