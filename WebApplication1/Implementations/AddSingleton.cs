using System;
using WebApplication1.Interfaces;

namespace WebApplication1.Implementations
{
    public class AddSingleton : IAddSingleton
    {
        Guid guid;

        public AddSingleton()
        {
            guid = Guid.NewGuid();
        }

        public Guid SingletonOperation()
        {
            return guid;
        }
    }
}
