namespace WebApplication1.Interfaces
{
    public class UseSingleton : IUseSingleton
    {
        private readonly IAddSingleton _addSingleton;
        public UseSingleton(IAddSingleton addSingleton)
        {
            _addSingleton = addSingleton;
        }

        public Guid UseSingltonOperation()
        {
            return _addSingleton.SingletonOperation();
        }
    }
}
