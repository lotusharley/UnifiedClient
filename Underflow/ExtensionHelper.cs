using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Underflow
{
    public class ExtensionHelper
    {
        private static ExtensionHelper _instance;
        private static object locker = new object();

        private string _extensionPath;
        private CompositionContainer _compositionContainer;
        [ImportMany("UnifiedClientExtension")]
        private IEnumerable<IExtension.IContextExtension> _extensions;

        public SortedDictionary<string, IExtension.IContextExtension> Extensions { get; }

        private ExtensionHelper()
        {
            _extensionPath = System.AppDomain.CurrentDomain.BaseDirectory + "Extensions";
            _compositionContainer = new CompositionContainer();
            this.Extensions = new SortedDictionary<string, IExtension.IContextExtension>();
            LoadExtensions(_extensionPath);
        }

        public static ExtensionHelper GetInstance()
        {
            lock(locker)
            {
                if(_instance == null)
                {
                    _instance = new ExtensionHelper();
                }

                return _instance;
            }
        }

        private void LoadExtensions(string sPath)
        {
            AggregateCatalog catalog = new AggregateCatalog();
            //catalog.Catalogs.Add(new DirectoryCatalog(sPath));

            string basePath = _extensionPath;
            var subPaths = System.IO.Directory.GetDirectories(basePath).ToList();
            subPaths.ForEach(item =>
            {
                catalog.Catalogs.Add(new DirectoryCatalog(item));
            });


            _compositionContainer = new CompositionContainer(catalog);
            _compositionContainer.ComposeParts(this);

            foreach(var extension in this._extensions)
            {
                string sExtensionName = extension.GetExtensionName();
                IExtension.IContextExtension ext = (IExtension.IContextExtension)extension;
                this.Extensions.Add(sExtensionName, ext);
            }

            


        }
    }
}
