using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class RPUContext
    {
        private IzpitContext ctx;

        public RPUContext()
        {
            ctx = new IzpitContext();
        }
        public void Create(RPU item)
        {
            try
            {
                ctx.RPUs.Add(item);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public RPU Read(string key)
        {
            try
            {
                return ctx.RPUs.Find(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IEnumerable<RPU> ReadAll()
        {
            try
            {
                return ctx.RPUs.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Update(RPU item)
        {
            try
            {
                RPU old = Read(item.RPUID);
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
                RPU rpu = Read(key);
                ctx.RPUs.Remove(rpu);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
