using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repository.Abstract
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> SellectAll();
    }
}
