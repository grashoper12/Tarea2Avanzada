using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.Repository
{
    public class SedesRepository
    {
        private static SedesModel[] sedesModel = new SedesModel[20];
        private static SedesViewModel[] sedesViewModel = new SedesViewModel[20];
        public static int Cantidad = 0;

        public SedesRepository() { }

        /// <summary>
        /// Metodo para registrar las sedes
        /// </summary>
        /// <param name="sedes"></param>
        /// <returns></returns>
        public string Insert(SedesModel sedes)
        {
            try
            {

                if (GetById(sedes.IdSede).IdSede != 0) return "La Id de sede ya se encuentra registrado..!!";

                if (Cantidad < 20)
                {
                    sedesModel[Cantidad] = sedes;
                    SedesViewModel se = new SedesViewModel { IdSede = sedes.IdSede, Nombre = sedes.Nombre };
                    sedesViewModel[Cantidad] = se;
                    Cantidad++;

                    return "Guardado con éxito...!!!";
                }
                else
                {
                    return "No se permite agregar más sedes...!!!";
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para listar las sedes
        /// </summary>
        /// <returns></returns>
        public SedesModel[] GetAll() => sedesModel;

        /// <summary>
        /// Buscar por IdSede
        /// </summary>
        /// <param name="IdSede"></param>
        /// <returns></returns>
        public SedesModel GetById(int IdSede)
        {
            try
            {
                SedesModel sedes = new SedesModel();

                for (int i = 0; i < Cantidad; i++)
                {
                    if (sedesModel[i].IdSede == IdSede)
                    {
                        sedes = sedesModel[i];
                        break;
                    }
                }

                return sedes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene las sedes para mostrarlas en un combobox
        /// </summary>
        /// <returns></returns>
        public SedesViewModel[] GetAllView() => sedesViewModel;

    }
}
