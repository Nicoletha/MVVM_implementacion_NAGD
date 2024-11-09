using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_NAGD.VistaModelo
{
    class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region PROCESOS

        public async Task ProccesoAsyncrono()
        {
        }
        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command (async() => await ProccesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}