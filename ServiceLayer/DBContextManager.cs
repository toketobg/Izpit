using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        public static CarContext GetCarContext() => new CarContext();
        public static PersonContext GetPersonContext() => new PersonContext();
        public static RPUContext GetRPUContext() => new RPUContext();

    }
}