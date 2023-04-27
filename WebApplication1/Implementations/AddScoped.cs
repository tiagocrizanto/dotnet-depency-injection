using WebApplication1.Interfaces;

namespace WebApplication1.Implementations
{
    public class AddScoped : IAddScoped
    {
        Guid guid;

        public AddScoped()
        {
            guid = Guid.NewGuid();
        }

        public Guid ScopedOperation()
        {
            return guid;
        }
    }
}
