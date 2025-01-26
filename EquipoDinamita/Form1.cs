using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoDinamita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexionDB db = new ConexionDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.MostrarPantallas();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void LimpiarTextBox() //metodoo para limpiar los texbox
        {
            TxbID.Clear();
            TxbNombre.Clear();
            TxbStock.Clear();
        }
        private void LimpiarTexBoxIDS() //metodo unico para limpiar los textbox de la creacion del pedido
        {
            TxbNombrePedido.Clear();
            TxbNombreEstereoCP.Clear();
            TxbIdPantallaCP.Clear();
            TxbIdTablillaCP.Clear();
            TxbIdCarcasaCP.Clear();
            TxbIdBotonesCP.Clear();
            TxbNumeroUnidades.Clear();
        }
        private void TxbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        // ------------------------aki estan los eventos de los botones que estan en el boton producto
        // ----se le da texto ala etiketa verde, que use como referencia para cuando se usa el metodo ingresar, editar, eliminar. asi el programa sabe cual metodo usar
        // ------si el que es para pantalla ,tablilla o asi
        private void BtnPantallas_Click(object sender, EventArgs e)
        {

            LimpiarTextBox();
            dataGridView1.DataSource = db.MostrarPantallas();
            labelProducto.Text = "Pantallas";   //aki damos texto ala etiqueta verde que se usa como referencia para saber que metodo usar ejemplo linea(95)
            labelID.Text = "ID_Pantalla";
        }
        private void BtnTablillas_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            dataGridView1.DataSource = db.MostrarTablillas();
            labelProducto.Text = "Tablillas";
            labelID.Text = "ID_Tablilla";

        }
        private void BtnCarcasas_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            dataGridView1.DataSource = db.MostrarCarcasas();
            labelProducto.Text = "Carcasas";
            labelID.Text = "ID_Carcasa";
        }
        private void BtnBotones_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            dataGridView1.DataSource = db.MostrarBotones();
            labelProducto.Text = "Botones";
            labelID.Text = "Id_Boton";
        }
        private void BtnMostrarEstereo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.MostrarEstereo();
        }











        // -------aki estan los tres botones principales el de ingresar sirve para las 4 tablas (pantalla tablilla etc.) --------
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string identificador = labelProducto.Text;// aqui guardamos en una variable  el texto que tiene la etiketa verde que le asignamos enn la linea (61) el texto depende de el boton usado (pantalla tablilla etc.)

            if (identificador.Equals("Pantallas")) // aki preguntamos que texto tiene asi si es pantalla llamamos el metodo para pantalla y si no 
            {
                string nombre = TxbNombre.Text.Trim();//validamos 
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo de nombre, del producto no\n" +
                    "Se puede ir vacio \nIngrese nombre para continuar"); return;
                }
                if (nombre.Length > 60) // validamos
                { MessageBox.Show("ingresar menos de 60 caracteres"); return; }
                string stock = TxbStock.Text.Trim();
                if (!int.TryParse(stock, out int stock_cantidad))
                {
                    MessageBox.Show("Datos incorrectos\nIngrese un tipo de dato correcto para Stock(numero entero)"); return;
                }
                if (!db.ValidacionNombrePantalla(nombre)) // validamos
                {
                    db.IngresarPantallas(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarPantallas();
                    LimpiarTextBox();
                }
                else
                {
                    // en caso de que exista logica(validacion metodos)
                    db.AlterarStockPantallaPositivo(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarPantallas();
                    LimpiarTextBox();
                    MessageBox.Show("Stock agregado con exito");
                }
            }
            else if (identificador.Equals("Tablillas")) // aki se repite el proceso se pregunta por el texto de tablilla que se asigna si se preciona el boton tablilla 
            {
                string nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo de nombre Producto no\n" +
                    "Se puede ir vacio \nIngrese nombre para continuar"); return;
                }
                if (nombre.Length > 60)
                { MessageBox.Show("ingresar menos de 60 caracteres"); return; }
                string stock = TxbStock.Text.Trim();
                if (!int.TryParse(stock, out int stock_cantidad))
                {
                    MessageBox.Show("Datos incorrectos\nIngrese un tipo de dato correcto para Stock(numero entero)"); return;
                }
                if (!db.ValidacionNombreTablilla(nombre))
                {
                    db.IngresarTablillas(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarTablillas();
                    LimpiarTextBox();
                }
                else
                {
                    // -dkjsncpidsncsdnpcinsfmdkkkkkkkkkkcmmmmmpsdoooooooooooooo
                    db.AlterarStockTablillaPositivo(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarTablillas();
                    LimpiarTextBox();
                    MessageBox.Show("Stock agregado con exito");
                }
            }
            else if (identificador.Equals("Carcasas"))
            {
                string nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo de nombre Producto no\n" +
                    "Se puede ir vacio \nIngrese nombre para continuar"); return;
                }
                if (nombre.Length > 60)
                { MessageBox.Show("ingresar menos de 60 caracteres"); return; }
                string stock = TxbStock.Text.Trim();
                if (!int.TryParse(stock, out int stock_cantidad))
                {
                    MessageBox.Show("Datos incorrectos\nIngrese un tipo de dato correcto para Stock(numero entero)"); return;
                }
                if (!db.ValidacionNombreCarcasa(nombre))
                {
                    db.IngresarCarcasas(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarCarcasas();
                    LimpiarTextBox();
                }
                else
                {
                    // -dkjsncpidsncsdnpcinsfmdkkkkkkkkkkcmmmmmpsdoooooooooooooo
                    db.AlterarStockCarcasaPositivo(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarCarcasas();
                    LimpiarTextBox();
                    MessageBox.Show("Stock agregado con exito");
                }
            }
            else if (identificador.Equals("Botones"))
            {
                string nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo de nombre Producto no\n" +
                    "Se puede ir vacio \nIngrese nombre para continuar"); return;
                }
                if (nombre.Length > 60)
                { MessageBox.Show("ingresar menos de 60 caracteres"); return; }
                string stock = TxbStock.Text.Trim();
                if (!int.TryParse(stock, out int stock_cantidad))
                {
                    MessageBox.Show("Datos incorrectos\nIngrese un tipo de dato correcto para Stock(numero entero)"); return;
                }
                if (!db.ValidacionNombreBoton(nombre))
                {
                    db.IngresarBotones(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarBotones();
                    LimpiarTextBox();
                }
                else
                {
                    // -dkjsncpidsncsdnpcinsfmdkkkkkkkkkkcmmmmmpsdoooooooooooooo
                    db.AlterarStockBotonesPositivo(nombre, stock_cantidad);
                    dataGridView1.DataSource = db.MostrarBotones();
                    LimpiarTextBox();
                    MessageBox.Show("Stock agregado con exito");
                }
            }
        }

        // los siguientes de editar y eliminar siguen el mismo proceso
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string identificador = labelProducto.Text.Trim();

            if (identificador.Equals("Pantallas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto)) { MessageBox.Show("Ingrese 'Id' valido\ndel producto a editar"); return; }

                string Nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length > 60) { MessageBox.Show("Ingrese Nuevo 'Nombre'\nNo exceder el numero de caracteres (60)"); return; }


                if (db.ValidarIDPantalla(Id_Producto))
                {
                    db.EditarPantallas(Id_Producto, Nombre);
                    dataGridView1.DataSource = db.MostrarPantallas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nintente de nuevo"); return; }

            }

            else if (identificador.Equals("Tablillas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto)) { MessageBox.Show("Ingrese 'Id' valido\ndel producto a editar"); return; }

                string Nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length > 60) { MessageBox.Show("Ingrese Nuevo 'Nombre'\nNo exceder el numero de caracteres (60)"); return; }

                if (db.ValidarIDTablilla(Id_Producto))
                {
                    db.EditarTablillas(Id_Producto, Nombre);
                    dataGridView1.DataSource = db.MostrarTablillas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nintente de nuevo"); return; }

            }

            else if (identificador.Equals("Carcasas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto)) { MessageBox.Show("Ingrese 'Id' valido\ndel producto a editar"); return; }

                string Nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length > 60) { MessageBox.Show("Ingrese Nuevo 'Nombre'\nNo exceder el numero de caracteres (60)"); return; }


                if (db.ValidarIDCarcasa(Id_Producto))
                {
                    db.EditarCarcasas(Id_Producto, Nombre);
                    dataGridView1.DataSource = db.MostrarCarcasas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nintente de nuevo"); return; }
            }

            else if (identificador.Equals("Botones"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto)) { MessageBox.Show("Ingrese 'Id' valido\ndel producto a editar"); return; }

                string Nombre = TxbNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length > 60) { MessageBox.Show("Ingrese Nuevo 'Nombre'\nNo exceder el numero de caracteres (60)"); return; }

                if (db.ValidarIDBotones(Id_Producto))
                {
                    db.EditarBotones(Id_Producto, Nombre);
                    dataGridView1.DataSource = db.MostrarBotones();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nintente de nuevo"); return; }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string identificador = labelProducto.Text.Trim();

            if (identificador.Equals("Pantallas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto))
                {
                    MessageBox.Show("Ingrese 'ID' del producto a eliminar"); return;
                }
                else if (db.ValidarIDPantalla(Id_Producto))
                {
                    db.EliminarPantalla(Id_Producto);
                    dataGridView1.DataSource = db.MostrarPantallas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nIntente de nuevo"); return; }
            }

            else if (identificador.Equals("Tablillas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto))
                {
                    MessageBox.Show("Ingrese 'ID' del producto a eliminar"); return;
                }
                else if (db.ValidarIDTablilla(Id_Producto))
                {
                    db.EliminarTablilla(Id_Producto);
                    dataGridView1.DataSource = db.MostrarTablillas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nIntente de nuevo"); return; }
            }

            else if (identificador.Equals("Carcasas"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto))
                {
                    MessageBox.Show("Ingrese 'ID' del producto a eliminar"); return;
                }
                else if (db.ValidarIDCarcasa(Id_Producto))
                {
                    db.EliminarCarcasa(Id_Producto);
                    dataGridView1.DataSource = db.MostrarCarcasas();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nIntente de nuevo"); return; }
            }

            else if (identificador.Equals("Botones"))
            {
                string Id = TxbID.Text.Trim();
                if (!int.TryParse(Id, out int Id_Producto))
                {
                    MessageBox.Show("Ingrese 'ID' del producto a eliminar"); return;
                }
                else if (db.ValidarIDBotones(Id_Producto))
                {
                    db.Eliminarbotones(Id_Producto);
                    dataGridView1.DataSource = db.MostrarBotones();
                    LimpiarTextBox();
                }
                else { MessageBox.Show("El 'Id' ingresado no existe\nIntente de nuevo"); return; }
            }

        }






        // -- aki solo alcanse hacer lo que es las validaciones para los datos resividos en los texbox y el bucle para ingresar por montones 
        private void BtnGenerarPedido_Click(object sender, EventArgs e)
        {
            string NumeroUNIDADES = TxbNumeroUnidades.Text.Trim();
            if (!int.TryParse(NumeroUNIDADES, out int NumeroUnidades)) { MessageBox.Show("Ingrese Numero de Unidades para el pedido:"); return; }
            string nombrePedido = TxbNombrePedido.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombrePedido)) { MessageBox.Show("Ingrese nombrePedido del pedido:"); return; }
            string nombreEstereo = TxbNombreEstereoCP.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreEstereo)) { MessageBox.Show("Ingrese nombreEstere del pedido:"); return; }
            string idPantallat = TxbIdPantallaCP.Text.Trim();
            if (!int.TryParse(idPantallat, out int idPantalla)) { MessageBox.Show("Ingrese Id Pantalla del pedido"); return; }
            string idTablillat = TxbIdTablillaCP.Text.Trim();
            if (!int.TryParse(idTablillat, out int idTablilla)) { MessageBox.Show("Ingrese Id Tablilla del pedido"); return; };
            string idCarcasat = TxbIdCarcasaCP.Text.Trim();
            if (!int.TryParse(idCarcasat, out int idCarcasa)) { MessageBox.Show("Ingrese Id Carcasa del pedido"); return; };
            string idBotonest = TxbIdBotonesCP.Text.Trim();
            if (!int.TryParse(idBotonest, out int idBotones)) { MessageBox.Show("Ingrese Id Botones del producto"); return; };

            if (!db.ValidarIDPantalla(idPantalla)) { MessageBox.Show("El ID de pantalla ingresado no existe intente de nuevo con otro"); return; }
            if (!db.ValidarIDTablilla(idTablilla)) { MessageBox.Show("El ID de tablilla ingresado no existe intente de nuevo con otro"); return; }
            if (!db.ValidarIDCarcasa(idCarcasa)) { MessageBox.Show("El Id de Carcasa ingresado no existe intente de nuevo con otro"); return; }
            if (!db.ValidarIDBotones(idBotones)) { MessageBox.Show("El ID de boton ingresado no existe intente de nuevo con otro"); return; }

            // ***************************************************************************************************************************

            // AKI Recuperando el numero de stock pa ver si alcamsa mas adelante usaremos este mismo metodo para ver cuantas quedan desues de hacer el descuento--------
            int ValorStockPantalla = db.NumeroUnidadesDePantalla(idPantalla);
            int ValorStockTablilla = db.NumeroUnidadesDeTablilla(idTablilla);
            int ValorStockCarcasa = db.NumeroUnidadesDeCarcasa(idCarcasa);
            int ValorStockBotones = db.NumeroUnidadesDeBotones(idBotones);


            if (ValorStockPantalla >= NumeroUnidades) // si tenemos suficientes
            {
                if (ValorStockTablilla >= NumeroUnidades)
                {
                    if (ValorStockCarcasa >= NumeroUnidades)
                    {
                        if (ValorStockBotones >= NumeroUnidades)
                        {
                            if (db.GenerarPedido(nombrePedido, nombreEstereo, NumeroUnidades, idPantalla, idTablilla, idCarcasa, idBotones))//si se logra llamo a los metodos alterar´para descontar de los stocks
                            {
                                db.AlterarStockPantallaNegativo(idPantalla, NumeroUnidades);
                                db.AlterarStockTablillaNegativo(idTablilla, NumeroUnidades);
                                db.AlterarStockCarcasasNegativo(idCarcasa, NumeroUnidades);
                                db.AlterarStockBotonesNegativo(idBotones, NumeroUnidades);
                                MessageBox.Show("Pedido Generado Correctamente ");
                                LimpiarTexBoxIDS();

                                int ValorStockPantall = db.NumeroUnidadesDePantalla(idPantalla);// vuelvo a verificar el numero de pantallas para ver cuantas nos quedan
                                int ValorStockTablill = db.NumeroUnidadesDeTablilla(idTablilla);
                                int ValorStockCarcas = db.NumeroUnidadesDeCarcasa(idCarcasa);
                                int ValorStockBotone = db.NumeroUnidadesDeBotones(idBotones); 

                                if (ValorStockPantall < 300)// condicion de limite permitido antes de avisar que ya ocupamos encargar mas 
                                {
                                    EnviarCorreo("dianaerangel12@gmail.com", "Aviso preventivo de material ",// volvi a usar tu metodo para el correo solo cambie el mensaje 
                                        $"El inventario de pantallas esta por terminarse. " +
                                        $"Stock actual: {ValorStockPantall}. " + // esta es la variable mas actualisada del stoc
                                        $"Se requiere adquirir más material.");
                                    MessageBox.Show("Alerta de inventario. Se ha enviado un correo al área de compras.");
                                }
                                if (ValorStockTablill < 300)
                                {
                                    EnviarCorreo("vp40y20@gmail.com", "Aviso preventivo de material ",// volvi a usar tu metodo para el correo solo cambie el mensaje 
                                    $"El inventario de Tablillas esta por terminarse. " +
                                    $"Stock actual: {ValorStockTablill}. " + // esta es la variable mas actualisada del stoc
                                    $"Se requiere adquirir más material.");
                                    MessageBox.Show("Alerta de inventario. Se ha enviado un correo al área de compras.");
                                }
                                if (ValorStockCarcas < 300)
                                {
                                    EnviarCorreo("vp40y20@gmail.com", "Aviso preventivo de material ",// volvi a usar tu metodo para el correo solo cambie el mensaje 
                                    $"El inventario de Carcasas esta por terminarse. " +
                                    $"Stock actual: {ValorStockCarcas}. " + // esta es la variable mas actualisada del stoc
                                    $"Se requiere adquirir más material.");
                                    MessageBox.Show("Alerta de inventario. Se ha enviado un correo al área de compras.");
                                }
                                if (ValorStockBotone < 300)
                                {
                                    EnviarCorreo("vp40y20@gmail.com", "Aviso preventivo de material ",// volvi a usar tu metodo para el correo solo cambie el mensaje 
                                    $"El inventario de Botones esta por terminarse. " +
                                    $"Stock actual: {ValorStockBotone}. " + // esta es la variable mas actualisada del stoc
                                    $"Se requiere adquirir más material.");
                                    MessageBox.Show("Alerta de inventario. Se ha enviado un correo al área de compras.");
                                }
                                dataGridView1.DataSource = db.MostrarEstereo();
                            }
                        }
                        else
                        {
                            EnviarCorreo("vp40y20@gmail.com", "Aviso de material insuficiente",
                            $"El inventario de botones es insuficiente." +
                            $" Stock actual: {ValorStockBotones}. " +
                            $"Se requiere adquirir más material");
                            MessageBox.Show("El inventario de botones es insuficiente. Se ha enviado una notificacion al área de compras.");
                            return;
                        }
                    }
                    else
                    {
                        EnviarCorreo("vp40y20@gmail.com", "Aviso de material insuficiente",
                        $"El inventario de carcasas es insuficiente. " +
                        $"Stock actual: {ValorStockCarcasa}." +
                        $" Se requiere adquirir más material.");
                        MessageBox.Show("El inventario de carcasas es insuficiente. Se ha enviado una notificacion al área de compras.");
                        return;
                    }
                }
                else
                {
                    EnviarCorreo("vp40y20@gmail.com", "Aviso de material insuficiente",
                    $"El inventario de tablillas es insuficiente." +
                    $" Stock actual: {ValorStockTablilla}." +
                    $" Se requiere adquirir más material.");
                    MessageBox.Show("El inventario de tablillas es insuficiente. Se ha enviado una notificacion al área de compras.");
                    return;
                }

            }else// en caso de que el inventario sea menor al que se requiere o diferente del numero que se requiere
            {
                EnviarCorreo("vp40y20@gmail.com", "Aviso de material insuficiente",
                $"El inventario de pantallas es insuficiente. " +
                $"Stock actual: {ValorStockPantalla}. " +
                $"Se requiere adquirir más material.");

                MessageBox.Show("El inventario de pantallas es insuficiente. Se ha enviado una notificacion al área de compras.");
                return;
            }

        }

        // Método para enviar correos
        private void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {

            try
            {
                // Configuración del cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("dianaerangel12@gmail.com", "dbsj blku sxvx likk"),
                    EnableSsl = true // Asegura la conexión
                };

                // Crear el mensaje de correo
                MailMessage mensaje = new MailMessage
                {
                    From = new MailAddress("dianaerangel12@gmail.com"),
                    Subject = asunto,
                    Body = cuerpo,
                    IsBodyHtml = true // Si el cuerpo contiene HTML
                };

                // Agregar el destinatario
                mensaje.To.Add(destinatario);

                // Enviar el correo
                smtpClient.Send(mensaje);

                // Confirmación
                // quite tu mesage de confirmacion ya que cuando se envia el correo ahi mismo se pone el mensaje para que no se envie el mismo para todos
            }
            catch (Exception ex)
            {
                // Manejo de errores

                MessageBox.Show($"Error al enviar el correo: {ex.Message}\nDetalles: {ex.InnerException?.Message}");
            }
        
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}