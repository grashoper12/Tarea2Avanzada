using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class ClientesRepository
    {
        private ClientesModel[] clientes = new ClientesModel[20];
        private int Cantidad = 0;

        private ClientesRepository() { }

        private static ClientesRepository clien = null;

        /// <summary>
        /// Metodo para obtener la instancia
        /// </summary>
        /// <returns></returns>
        public static ClientesRepository GetInstance()
        {

            if (clien == null)
            {
                clien = new ClientesRepository();
            }
            return clien;

        }

        /// <summary>
        /// Metodo para guardar clientes
        /// </summary>
        /// <param name="clientesModel"></param>
        /// <returns></returns>
        public string Insert(ClientesModel clientesModel)
        {

            try
            {
                if (GetById(clientesModel.Identificacion) != null) return "El cliente ya esta registrado";

                if (Cantidad < 20)
                {
                    clientes[Cantidad] = clientesModel;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite el registro de más clientes...!!!";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lista todos los clientes
        /// </summary>
        /// <returns></returns>
        public ClientesModel[] GetAll() => clientes;

        /// <summary>
        /// Metodo para obtener un cliente
        /// </summary>
        /// <returns></returns>
        public ClientesModel GetById(string identificacion)
        {
            try
            {
                if(clientes != null)
                return clientes.Where(x => x.Identificacion == identificacion).FirstOrDefault();

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
