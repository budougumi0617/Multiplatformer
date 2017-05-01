using Multiplatformer.Helpers;
using Multiplatformer.Interfaces;
using Multiplatformer.Services;
using Multiplatformer.Model;

namespace Multiplatformer
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}