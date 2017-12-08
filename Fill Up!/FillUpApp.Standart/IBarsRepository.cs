using FillUpApp.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillUpApp.Standart
{
    public interface IBarsRepository
    {
        Task<IEnumerable<Bar>> GetProductsAsync();

        Task<Bar> GetProductByIdAsync(int id);

        Task<bool> AddProductAsync(Bar bar);

        Task<bool> UpdateProductAsync(Bar bar);

        Task<bool> RemoveProductAsync(int id);

        Task<IEnumerable<Bar>> QueryProductsAsync(Func<Bar, bool> predicate);
    }
}