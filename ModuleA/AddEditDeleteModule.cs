using Microsoft.Practices.Unity;
using ModuleA.Views;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;

namespace ModuleA
{
    public class AddEditDeleteModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public AddEditDeleteModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<AddEmployee>();
            _container.RegisterTypeForNavigation<EditEmployee>();
            _container.RegisterTypeForNavigation<DeleteEmployee>();
            _container.RegisterTypeForNavigation<ViewEmployee>();
        }
    }
}