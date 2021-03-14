using System.Collections.Generic;
using System.Linq;
using PlateService.Factories;

namespace PlateService.Services
{
    public class Service : IService
    {
        private IFactory _activeFactory;
        private IList<IFactory> _factories;

        public Service(IList<IFactory> factories)
        {
            _activeFactory = null;
            _factories = factories;
        }

        public bool ChangeFactory<T>() where T : IFactory
        {

            _activeFactory = _factories.FirstOrDefault(factory => factory is T);

            return false;
        }

        public void Relies()
        {
            _activeFactory.ReleaseThePlate();
        }
    }
}