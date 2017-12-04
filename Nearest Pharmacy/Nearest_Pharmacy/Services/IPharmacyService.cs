using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nearest_Pharmacy.Models
{
    public interface IPharmacyService
    {

        Task<IEnumerable<Product>> Get();

        Task<User> Add(User user);
    }
}