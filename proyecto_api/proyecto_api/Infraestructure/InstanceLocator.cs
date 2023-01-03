using proyecto_api.ViewsModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_api.Infraestructure
{
    class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
