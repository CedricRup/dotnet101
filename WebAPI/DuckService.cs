using System.Collections.Generic;
using HelloWorld;

namespace WebAPI
{
    public interface IDuckService
    {
        IEnumerable<Duck> GetDucks();
    }

    public class DuckService : IDuckService
    {
        public IEnumerable<Duck> GetDucks()
        {
            return Duck.GetDucks();
        }
    }
}