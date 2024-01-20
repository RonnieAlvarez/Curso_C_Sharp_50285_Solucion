using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DGV_List
{
    internal class ListaMayoresClass
    {
        private List<ClienteClass> _clientesMayores;

        public ListaMayoresClass()
        {
            _clientesMayores = new List<ClienteClass>();
        }

        public List<ClienteClass> GetListaClientes()
        {
            return _clientesMayores;
        }
        public void InsertarEnLista(ClienteClass[] clientes)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                _clientesMayores.Add(new ClienteClass(clientes[i].Id, clientes[i].Nombre,
                     clientes[i].Direccion, clientes[i].Edad));
            }
        }

   
        public bool Borrar(ClienteClass cliente)
        {
            if (!_clientesMayores.Contains(cliente)) return false;
            return _clientesMayores.Remove(cliente);
        }
        public int Buscar(ClienteClass cliente)
        {
            return _clientesMayores.IndexOf(cliente);
        }
        public bool Modificar(ClienteClass actual, ClienteClass nuevo)
        {
            int posicion = Buscar(actual);
            if (posicion < 0) return false;
            _clientesMayores[posicion] = nuevo;
            return true;
        }
        public void LimpiarLista()
        {
            _clientesMayores.Clear();
        }

        public int CompararClientes(ClienteClass cliente1, ClienteClass cliente2)
        {
            return cliente1.Id.CompareTo(cliente2.Id);
        }
        public void Ordenar()
        {
            _clientesMayores.Sort(CompararClientes);
        }

    }
}
