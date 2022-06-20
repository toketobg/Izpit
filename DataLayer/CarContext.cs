using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class CarContext : IDB<Car, string>
    {
        private IzpitContext ctx;

        public CarContext()
        {
            ctx = new IzpitContext();
        }
        public void Create(Car item)
        {
            try
            {
                ctx.Cars.Add(item);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Car Read(string key)
        {
            try
            {
                return ctx.Cars.Find(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IEnumerable<Car> ReadAll()
        {
            try
            {
                return ctx.Cars.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Update(Car item)
        {
            try
            {
                Car old = Read(item.LicensePlate);
                ctx.Entry(old).CurrentValues.SetValues(item);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Delete(string key)
        {
            try
            {
                Car car = Read(key);
                ctx.Cars.Remove(car);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
