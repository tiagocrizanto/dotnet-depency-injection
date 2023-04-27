namespace WebApplication1.Interfaces
{
    public class UseScoped : IUseScoped
    {
        private readonly IAddScoped _addScoped;

        public UseScoped(IAddScoped addScoped)
        {
            _addScoped = addScoped;
        }

        public Guid UseScopedOperation()
        {
            return _addScoped.ScopedOperation();
        }
    }
}
