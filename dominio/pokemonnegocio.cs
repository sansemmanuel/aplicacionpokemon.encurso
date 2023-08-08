using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace dominio
{
    public class pokemonnegocio
    {
    ///metodo de acceso a datos para pokemon
   

        public List<pokemon> listar()
        {
            List<pokemon> lista = new List<pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    pokemon aux = new pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //    aux.UrlImagen = (string)lector["UrlImagen"];
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elementos();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elementos();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        ///metodos agregar 
        public void agregar(pokemon nuevo)
        {
            accesodatos datos = new accesodatos(); ///objeto conexion para insert
            try
            {
                datos.setearconsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen)values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, @idTipo, @idDebilidad, @urlImagen)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
                datos.setearParametro("@urlImagen", nuevo.UrlImagen);
                ///ejecutar consulta non-query ---crear metodo en acceso datos
                datos.ejecutarAccion();

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
        public void modificar(pokemon modificar)
        {
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");
                datos.setearParametro("@numero", modificar.Numero);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@desc", modificar.Descripcion);
                datos.setearParametro("@img", modificar.UrlImagen);
                datos.setearParametro("@idTipo", modificar.Tipo.Id);
                datos.setearParametro("@idDebilidad", modificar.Debilidad.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
            public void eliminar(int id)
        {
            try
            {
                accesodatos datos = new accesodatos();
                datos.setearconsulta("delete from pokemons where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
