using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using System.ComponentModel;

namespace AVIDataAccess
{

    /// <summary>
    /// Clase de acceso a datos usando Entity Framework 6.x.
    /// </summary>
    /// <typeparam name="EntityType">Tipo de la entidad principal con la que se trabaja.</typeparam>
    public class EFDataAccess<EntityType>
        where EntityType : class
    {

        /// <summary>
        /// Contexto de la base de datos a utilizar para todas las operaciones.
        /// </summary>
        private DbContext DatabaseContext;

        /// <summary>
        /// Constructor por defecto. Toma el contexto que utilizará para todas las operaciones.
        /// </summary>
        /// <param name="context">Contexto a utilizar en todas las operaciones.</param>
        public EFDataAccess(DbContext context)
        {
            DatabaseContext = context;
        }

        /// <summary>
        /// Añade un registro a la base de datos.
        /// </summary>
        /// <param name="entity">Registro a añadir.</param>
        /// <returns>True si se ejecuta correctamente, false si ha ocurrido un error.</returns>
        public bool Create(EntityType entity)
        {
            try
            {
                DatabaseContext.Set<EntityType>().Add(entity);
                DatabaseContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Añade todos los registros en una lista a la base de datos.
        /// </summary>
        /// <param name="entityList">Lista de registros a añadir.</param>
        /// <returns>True si se ejecuta correctamente, false si ha ocurrido un error.</returns>
        public bool CreateFromList(List<EntityType> entityList)
        {
            try
            {
                foreach (EntityType entity in entityList)
                {
                    DatabaseContext.Set<EntityType>().Add(entity);
                }
                DatabaseContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lee todos los registros de la base de datos.
        /// </summary>
        /// <returns>Una lista con todos los registros. Si ha ocurrido un error durante la ejecución de la función, devuelve null.</returns>
        public List<EntityType> Refresh()
        {
            try
            {
                List<EntityType> entityList;

                entityList = (from items in DatabaseContext.Set<EntityType>() select items).ToList();

                return entityList;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lee todos los registros de una tabla relacionada a la tabla principal.
        /// </summary>
        /// <typeparam name="ForeignType">Tipo de la entidad de la tabla a consultar.</typeparam>
        /// <returns>Una lista con todos los registros. Si ha ocurrido un error durante la ejecución de la función, devuelve null.</returns>
        public List<ForeignType> RefreshForeignTable<ForeignType>()
            where ForeignType : class
        {
            try
            {
                List<ForeignType> entityList;

                entityList = (from items in DatabaseContext.Set<ForeignType>() select items).ToList();

                return entityList;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lee todos los registros de una tabla relacionada a la tabla principal.
        /// </summary>
        /// <typeparam name="ForeignType">Tipo de la entidad de la tabla a consultar.</typeparam>
        /// <returns>Una lista con todos los registros. Si ha ocurrido un error durante la ejecución de la función, devuelve null.</returns>
        public BindingList<ForeignType> RefreshForeignTableToBindingList<ForeignType>()
            where ForeignType : class
        {
            try
            {
                BindingList<ForeignType> entityList;

                entityList = (from items in DatabaseContext.Set<ForeignType>() select items).ToList().ToBindingList();

                return entityList;
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// Guarda todos los cambios y refresca el origen de datos. Además, devuelve la cantidad de ítems afectados.
        /// </summary>
        /// <param name="affectedItems">Número de registros afectados.</param>
        /// <returns>Una lista con todos los datos actualizados. Si ha ocurrido un error durante la ejecución de la función, devuelve null.</returns>
        public List<EntityType> SaveAndRefresh(out int affectedItems)
        {
            try
            {
                affectedItems = DatabaseContext.SaveChanges();

                List<EntityType> entityList;

                entityList = (from items in DatabaseContext.Set<EntityType>() select items).ToList();

                return entityList;
            }
            catch
            {
                affectedItems = 0;

                return null;
            }
        }

        /// <summary>
        /// Guarda todos los cambios y refresca el origen de datos. Además, devuelve la cantidad de ítems afectados.
        /// </summary>
        /// <returns>Una lista con todos los datos actualizados. Si ha ocurrido un error durante la ejecución de la función, devuelve null.</returns>
        public List<EntityType> SaveAndRefresh()
        {
            try
            {
                DatabaseContext.SaveChanges();

                List<EntityType> entityList;

                entityList = (from items in DatabaseContext.Set<EntityType>() select items).ToList();

                return entityList;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Elimina un registro de la base de datos.
        /// </summary>
        /// <param name="entity">Registro a eliminar.</param>
        /// <returns>True si se ejecuta correctamente, false si ha ocurrido un error.</returns>
        public bool Delete(EntityType entity)
        {
            try
            {
                DatabaseContext.Set<EntityType>().Remove(entity);
                DatabaseContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
