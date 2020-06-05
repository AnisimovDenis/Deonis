using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using Deonis_lib.Services.Interfaces;
using Deonis_lib.Services;
using Deonis_lib.Services.InMemory;

namespace Deonis.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var service = SimpleIoc.Default;

            service.Register<AdminWindowViewModel>();
            service.Register<IUserManager, UserManager>();
            service.Register<IUserStore, UserStoreInMemory>();
            service.Register<IEmployeeManager, EmployeeManager>();
            service.Register<IEmployeeStore, EmployeeStoreInMemory>();
        }

        public AdminWindowViewModel AdminWindowModel => ServiceLocator.Current.GetInstance<AdminWindowViewModel>();
    }
}