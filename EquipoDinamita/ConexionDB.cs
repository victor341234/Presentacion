using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace EquipoDinamita
{
    public class ConexionDB
    {

        public static MySqlConnection crearconexion()
        {
            string cadenaConexion = "server=localhost;port=3306;database=Estero;user id=root;password=Di4n4ran;";
            return new MySqlConnection(cadenaConexion);
        }
        // ***************************VALIDACIONES NOMBRE**************************************
        public bool ValidacionNombrePantalla(string nombre)
        {
            string query = "Select count(*) from Pantallas where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidacionNombreTablilla(string nombre)
        {
            string query = "Select count(*) from Tablillas where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidacionNombreCarcasa(string nombre)
        {
            string query = "Select count(*) from Carcasas where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidacionNombreBoton(string nombre)
        {
            string query = "Select count(*) from Botones where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        // ------------------------------------------------------------------------------------
        // **************************VALIDACIONES de existencia de ID de productos*************************************
        public bool ValidarIDPantalla(int ID)
        {
            string query = "select count(*) from Pantallas where Id_Pantalla = @Id_Pantalla";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Pantalla", ID);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidarIDTablilla(int ID)
        {
            string query = "select count(*) from Tablillas where Id_Tablilla = @Id_Tablilla";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Tablilla", ID);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidarIDCarcasa(int ID)
        {
            string query = "select count(*) from Carcasas where Id_Carcasas = @Id_Carcasas";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Carcasas", ID);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        public bool ValidarIDBotones(int ID)
        {
            string query = "select count(*) from Botones where Id_Botones = @Id_Botones";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Botones", ID);
                int encontrados = Convert.ToInt32(cmd.ExecuteScalar());
                return encontrados > 0;
            }
        }
        // ---------------------------------------------------------------------------------------
        //*******************************Obtener el numero de piezas en inventario (datos nesesario para la alerta)**********
        public int NumeroUnidadesDePantalla(int id)
        {
            string query = "SELECT Stock FROM Pantallas WHERE Id_Pantalla = @Id_Pantalla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Pantalla", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {   //     si el valor es nulo de la columna (0) ? devuelve 0:si no lo intenta convertir a int32(0) la columna (0)
                        return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    }
                }
            }
            return 0; 
        }
        public int NumeroUnidadesDeTablilla(int id)
        {
            string query = "SELECT Stock FROM Tablillas WHERE Id_Tablilla = @Id_Tablilla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Tablilla", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {   //     si el valor es nulo de la columna (0) ? devuelve 0:si no lo intenta convertir a int32(0) la columna (0)
                        return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        public int NumeroUnidadesDeCarcasa(int id)
        {
            string query = "SELECT Stock FROM Carcasas WHERE Id_Carcasas = @Id_Carcasas;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Carcasas", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {   //     si el valor es nulo de la columna (0) ? devuelve 0:si no lo intenta convertir a int32(0) la columna (0)
                        return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        public int NumeroUnidadesDeBotones(int id)
        {
            string query = "SELECT Stock FROM Botones WHERE Id_Botones = @Id_Botones;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Botones", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {   //     si el valor es nulo de la columna (0) ? devuelve 0:si no lo intenta convertir a int32(0) la columna (0)
                        return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        //public int GetDataToCreatePedido(int IdLote)
        //{
        //    string query = "select Id_Pantalla from Pedidos where Id_Lote = @Id_Lote;";
        //    using (MySqlConnection conexion = crearconexion())
        //    {
        //        conexion.Open();
        //        MySqlCommand cmd = new MySqlCommand( query, conexion);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("Id_Lote",IdLote);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            return reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
        //        }
        //    }
        //    return 0;
        //}




        //-------------------------------------------------------------------------------------------------------
        // *****************************OBTENEr datos para DATAGData.MySqlClient.MySqlException: 'Authentication to host 'localhost' for user 'root' using method 'caching_sha2_password' failed with message: Access denied for user 'root'@'localhost' (using password: YES)'RIDVIEWS y mostrar ******************************************
        public DataTable MostrarPantallas()
        {
            string query = "SELECT * FROM Pantallas";
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conexion = crearconexion())
                {
                    conexion.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(mySqlCommand);
                    adp.Fill(dataTable);
                }
            }
            catch (Exception x)
            {

                throw x;
            }
            return dataTable;
        }
        public DataTable MostrarTablillas()
        {
            string query = "SELECT * FROM Tablillas";
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conexion = crearconexion())
                {
                    conexion.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(mySqlCommand);
                    adp.Fill(dataTable);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dataTable;
        }
        public DataTable MostrarCarcasas()
        {
            string query = "SELECT * FROM Carcasas";
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conexion = crearconexion())
                {
                    conexion.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(mySqlCommand);
                    adp.Fill(dataTable);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dataTable;
        }
        public DataTable MostrarBotones()
        {
            string query = "SELECT * FROM Botones";
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conexion = crearconexion())
                {
                    conexion.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(mySqlCommand);
                    adp.Fill(dataTable);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dataTable;
        }
        public DataTable MostrarEstereo()
        {
            string query = "SELECT  Id_Lote AS Id_Pedido,pe.Nombre_Pedido AS Pedido,pe.Numero_Unidades AS Numero_Unidades,pe.Nombre_Estereo AS Tipo_Estero,p.Nombre AS Pantalla,t.Nombre AS Tablilla,c.Nombre AS Carcasa,b.Nombre AS Botones FROM Pedidos pe JOIN Pantallas p ON pe.Id_Pantalla = p.Id_Pantalla JOIN Tablillas t ON pe.Id_Tablilla = t.Id_Tablilla JOIN Carcasas c ON pe.Id_Carcasa = c.Id_Carcasas JOIN Botones b ON pe.Id_Botones = b.Id_Botones;";
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conexion = crearconexion())
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandText = query;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    return dt;
                }
            }
            catch (Exception x)
            {

                throw new Exception("error: "+x);
            }
        }


        // ----------------------------------------------------------------------------------------
        // *****************************INSERCION DE DATOS si NO existe(PRODUCTOS)****************************************
        // si no existe igresa nuevo 
        public bool IngresarPantallas(string nombre, int cantidad)
        {
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                string query = "Insert Into Pantallas(Nombre,Stock)" + 
                "value(@Nombre,@Stock)";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Stock", cantidad);
                int agregados = cmd.ExecuteNonQuery();
                return agregados > 0;
            }
        }
        public bool IngresarTablillas(string nombre, int cantidad)
        {
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                string query = "Insert Into Tablillas(Nombre,Stock)" +
                "value(@Nombre,@Stock)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Stock", cantidad);
                int agregados = cmd.ExecuteNonQuery();
                return agregados > 0;
            }
        }
        public bool IngresarCarcasas(string nombre, int cantidad)
        {
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                string query = "Insert Into Carcasas(Nombre,Stock)" +
                "value(@Nombre,@Stock)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Stock", cantidad);
                int agregados = cmd.ExecuteNonQuery();
                return agregados > 0;
            }
        }
        public bool IngresarBotones(string nombre, int cantidad)
        {
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                string query = "Insert Into Botones(Nombre,Stock)" +
                "value(@Nombre,@Stock)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Stock", cantidad);
                int agregados = cmd.ExecuteNonQuery();
                return agregados > 0;
            }
        }
        // -------------------------------------------------------------------------------------
        // *******************************INSERCIION DE DATOS SI EXISTE EL PRODUCTO**********************************************
        // si ya existe solo suma el stoc en ves de ingresar uno nuevo
        public bool AlterarStockPantallaPositivo(string Nombre, int Stock) 
        {
            string query = "update Pantallas set Stock = Stock + @Stock where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Nombre",Nombre);
                int alterado = Convert.ToInt32(cmd.ExecuteScalar());
                return alterado > 0;
            }
        }
        public bool AlterarStockTablillaPositivo(string Nombre, int Stock)
        {
            string query = "update Tablillas set Stock = Stock + @Stock where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int alterado = Convert.ToInt32(cmd.ExecuteScalar());
                return alterado > 0;
            }
        }
        public bool AlterarStockCarcasaPositivo(string Nombre, int Stock)
        {
            string query = "update Carcasas set Stock = Stock + @Stock where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int alterado = Convert.ToInt32(cmd.ExecuteScalar());
                return alterado > 0;
            }
        }
        public bool AlterarStockBotonesPositivo(string Nombre, int Stock)
        {
            string query = "update Botones set Stock = Stock + @Stock where Nombre = @Nombre;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int alterado = Convert.ToInt32(cmd.ExecuteScalar());
                return alterado > 0;
            }
        }

        //AKI LOS METODOS PARA DESCONTAR EL ESTOCK SEGUN EL NUMERO DE ESTEREOS CREADOS <<<<<<<<<<<<<<<<<<<<<<<
        public bool AlterarStockPantallaNegativo(int IdPantalla, int UnidadesNegativas)
        {
            string query = "update Pantallas set Stock = Stock - @Stock where Id_Pantalla = @Id_Pantalla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", UnidadesNegativas);
                cmd.Parameters.AddWithValue("@Id_Pantalla", IdPantalla);
                int alterado = Convert.ToInt32(cmd.ExecuteNonQuery());
                return alterado > 0;
            }
        }
        public bool AlterarStockTablillaNegativo(int idtablilla, int UnidadesNegativas)
        {
            string query = "update Tablillas set Stock = Stock - @Stock where Id_Tablilla = @Id_Tablilla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", UnidadesNegativas);
                cmd.Parameters.AddWithValue("@Id_Tablilla", idtablilla);
                int alterado = Convert.ToInt32(cmd.ExecuteNonQuery());
                return alterado > 0;
            }
        }
        public bool AlterarStockCarcasasNegativo(int idcarcasa, int UnidadesNegativas)
        {
            string query = "update Carcasas set Stock = Stock - @Stock where Id_Carcasas = @Id_Carcasas;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", UnidadesNegativas);
                cmd.Parameters.AddWithValue("@Id_Carcasas", idcarcasa);
                int alterado = Convert.ToInt32(cmd.ExecuteNonQuery());
                return alterado > 0;
            }
        }
        public bool AlterarStockBotonesNegativo(int idbotones, int UnidadesNegativas)
        {
            string query = "update Botones set Stock = Stock - @Stock where Id_Botones = @Id_Botones;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Stock", UnidadesNegativas);
                cmd.Parameters.AddWithValue("@Id_Botones", idbotones);
                int alterado = Convert.ToInt32(cmd.ExecuteNonQuery());
                return alterado > 0;
            }
        }
        // ****************************EDICION DE DATOS(PRODUCTOS)*******************************************
        public bool EditarPantallas(int Id,string Nombre)
        {
            string query = "update Pantallas set Nombre = @Nombre where Id_Pantalla= @Id_Pantalla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand (query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Pantalla", Id);
                cmd.Parameters.AddWithValue("@Nombre",Nombre);
                int editados = cmd.ExecuteNonQuery();
                return editados > 0;
            }
        }
        public bool EditarTablillas(int Id, string Nombre)
        {
            string query = "update Tablillas set Nombre = @Nombre where Id_Tablilla = @Id_Tablilla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Tablilla", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int editados = cmd.ExecuteNonQuery();
                return editados > 0;
            }
        }
        public bool EditarCarcasas(int Id, string Nombre)
        {
            string query = "update Carcasas set Nombre =@Nombre where Id_Carcasas = @Id_Carcasas;" ;
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Carcasas", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int editados = cmd.ExecuteNonQuery();
                return editados > 0;
            }
        }
        public bool EditarBotones(int Id, string Nombre)
        {
            string query = "update Botones set Nombre= @Nombre Where Id_Botones = @Id_Botones;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Botones", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                int editados = cmd.ExecuteNonQuery();
                return editados > 0;
            }
        }
        // -----------------------------------------------------------------------------------
        // ****************************ELIMINACION DE DATOS (PRODUCTOS)**********************************
        public bool EliminarPantalla(int ID) 
        {
            string query = "delete from Pantallas  where Id_Pantalla = @Id_Pantalla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Pantalla", ID);
                int eliminados = cmd.ExecuteNonQuery();
                return eliminados > 0;
            }
        }
        public bool EliminarTablilla(int ID)
        {
            string query = "delete from Tablillas  where Id_Tablilla = @Id_Tablilla;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Tablilla", ID);
                int eliminados = cmd.ExecuteNonQuery();
                return eliminados > 0;
            }
        }
        public bool EliminarCarcasa(int ID)
        {
            string query = "delete from Carcasas  where Id_Carcasas = @Id_Carcasas;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Carcasas", ID);
                int eliminados = cmd.ExecuteNonQuery();
                return eliminados > 0;
            }
        }
        public bool Eliminarbotones(int ID)
        {
            string query = "delete from Botones  where Id_Botones = @Id_Botones;";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id_Botones", ID);
                int eliminados = cmd.ExecuteNonQuery();
                return eliminados > 0;
            }
        }
        // -----------------------------------------------------------------------------------------------
        // *********************CREAcion de pedido(estereo) y sus derivados*************************************
        public bool GenerarPedido(string nombrePedio,string nombreEstereo,int NumeroUnidades,int Id_Pantalla, int Id_Tablilla, int Id_Carcasa,int Id_Botones)
        {
            string query = "insert into Pedidos(Nombre_Pedido,Numero_Unidades, Nombre_Estereo, Id_Pantalla, Id_Tablilla, Id_Carcasa, Id_Botones) " +
                "Values (@Nombre_Pedido,@Numero_Unidades,@Nombre_Estereo, @Id_Pantalla, @Id_Tablilla, @Id_Carcasa, @Id_Botones);";
            using (MySqlConnection conexion = crearconexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("Nombre_Pedido", nombrePedio);
                cmd.Parameters.AddWithValue("Nombre_Estereo", nombreEstereo);
                cmd.Parameters.AddWithValue("Numero_Unidades", NumeroUnidades);
                cmd.Parameters.AddWithValue("Id_Pantalla", Id_Pantalla);
                cmd.Parameters.AddWithValue("Id_Tablilla", Id_Tablilla);
                cmd.Parameters.AddWithValue("Id_Carcasa", Id_Carcasa);
                cmd.Parameters.AddWithValue("Id_Botones", Id_Botones);
                int credos = cmd.ExecuteNonQuery();
                return credos > 0;

            }
        }
        
        

    }
}
