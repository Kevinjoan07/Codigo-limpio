using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeMenus
{
    internal class Menu
    {
        #region atributos
        private string _nombrePlato;
        private string _descripcion;
        private float _precio;
        List<Menu> _menus = new List<Menu>();

        #endregion


        #region constructor
        public string NombrePlato { get => _nombrePlato; set => _nombrePlato = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public float Precio { get => _precio; set => _precio = value; }
        #endregion


        #region metodos
        public void agregarPlato(string nombre,string descripcion, float precio)
        {
            _menus.Add(new Menu() { NombrePlato = nombre, Descripcion = descripcion,Precio= precio});
        }


        public void removerPlato(string nombre)
        {
            for(var i = 0; i < _menus.Count; i++)
            {
                if(_menus[i].NombrePlato == nombre)
                {
                    _menus.Remove(_menus[i]);
                }
            }
        }

        public void actualizarPLato(string nombre, float precio)
        {
            for (var i = 0; i < _menus.Count; i++)
            {
                if (_menus[i].NombrePlato == nombre)
                {
                    _menus[i].Precio = precio;
                }
            }
        }

        public void mostrarMenu()
        {
            foreach(var menu in _menus)
            {
                Console.WriteLine(menu);
            }
        }

        #endregion



    }
}
