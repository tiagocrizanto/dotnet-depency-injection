using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAddScoped _addScoped;
        private readonly IAddScoped _addScoped1;
        private readonly IAddSingleton _addSingleton;
        private readonly IAddSingleton _addSingleton1;
        private readonly IAddTransient _addTransient;
        private readonly IAddTransient _addTransient1;

        private readonly IUseSingleton _useSingleton;
        private readonly IUseTransient _useTransient;
        private readonly IUseScoped _useScoped;

        public HomeController(
            IAddScoped addScoped,
            IAddSingleton addSingleton,
            IAddTransient addTransient,
            IAddScoped addScoped1,
            IAddSingleton addSingleton1,
            IAddTransient addTransient1,
            IUseSingleton useSingleton,
            IUseTransient useTransient,
            IUseScoped useScoped)
        {
            _addScoped = addScoped;
            _addSingleton = addSingleton;
            _addTransient = addTransient;
            _addScoped1 = addScoped1;
            _addSingleton1 = addSingleton1;
            _addTransient1 = addTransient1;
            _useSingleton = useSingleton;
            _useTransient = useTransient;
            _useScoped = useScoped;
        }

        [HttpGet("get1")]
        public IActionResult Get1()
        {
            var scoped = _addScoped.ScopedOperation();
            var singleton = _addSingleton.SingletonOperation();
            var transient = _addTransient.TransientOperation();

            var scoped1 = _addScoped1.ScopedOperation();
            var singleton1 = _addSingleton1.SingletonOperation();
            var transient1 = _addTransient1.TransientOperation();

            return Ok(new
            {
                scoped = $"Scoped == scoped1: {scoped == scoped1} | scoped = {scoped} - scoped1 = {scoped1}",
                singleton = $"singleton == singleton1: {singleton == singleton1} | singleton = {singleton} - singleton1 = {singleton1}",
                transient = $"transient == transient1: {transient == transient1} | transient = {transient} - transient1 = {transient1}",
            });
        }

        [HttpGet("get2")]
        public IActionResult Get2()
        {
            var scoped = _addScoped.ScopedOperation();
            var singleton = _addSingleton.SingletonOperation();
            var transient = _addTransient.TransientOperation();

            var scoped1 = _useScoped.UseScopedOperation();
            var singleton1 = _useSingleton.UseSingltonOperation();
            var transient1 = _useTransient.UseTransientOperation();

            return Ok(new
            {
                scoped = $"Scoped == scoped1: {scoped == scoped1} | scoped = {scoped} - scoped1 = {scoped1}",
                singleton = $"singleton == singleton1: {singleton == singleton1} | singleton = {singleton} - singleton1 = {singleton1}",
                transient = $"transient == transient1: {transient == transient1} | transient = {transient} - transient1 = {transient1}",
            });
        }
    }
}
