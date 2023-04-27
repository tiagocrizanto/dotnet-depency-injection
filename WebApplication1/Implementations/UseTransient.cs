namespace WebApplication1.Interfaces
{
    public class UseTransient : IUseTransient
    {
        private readonly IAddTransient _addTransient;

        public UseTransient(IAddTransient addTransient)
        {
            _addTransient = addTransient;
        }

        public Guid UseTransientOperation()
        {
            return _addTransient.TransientOperation();
        }
    }
}
