using WebApplication1.Interfaces;

namespace WebApplication1.Implementations
{
    public class AddTransient : IAddTransient
    {
        Guid guid;

        public AddTransient()
        {
            guid = Guid.NewGuid();
        }

        public Guid TransientOperation()
        {
            return guid;
        }
    }
}
