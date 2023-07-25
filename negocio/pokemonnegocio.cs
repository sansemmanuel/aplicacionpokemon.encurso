using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
namespace negocio
{
    public class pokemonnegocio
    {
    ///metodo de acceso a datos para pokemon
    public List<pokemon> listar()
        {
            List <pokemon> Lista = new List<pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo FROM POKEMONS P, ELEMENTOS E WHERE E.Id = P.IdTipo ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                ///listar pokemon desde base de datos
                while (lector.Read())
                {
                    pokemon aux = new pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"]; //imagen
                    aux.Tipo = new Elementos();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    Lista.Add(aux);
                    }
                conexion.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       ///metodos agregar 
        public void agregar(pokemon nuevo)
        {

        }
        public void modificar(pokemon modificar)
        {

        }
    }
}
