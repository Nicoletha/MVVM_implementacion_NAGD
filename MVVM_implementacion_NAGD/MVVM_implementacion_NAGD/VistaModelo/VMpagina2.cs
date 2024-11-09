using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_implementacion_NAGD;
using MVVM_implementacion_NAGD.Modelo;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace MVVM_implementacion_NAGD.VistaModelo
{
    internal class VMpagina2 : BaseViewModel
    {
        #region
        string _Texto;
        public List<Musuario> listausuarios {  get; set; }
        #endregion

        #region OBJETO
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuario>
            {
                new Musuario
                {
                    Nombre= "Nicol",
                    Imagen = "https://i.ibb.co/XyxZvf7/descifrador.gif"
                },

                new Musuario
                {
                    Nombre = "Alexa",
                    Imagen = "https://i.ibb.co/pKR4RYG/hacer-clic.gif" 
                },

                new Musuario
                {
                    Nombre = "Lucia",
                    Imagen = "https://i.ibb.co/m5vdGHb/matrimonio.gif" 
                }
            };
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        #endregion

        //Errores corregir 
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await ProcesoAsyncrono());
        //public Icommand ProcesoSimpcommand => new command (procesoSimple)
        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion
    }

}
