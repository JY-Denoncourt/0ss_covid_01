using System.Collections.Generic;

namespace BillingManagement.Business

{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
