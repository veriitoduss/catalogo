using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_api.ViewsModel
{
    class MainViewModel
    {
        public principalViewModel ingreso { get; set; }
        public agregarproductosViewModel agregar { get; set; }
        public MainViewModel()
        {
            this.ingreso = new principalViewModel();
        }
    }
}
