using PlateService.Factories;

namespace PlateService.Services
{
    public interface IService
    {
        void Relies();

        bool ChangeFactory<T>() where T : IFactory;
    }
}