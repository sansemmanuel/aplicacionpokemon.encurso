using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dominio
{
   public  class elementonegocio
    {
        public List<Elementos> listar( )
        {
            List<Elementos> lista = new List<Elementos>();
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("Select Id, Descripcion FROM ELEMENTOS");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Elementos aux = new Elementos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                     
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
            return Elementos;
        }
    }
}
