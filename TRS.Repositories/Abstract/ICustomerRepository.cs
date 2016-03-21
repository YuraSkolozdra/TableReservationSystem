using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> SellectAll();
    }
}
