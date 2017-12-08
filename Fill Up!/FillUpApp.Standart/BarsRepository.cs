using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;

namespace FillUpApp.Standart
{
    public class BarsRepository : IBarsRepository
    {

        private readonly DatabaseContext _databaseContext;

        public BarsRepository(string dbPath)
        {
            _databaseContext = new DatabaseContext(dbPath);
        }

        public async Task<IEnumerable<Bar>> GetProductsAsync()
        {
            try
            {
                var bars = await _databaseContext.Bars.ToListAsync();

                return bars;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Bar> GetProductByIdAsync(int id)
        {
            try
            {
                var product = await _databaseContext.Bars.FindAsync(id);

                return product;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> AddProductAsync(Bar bar)
        {
            try
            {
                var tracking = await _databaseContext.Bars.AddAsync(bar);

                await _databaseContext.SaveChangesAsync();

                var isAdded = tracking.State == EntityState.Added;

                return isAdded;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductAsync(Bar bar)
        {
            try
            {
                var tracking = _databaseContext.Update(bar);

                await _databaseContext.SaveChangesAsync();

                var isModified = tracking.State == EntityState.Modified;

                return isModified;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> RemoveProductAsync(int id)
        {
            try
            {
                var product = await _databaseContext.Bars.FindAsync(id);

                var tracking = _databaseContext.Remove(product);

                await _databaseContext.SaveChangesAsync();

                var isDeleted = tracking.State == EntityState.Deleted;

                return isDeleted;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Bar>> QueryProductsAsync(Func<Bar, bool> predicate)
        {
            try
            {
                var bars = _databaseContext.Bars.Where(predicate);
                await _databaseContext.SaveChangesAsync();

                return bars.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
