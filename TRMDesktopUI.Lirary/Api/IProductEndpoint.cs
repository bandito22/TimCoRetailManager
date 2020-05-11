using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUI.Lirary.Models;

namespace TRMDesktopUI.Lirary.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}