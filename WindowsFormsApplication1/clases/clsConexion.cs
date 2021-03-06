﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.clases
{
    class clsConexion
    {
        //string conexion peco
        // @"Data Source=CLAUDIO\SQLEXPRESS;Initial Catalog=Call_Center;Integrated Security=True";

        //string conexion joa
        //@"Data Source=LAPTOP-T29R0N2Q\SQLEXPRESS;Initial Catalog=Call_Center;Integrated Security=True";

        SqlConnection con;
        string conx = @"Data Source=LAPTOP-T29R0N2Q\SQLEXPRESS;Initial Catalog=Call_Center;Integrated Security=True";


        public clsConexion()
        { con = new SqlConnection(conx); }
        

        public bool logear(int dni, string pss)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre, password, jefe FROM empleado WHERE dni = @usuario AND password = @password", con);
                cmd.Parameters.AddWithValue("usuario", dni);
                cmd.Parameters.AddWithValue("password", pss);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt.Rows.Count == 1? true : false; //si user y pass son correctos
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        
        public clsContacto nuevo_contacto(int id_contacto) // Consulta y devuelve datos de un contacto / NULL
        {
            clsContacto contacto = new clsContacto();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from contacto where id_contacto=@id_user", con);

                cmd.Parameters.AddWithValue("id_user", id_contacto);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    contacto.Id = Convert.ToInt32(dt.Rows[0][0]);
                    contacto.Nombre = Convert.ToString(dt.Rows[0][1]);
                    contacto.Apellido = Convert.ToString(dt.Rows[0][2]);
                    contacto.Dni = Convert.ToInt32(dt.Rows[0][3]);
                    contacto.Fecha_nacimiento = (DateTime)dt.Rows[0][4];
                    contacto.Ocupacion = Convert.ToString(dt.Rows[0][5]);
                    contacto.Est_civil = Convert.ToString(dt.Rows[0][6]);
                    contacto.Nacionalidad = Convert.ToString(dt.Rows[0][7]);
                    contacto.Provincia = Convert.ToString(dt.Rows[0][8]);
                    contacto.Telefono = Convert.ToDouble(dt.Rows[0][9]);
                    contacto.Domicilio = Convert.ToString(dt.Rows[0][10]);
                }
                return contacto;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        


        #region funciones de VENTAS  CHEKC HECK CHEKC

        public int obtener_id_venta()
        {
            try
            {
                int cant = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(*) as cantidad  from venta", con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant = Convert.ToInt32(dt.Rows[0][0]);
                cant++;
                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }
        }
        
        public void insertar_venta(clsVenta venta)//nueva llamadaDenuevo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO venta (id_venta,id_llamada, fecha_venta) values (@id_venta, @id_llamada, @fecha_venta)", con);

                cmd.Parameters.AddWithValue("id_venta", venta.Id_venta);
                cmd.Parameters.AddWithValue("id_llamada", venta.Id_llamada);
                cmd.Parameters.AddWithValue("fecha_venta", venta.Fecha_venta);


                int result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        public DataTable listarVentas()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT venta.id_venta, empleado.nombre +' '+ empleado.apellido as Empleado, venta.fecha_venta as 'Fecha Venta', contacto.nombre +' '+ contacto.apellido as Comprador, llamada.duracion as 'Duracion llamada', campaña.nombre as Campaña, cliente.nombre as Cliente " +
                    "FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado join cliente  on campaña.id_cliente = cliente.id_cliente join contacto  on llamada.id_contacto = contacto.id_contacto", con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable filtro_ventas_time(string fecha)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where fecha_venta=@fecha ", con);

                cmd.Parameters.AddWithValue("fecha", fecha);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable filtro_ventas_con_time(string fecha, string cliente, string empleado, string campaña, string nombre)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where fecha_venta=@fecha and  campaña.nombre like @campaña and  campaña.nombreCliente like @cliente and empleado.apellido like @empleado and empleado.nombre like @nombre ", con);

                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("cliente", cliente);
                cmd.Parameters.AddWithValue("empleado", empleado);
                cmd.Parameters.AddWithValue("campaña", campaña);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }

        public DataTable filtro_ventas_sin_time(string cliente, string empleado, string campaña, string nombre)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where  campaña.nombre like @campaña and  campaña.nombreCliente like @cliente and empleado.apellido like @empleado and empleado.nombre like @nombre ", con);

                cmd.Parameters.AddWithValue("cliente", cliente);
                cmd.Parameters.AddWithValue("empleado", empleado);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("campaña", campaña);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }

        public DataTable filtro_ventas_año(int año)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where YEAR(fecha_venta)=@año ", con);

                cmd.Parameters.AddWithValue("año", año);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }

       /* public DataTable filtro_ventas_mes(string mes)
        {

            int mess = switch_mes(mes);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where MONTH(fecha_venta)=@mes ", con);

                cmd.Parameters.AddWithValue("mes", mess);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }
        */
       /* public DataTable filtro_ventas_mes_año(string mes, int año)
        {
            int mess = switch_mes(mes);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where MONTH(fecha_venta)=@mes and YEAR(fecha_venta)=@año", con);

                cmd.Parameters.AddWithValue("mes", mess);
                cmd.Parameters.AddWithValue("año", año);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }
        */
       /*public DataTable filtro_ventas_mes_año_todos(string mes, int año, string cliente, string empleado, string campaña, string nombre)
        {

            int mess = switch_mes(mes);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where MONTH(fecha_venta)=@mes and YEAR(fecha_venta)=@año and  campaña.nombre like @campaña and  campaña.nombreCliente like @cliente and empleado.apellido like @empleado and empleado.nombre like @nombre ", con);



                cmd.Parameters.AddWithValue("año", año);
                cmd.Parameters.AddWithValue("mes", mess);
                cmd.Parameters.AddWithValue("cliente", cliente);
                cmd.Parameters.AddWithValue("empleado", empleado);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("campaña", campaña);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }
        */
       /*  public DataTable filtro_ventas_mes_todos(string mes, string cliente, string empleado, string campaña, string nombre)
        {

            int mess = switch_mes(mes);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where MONTH(fecha_venta)=@mes and  campaña.nombre like @campaña and  campaña.nombreCliente like @cliente and empleado.apellido like @empleado and empleado.nombre like @nombre ", con);




                cmd.Parameters.AddWithValue("mes", mess);
                cmd.Parameters.AddWithValue("cliente", cliente);
                cmd.Parameters.AddWithValue("empleado", empleado);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("campaña", campaña);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt;

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }




        }
*/

        public DataTable filtro_ventas_años_todos(int año, string cliente, string empleado, string campaña, string nombre)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  venta.id_venta,venta.fecha_venta as 'Fecha Venta',campaña.nombreCliente as 'Cliente' , campaña.nombre as 'Campaña', empleado.nombre, empleado.apellido, llamada.duracion as 'Duracion llamada' FROM llamada join venta on llamada.id_llamada = venta.id_llamada join campaña on campaña.id_campaña = llamada.id_campaña join empleado on llamada.id_empleado = empleado.id_empleado" +
                    " where YEAR(fecha_venta)=@año and  campaña.nombre like @campaña and  campaña.nombreCliente like @cliente and empleado.apellido like @empleado and empleado.nombre like @nombre ", con);

                cmd.Parameters.AddWithValue("año", año);
                cmd.Parameters.AddWithValue("cliente", cliente);
                cmd.Parameters.AddWithValue("empleado", empleado);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("campaña", campaña);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

       

        public string totalTiempoPromedioCampaña(int id)
        {

            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";
         

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion,t_reunion,t_llenadoFormularios,t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where  jornada_laboral.id_campaña=" + id, con);
                


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);
                if (dt.Rows.Count > 0)
                {
                    float prom = float.Parse((minutos).ToString()) / float.Parse((dt.Rows.Count).ToString());
                    res = prom.ToString();
                }

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalTiempoImproPromedioCampaña(int id)
        {

            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_descanso, t_sinContactos, t_sinCampaña,t_inactivo, t_baño,  t_almuerzo  from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where  jornada_laboral.id_campaña=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);
                if (dt.Rows.Count>0)
                {
                    float prom = float.Parse((minutos).ToString()) / float.Parse((dt.Rows.Count).ToString());
                    res = prom.ToString();
                }

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string promedioEspera(int idcamp)

        {

            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT[id_campaña],[id_empleado],[t_espera] FROM [Call_Center].[dbo].[llamada] where [id_campaña]=" + idcamp, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);
                if (dt.Rows.Count > 0)
                {
                    float prom = float.Parse((minutos).ToString()) / float.Parse((dt.Rows.Count).ToString());
                    res = prom.ToString();
                }

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalTiempoProductivo(int id,int idcamp)
        {

            clsCampaña campaña = new clsCampaña();
            string res="no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select [t_capacitacion],[t_reunion],[t_llenadoFormularios],[t_atendiendo] from [Call_Center].[dbo].[jornada_laboral]  where [jornada_laboral].id_empleado=" +id+ " and [jornada_laboral].id_campaña=" +idcamp, con);

                

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);
                if (dt.Rows.Count > 0)
                {
                    float prom = float.Parse((minutos).ToString()) / float.Parse((dt.Rows.Count).ToString());
                    res = prom.ToString();
                }

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalTiempoImproductivo(int id,int idcamp)

        {

            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select [t_descanso], [t_sinContactos], [t_sinCampaña],[t_inactivo], [t_baño],  [t_almuerzo]  from [Call_Center].[dbo].[jornada_laboral]  where [jornada_laboral].id_empleado=" + id + " and [jornada_laboral].id_campaña=" + idcamp, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);
                if (dt.Rows.Count > 0)
                {
                    float prom = float.Parse((minutos).ToString()) / float.Parse((dt.Rows.Count).ToString());
                    res = prom.ToString();
                }

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalTiempoProductivoFormat( int idcamp, int id)
        {

            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select [t_capacitacion],[t_reunion],[t_llenadoFormularios],[t_atendiendo] from [Call_Center].[dbo].[jornada_laboral]  where [jornada_laboral].id_empleado=" + id + " and [jornada_laboral].id_campaña=" + idcamp, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                
                res = dameTiempo(dt);
               
               

                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalTiempoImproductivoFormat(int idcamp,int id)

        {

            
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select [t_descanso], [t_sinContactos], [t_sinCampaña],[t_inactivo], [t_baño],  [t_almuerzo]  from [Call_Center].[dbo].[jornada_laboral]  where [jornada_laboral].id_empleado=" + id + " and [jornada_laboral].id_campaña=" + idcamp, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                res = dameTiempo(dt);



                return res;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }

        }

        public string totalLlamadaEMpleadoCampaña(int idCamp, int idEmp, string Fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[llamada] where [id_empleado]=" + idEmp + " and  [id_campaña]=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                

                return dt.Rows.Count.ToString();



            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "No hay registros";
            }
            finally
            {
                con.Close();
            }

            
        }

        public string totalVentasEMpleadoCampaña(int idCamp, int idEmp)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[llamada] where [resultado] like 'Vendido'and  [id_empleado]=" + idEmp + " and  [id_campaña]=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                return dt.Rows.Count.ToString();



            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "No hay registros";
            }
            finally
            {
                con.Close();
            }


        }





        public string totalEspera(int id,int idcamp)
        {
            clsCampaña campaña = new clsCampaña();
            string res = "no hay registros";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_espera FROM llamada WHERE t_espera IS NOT NULL AND id_campaña = " + idcamp + " AND id_empleado = " + id, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);
                if (dt.Rows.Count > 0)
                {
                    float prom = (float)minutos / (float)dt.Rows.Count;
                    res = prom.ToString();
                }

                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);//
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        #region Funciones de tiempo  CHEKC HECK CHECK
                
        public double[] tiemposCampañaEmpleado(int idemp,int idcamp,DateTime desde,DateTime hasta)
        {
            double[] res = new double[10];

            res[0] = tiempoAtendiendo(idemp,idcamp,"");
            res[1] = tiempoFormulario(idemp, idcamp, "");
            res[2] = tiempoCapacitacion(idemp, idcamp, "");
            res[3] = tiempoDescanso(idemp, idcamp, "");
            res[4] = tiempoSinContacto(idemp, idcamp, "");
            res[5] = tiempoInactivo(idemp, idcamp, "");
            res[6] = tiempoReunion(idemp, idcamp, "");
            res[7] = tiempoBaño(idemp, idcamp, "");
            res[8] = tiempoAlmuerzo(idemp, idcamp, "");
            res[9] = tiempoSinCampaña(idemp, idcamp, "");

            return res;
        }

        public double tiempoAtendiendo( int idEmp,int idCamp,string fecha)
        {

            
           
      

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_atendiendo]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado="+idEmp + " and[jornada_laboral].id_campaña="+idCamp, con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;
                


            }

            catch (Exception e)
            {
                //// MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoFormulario(int idEmp, int idCamp, string fecha)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_llenadoFormularios]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoCapacitacion(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_capacitacion]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoDescanso(int idEmp, int idCamp, string fecha)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_descanso]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }


        }

        public double tiempoSinContacto(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_sinContactos]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoInactivo(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_inactivo]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoReunion(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_reunion]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoBaño(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_baño]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public double tiempoAlmuerzo(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_almuerzo]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }


        }

        public double tiempoSinCampaña(int idEmp, int idCamp, string fecha)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [t_sinCampaña]   FROM [Call_Center].[dbo].[jornada_laboral] where [jornada_laboral].id_empleado=" + idEmp + " and[jornada_laboral].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                Double horas = dameHoras(dt);

                return horas;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int totalLLamarDeNuevo(int idEmp, int idCamp, string fecha)
        {
            int total = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  [resultado]  FROM [dbo].[llamada] where [resultado] like 'LLamarDeNuevo'and [llamada].id_empleado=" + idEmp + " and[llamada].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                total = dt.Rows.Count;

                return total;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int totalNoAtendido(int idEmp, int idCamp, string fecha)
        {
            int total = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  [resultado]  FROM [dbo].[llamada] where [resultado] like 'No Atendido 'and [llamada].id_empleado=" + idEmp + " and[llamada].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                total = dt.Rows.Count;

                return total;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int totalNoVendido(int idEmp, int idCamp, string fecha)
        {
            int total = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  [resultado]  FROM [dbo].[llamada] where [resultado] like 'No Vendido'and [llamada].id_empleado=" + idEmp + " and[llamada].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                total = dt.Rows.Count;

                return total;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }
        
        public int totalVendido(int idEmp, int idCamp, string fecha)
        {
            int total = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  [resultado]  FROM [dbo].[llamada] where [resultado] like 'Vendido'and [llamada].id_empleado=" + idEmp + " and[llamada].id_campaña=" + idCamp, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                total = dt.Rows.Count;

                return total;



            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int[] llamadasCampañaEmpleado(int idemp, int idcamp, DateTime desde, DateTime hasta)
        {
            int[] res = new int[4];

            res[0] = totalLLamarDeNuevo(idemp, idcamp, "");
            res[1] = totalNoAtendido(idemp, idcamp, "");
            res[2] = totalNoVendido(idemp, idcamp, "");
            res[3] = totalVendido(idemp, idcamp, "");
           

            return res;
        }







        //SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where  where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);


        public double dameHoras(DataTable dt)
        {

            TimeSpan hours = new TimeSpan(00, 00, 00);


            int countRow = dt.Rows.Count;
            int countCol = dt.Columns.Count;

            for (int iCol = 0; iCol < countCol; iCol++)
            {
                DataColumn col = dt.Columns[iCol];
                
                for (int iRow = 0; iRow < countRow; iRow++)
                {
                    object cell = dt.Rows[iRow].ItemArray[iCol];
                    TimeSpan time = TimeSpan.Parse((cell).ToString());

                    hours = hours + time;

                }
              
            }
            return hours.TotalHours;
        }

        public int dameMinutos(DataTable dt)
        {
            int minuts = 0;
            TimeSpan time;
            int countRow = dt.Rows.Count;
            int countCol = dt.Columns.Count;

            for (int iCol = 0; iCol < countCol; iCol++)
            {
                DataColumn col = dt.Columns[iCol];

                for (int iRow = 0; iRow < countRow; iRow++)
                {
                    object cell = dt.Rows[iRow].ItemArray[iCol];
                    time = TimeSpan.Parse((cell).ToString());

                    minuts = minuts + Convert.ToInt32(time.TotalMinutes);

                }
            }
            return minuts;
        }

        public String  dameTiempo(DataTable dt)
        {
            TimeSpan minuts = new TimeSpan(0,0,0);
            TimeSpan time;


            int countRow = dt.Rows.Count;
            int countCol = dt.Columns.Count;

            for (int iCol = 0; iCol < countCol; iCol++)
            {
                DataColumn col = dt.Columns[iCol];

                for (int iRow = 0; iRow < countRow; iRow++)
                {
                    object cell = dt.Rows[iRow].ItemArray[iCol];
                    time = TimeSpan.Parse((cell).ToString());

                    minuts = minuts + time;

                }
            }


            return minuts.ToString();
        }



        #endregion




        #region funciones de EMPLEADO

        public bool updateEmpleado(clsEmpleado emp)//consulta y devuelve datos de un empleado
        {
            //updateEmpleado
            try
            {
                con.Open();
                string f1 = emp.Fecha_inicio.ToString("dd/M/yyyy");
                string f2 = emp.Fecha_naciemiento.ToString("dd/M/yyyy");

                SqlCommand cmd = new SqlCommand("UPDATE empleado SET nombre= '" + emp.Nombre + "',apellido = '" + emp.Apellido + "',dni= " + emp.Dni + ", = '" + f1 + "',jefe = " + emp.Jefe + ",password= " + emp.Password + ",f_nacimiento = '" + f2 + "',id_campaña = " + emp.Id_campaña + ",domicilio = '" + emp.Domicilio + "' ,telefono = " + emp.Telefono + ",mail = '" + emp.Mail + "' WHERE id_empleado=" + emp.Id_empleado, con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public clsEmpleado datos_empleado2(int id)//consulta y devuelve datos de un empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from empleado where id_empleado=@usuario", con);
                cmd.Parameters.AddWithValue("usuario", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clsEmpleado usuario = new clsEmpleado();
                usuario.Id_empleado = Convert.ToInt32(dt.Rows[0]["id_empleado"]);
                usuario.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);
                usuario.Apellido = Convert.ToString(dt.Rows[0]["apellido"]);
                usuario.Dni = Convert.ToInt32(dt.Rows[0]["dni"]);
                usuario.Fecha_inicio = (DateTime)dt.Rows[0]["f_inicio"];
                usuario.Jefe = Convert.ToInt32(dt.Rows[0]["jefe"]);
                usuario.Password = Convert.ToString(dt.Rows[0]["password"]);
                usuario.Fecha_naciemiento = (DateTime)(dt.Rows[0]["f_nacimiento"]);
                usuario.Id_campaña = Convert.ToInt32(dt.Rows[0]["id_campaña"]);
                usuario.Domicilio = Convert.ToString(dt.Rows[0]["domicilio"]);
                usuario.Telefono = Convert.ToString(dt.Rows[0]["telefono"]);
                usuario.Mail = Convert.ToString(dt.Rows[0]["mail"]);
                return usuario;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public clsEmpleado datos_empleado(int dni)//consulta y devuelve datos de un empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from empleado where dni=@usuario", con);
                cmd.Parameters.AddWithValue("usuario", dni);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clsEmpleado usuario = new clsEmpleado();
                usuario.Id_empleado = Convert.ToInt32(dt.Rows[0]["id_empleado"]);
                usuario.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);
                usuario.Apellido = Convert.ToString(dt.Rows[0]["apellido"]);
                usuario.Dni = Convert.ToInt32(dt.Rows[0]["dni"]);
                usuario.Fecha_inicio = (DateTime)dt.Rows[0]["f_inicio"];
                usuario.Jefe = Convert.ToInt32(dt.Rows[0]["jefe"]);
                usuario.Password = Convert.ToString(dt.Rows[0]["password"]);
                usuario.Fecha_naciemiento = (DateTime)(dt.Rows[0]["f_nacimiento"]);
                usuario.Fecha_eliminado = (string.IsNullOrEmpty(dt.Rows[0]["f_eliminado"].ToString())) ? DateTime.MinValue : (DateTime)(dt.Rows[0]["f_eliminado"]);
                usuario.Id_campaña = (string.IsNullOrEmpty(dt.Rows[0]["id_campaña"].ToString()))? -1 : Convert.ToInt32(dt.Rows[0]["id_campaña"]);
                usuario.Domicilio = Convert.ToString(dt.Rows[0]["domicilio"]);
                usuario.Telefono = Convert.ToString(dt.Rows[0]["telefono"]);
                usuario.Mail = Convert.ToString(dt.Rows[0]["mail"]);
                return usuario;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public int dniEmpleado(int id)//consulta y devuelve datos de un empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT dni from empleado where id_empleado=@usuario", con);
                cmd.Parameters.AddWithValue("usuario", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int dni = 0;
             
                dni = Convert.ToInt32(dt.Rows[0]["dni"]);
                
                return dni;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarEmpleados()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, empleado.nombre +' '+ apellido as Empleado, dni as DNI, campaña.nombre as 'Campaña actual', empleado.f_inicio as 'Fecha de ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento, empleado.f_eliminado as Eliminado " +
                    "FROM empleado LEFT JOIN campaña ON (empleado.id_campaña = campaña.id_campaña) WHERE jefe = 0", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listar_empleados_activos()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, empleado.nombre +' '+ apellido as Empleado, dni as DNI, empleado.id_campaña as '# Campaña', empleado.f_inicio as 'Fecha ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento" +
                    " FROM empleado WHERE jefe = 0 AND empleado.f_eliminado IS NULL", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarJefes()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, empleado.nombre +' '+ apellido as Empleado, dni as DNI, campaña.nombre as 'Campaña actual', empleado.f_inicio as 'Fecha de ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento " +
                    "FROM empleado LEFT JOIN campaña ON (empleado.id_campaña = campaña.id_campaña) WHERE jefe = 1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool insertar_empleado(clsEmpleado empleado)
        {
            try
            {
                string campaña = (empleado.Id_campaña == -1) ? "NULL" : empleado.Id_campaña.ToString();
                string f_inicio = empleado.Fecha_inicio.ToString("yyyy/MM/dd").Replace('-', '/');
                string f_nacimiento = empleado.Fecha_naciemiento.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO empleado(nombre, apellido, dni, f_inicio, jefe, password, f_nacimiento, id_campaña, domicilio, telefono, mail)" +
                    " VALUES(@nombre, @apellido, @dni, @f_inicio, @jefe, @password, @f_nacimiento, " + campaña + ", @domicilio, @telefono, @mail)", con);
                cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("dni", empleado.Dni);
                cmd.Parameters.AddWithValue("f_inicio", f_inicio);
                cmd.Parameters.AddWithValue("jefe", empleado.Jefe);
                cmd.Parameters.AddWithValue("password", empleado.Password);
                cmd.Parameters.AddWithValue("f_nacimiento", f_nacimiento);
                cmd.Parameters.AddWithValue("domicilio", empleado.Domicilio);
                cmd.Parameters.AddWithValue("telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("mail", empleado.Mail);
                return (cmd.ExecuteNonQuery() == 1) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool actualizar_empleado(clsEmpleado empleado)
        {
            try
            {
                string f_nac = empleado.Fecha_naciemiento.ToString("yyyy/MM/dd").Replace('-', '/');
                string f_ini = empleado.Fecha_inicio.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SET nombre = @nombre, apellido = @apellido, dni = @dni, telefono = @telefono, mail = @mail, @domicilio = @domicilio, f_nacimiento = @f_nacimiento, f_inicio = @f_inicio, id_campaña = @id_campaña" +
                    " WHERE id_empleado = @id_empleado", con);
                cmd.Parameters.AddWithValue("id_empleado", empleado.Id_empleado);
                cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("dni", empleado.Dni);
                cmd.Parameters.AddWithValue("telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("mail", empleado.Mail);
                cmd.Parameters.AddWithValue("domicilio", empleado.Domicilio);
                cmd.Parameters.AddWithValue("f_nacimiento", f_nac);
                cmd.Parameters.AddWithValue("f_inicio", f_ini);
                cmd.Parameters.AddWithValue("id_campaña", empleado.Id_campaña);
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool eliminar_empleado(clsEmpleado empleado)
        {
            try
            { 
                string f_eliminado = empleado.Fecha_eliminado.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SET f_eliminado = @f_eliminado" +
                    " WHERE id_empleado = @id_empleado", con);
                cmd.Parameters.AddWithValue("id_empleado", empleado.Id_empleado);
                cmd.Parameters.AddWithValue("f_eliminado", f_eliminado);
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool eliminar_empleados(List<int> ids_empleados)
        {
            try
            {
                string empleados = "(" + string.Join(",", ids_empleados.ToArray()) + ")";
                string f_eliminado = DateTime.Now.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE empleado SET f_eliminado = @f_eliminado WHERE id_empleado IN " + empleados, con);
                cmd.Parameters.AddWithValue("f_eliminado", f_eliminado);
                return (cmd.ExecuteNonQuery() == ids_empleados.Count) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool check_campaña(int idEmpleado, int idCampaña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM empleado where id_empleado=@id_empleado and id_campaña=@id_campaña", con);
                cmd.Parameters.AddWithValue("id_empleado", idEmpleado);
                cmd.Parameters.AddWithValue("id_campaña", idCampaña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                return (sda.Fill(dt) == 1)? true : false;
                //return (dt.Rows.Count == 1) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        
        public void actualizar_campaña_empleado(int idEmp, int idCamp)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SET id_campaña = @id_campaña WHERE id_empleado = @id_empleado", con);
                cmd.Parameters.AddWithValue("id_campaña", idCamp);
                cmd.Parameters.AddWithValue("id_empleado", idEmp);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Se actualizó correctamente la campaña asignada al empleado.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                msjError(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public bool actualizar_campaña_empleados(int id_campaña, List<int> l_empleados)
        {
            try
            {
                con.Open();
                string id_camp = (id_campaña == -1) ? "NULL" : id_campaña.ToString();
                string empleados = "(" + string.Join(",", l_empleados) + ")";
                SqlCommand cmd = new SqlCommand("UPDATE empleado SET id_campaña = " + id_camp + " WHERE id_empleado IN " + empleados, con);
                return (cmd.ExecuteNonQuery() == l_empleados.Count) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable obtenerCampañas()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre,id_campaña" +
                    " FROM campaña where f_fin >= convert(nvarchar(8), getdate(), 112)", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable obtenerCampañasDeEmpleado(int id)
        {
            /*hacer query distinct en llamadas  joineando con campañas de un empleado */
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [id_campaña],[nombre]FROM [dbo].[campaña]", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable historial_campañas(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct c.nombre,c.id_campaña   FROM [Call_Center].[dbo].[llamada] a join [Call_Center].[dbo].[empleado] e on (a.id_empleado=e.id_empleado) join [Call_Center].[dbo].[campaña] c on(a.id_campaña =c.id_campaña) where e.id_empleado=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable misCampañas(int id)
        {
            DataTable rendimientos = new DataTable();
            DataTable miembros = new DataTable();
            miembros = historial_campañas(id);

            rendimientos.Columns.Add("IdCampaña", typeof(int));
            rendimientos.Columns.Add("Campaña", typeof(String));
            rendimientos.Columns.Add("Ventas", typeof(float));
            rendimientos.Columns.Add("Efectividad", typeof(string));
            
            
            float promEfectividad = 0;
            int tot = 0;
           foreach (DataRow dtRow in miembros.Rows)
           {
                float[] cantLlamadas = LlamadasCampaña(id, Convert.ToInt32(dtRow.ItemArray[1]));
                float[] canVentas = VentasCampaña(id, Convert.ToInt32(dtRow.ItemArray[1]));
                float efectividad = Convert.ToInt32((canVentas[0] * 100) / cantLlamadas[0]);
                promEfectividad = promEfectividad + efectividad;
                tot = tot + 1;
                if (tot > 0) {
                    promEfectividad = promEfectividad / tot;
                }
                else {
                    efectividad = 0;
                }
                string ef = efectividad.ToString() + "%";
                rendimientos.Rows.Add(dtRow.ItemArray[1], dtRow.ItemArray[0], canVentas[0], ef);
           }
            return rendimientos;
        }

        #endregion


        #region funciones de CAMPAÑA
        public clsCampaña datos_campaña(int id_camp)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from campaña JOIN cliente ON (campaña.id_cliente = cliente.id_cliente) where campaña.id_campaña = @id_camp;", con);
                cmd.Parameters.AddWithValue("id_camp", id_camp);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clsCampaña campaña = new clsCampaña();
                campaña.Id_campaña = Convert.ToInt32(dt.Rows[0]["Id_campaña"]);
                campaña.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                campaña.Descripcion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                campaña.Precio = Convert.ToInt32(dt.Rows[0]["Precio"]);
                campaña.Fecha_inicio = Convert.ToDateTime(dt.Rows[0]["F_inicio"]);
                campaña.Fecha_fin = (dt.Rows[0]["F_fin"] != null)? Convert.ToDateTime(dt.Rows[0]["F_fin"]) : DateTime.MinValue;
                campaña.Id_cliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                campaña.NombreCliente = Convert.ToString(dt.Rows[0]["Nombre1"]);
                //campaña.Lider = Convert.ToInt32(dt.Rows[0]["Lider"]);
                return campaña;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public clsCampaña datos_campaña_empleado(int id_empleado)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from campaña c JOIN empleado e on (e.id_campaña=c.id_campaña) JOIN cliente cli on (c.id_cliente=cli.id_cliente) where e.id_empleado=@id_emp;", con);
                cmd.Parameters.AddWithValue("id_emp", id_empleado);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clsCampaña campaña = new clsCampaña();
                campaña.Id_campaña = Convert.ToInt32(dt.Rows[0]["Id_campaña"]);
                campaña.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                campaña.Descripcion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                campaña.Precio = Convert.ToInt32(dt.Rows[0]["Precio"]);
                campaña.Fecha_inicio = Convert.ToDateTime(dt.Rows[0]["f_inicio"]);
                campaña.Fecha_fin = Convert.ToDateTime(dt.Rows[0]["f_fin"]);
                campaña.Id_cliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                campaña.NombreCliente = Convert.ToString(dt.Rows[0]["Nombre2"]);
                campaña.Lider = Convert.ToInt32(dt.Rows[0]["Lider"]);
                return campaña;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool insertar_campaña(clsCampaña campaña)
        {
            try
            {
                string f_inicio = campaña.Fecha_inicio.ToString("yyyy/MM/dd").Replace('-', '/');
                string f_fin = campaña.Fecha_fin.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO campaña(nombre, descripcion, precio, f_inicio, f_fin, id_cliente)" +
                    " VALUES(@nombre, @descripcion, @precio, @f_inicio, @f_fin, @id_cliente);SELECT SCOPE_IDENTITY();", con); // id_especificacion?
                cmd.Parameters.AddWithValue("nombre", campaña.Nombre);
                cmd.Parameters.AddWithValue("descripcion", campaña.Descripcion);
                cmd.Parameters.AddWithValue("precio", campaña.Precio);
                cmd.Parameters.AddWithValue("f_inicio", f_inicio);
                cmd.Parameters.AddWithValue("f_fin", f_fin);
                cmd.Parameters.AddWithValue("id_cliente", campaña.Id_cliente);
                campaña.Id_campaña = Convert.ToInt32(cmd.ExecuteScalar());
                return true;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool actualizar_campaña(clsCampaña campaña)
        {
            try
            {
                string f_ini = campaña.Fecha_inicio.ToString("yyyy/MM/dd").Replace('-', '/');
                string f_fin = campaña.Fecha_fin.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SET nombre = @nombre, descripcion = @descripcion, precio = @precio, f_inicio = @f_ini, f_fin = @f_fin, id_cliente = @id_ciente" +
                    " WHERE id_campaña = @id_campaña", con);
                cmd.Parameters.AddWithValue("id_campaña", campaña.Id_campaña);
                cmd.Parameters.AddWithValue("nombre", campaña.Nombre);
                cmd.Parameters.AddWithValue("descripcion", campaña.Descripcion);
                cmd.Parameters.AddWithValue("precio", campaña.Precio);
                cmd.Parameters.AddWithValue("f_ini", f_ini);
                cmd.Parameters.AddWithValue("f_fin", f_fin);
                cmd.Parameters.AddWithValue("id_cliente", campaña.Id_cliente);
                //cmd.Parameters.AddWithValue("id_especificacion", campaña.);
                cmd.Parameters.AddWithValue("lider", campaña.Lider);
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarCampañas()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_campaña, campaña.nombre as Campaña, precio as Costo, f_inicio as Inicia, f_fin as Finaliza, cliente.nombre as Cliente, cliente.contacto as 'Contacto de cliente', descripcion as Descripcion, campaña.f_eliminado as Eliminado " +
                    "FROM campaña join cliente on (campaña.id_cliente = cliente.id_cliente)", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool eliminar_campañas(List<int> ids_campañas)
        {
            try
            {
                //string campañas = "(" + string.Join(",", ids_campañas) + ")";
                string f_eliminado = DateTime.Now.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE campaña SET f_eliminado = @f_eliminado WHERE id_campaña IN (@campañas)", con);
                cmd.Parameters.AddWithValue("f_eliminado", f_eliminado);
                cmd.Parameters.AddWithValue("campañas", string.Join(",", ids_campañas));
                return (cmd.ExecuteNonQuery() == ids_campañas.Count) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool check_lider(int id_campaña, int id_user)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM campaña WHERE id_campaña = @id_campaña AND lider = @id_empleado", con);
                cmd.Parameters.AddWithValue("id_campaña", id_campaña);
                cmd.Parameters.AddWithValue("id_empleado", id_user);
                return (cmd.ExecuteScalar() == null) ? false : true;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable miembros_de_campaña(int id_campaña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select  distinct (empleado.id_empleado), empleado.nombre +' '+ apellido as Empleado, dni as DNI, empleado.f_inicio as 'Fecha de ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento"//distinct empleado.id_empleado, empleado.nombre  + ' ' + empleado.apellido as Empleado
                    + " FROM llamada JOIN empleado ON (llamada.id_empleado = empleado.id_empleado) WHERE llamada.id_campaña = @id", con);
                cmd.Parameters.AddWithValue("id", id_campaña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable empleados_actuales_de_campaña(int id_campaña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, empleado.nombre +' '+ apellido as Empleado, dni as DNI, empleado.f_inicio as 'Fecha de ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento"
                    + " FROM empleado WHERE jefe = 0 AND id_campaña = @id", con);
                cmd.Parameters.AddWithValue("id", id_campaña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public float []  LlamadasCampaña(int idemp,int idcamp)
        {
            try
            {
                float[] cant = new float[2];
                con.Open();
                SqlCommand cmd = new SqlCommand("select  llamada.duracion from llamada join empleado on(llamada.id_empleado = empleado.id_empleado) where llamada.id_campaña=@idcamp and empleado.id_empleado=@idemp", con);
                cmd.Parameters.AddWithValue("@idemp", idemp);
                cmd.Parameters.AddWithValue("@idcamp", idcamp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant[0] = dt.Rows.Count;
                cant[1] = 0;
                foreach (DataRow dtRow in dt.Rows)
                {
                    object cell = dtRow.ItemArray[0];
                   TimeSpan  time = TimeSpan.Parse((cell).ToString());

                    cant[1] = cant[1] +Convert.ToInt32(time.TotalMinutes);

                }
                cant[1]= cant[1] / cant[0];


                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public float[] promedioLlamadasCamapaña(int idcamp)
        {
            try
            {
                float[] cant = new float[2];
                con.Open();
                SqlCommand cmd = new SqlCommand("select  llamada.duracion from llamada join empleado on(llamada.id_empleado = empleado.id_empleado) where llamada.id_campaña=@idcamp ", con);
                
                cmd.Parameters.AddWithValue("@idcamp", idcamp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant[0] = dt.Rows.Count;
                cant[1] = 0;
                foreach (DataRow dtRow in dt.Rows)
                {
                    object cell = dtRow.ItemArray[0];
                    TimeSpan time = TimeSpan.Parse((cell).ToString());

                    cant[1] = cant[1] + Convert.ToInt32(time.TotalMinutes);

                }
                cant[1] = cant[1] / cant[0];


                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

       

        public float[] VentasCampaña(int idemp, int idcamp)
        {
            try
            {
                float[] cant = new float[2];
                con.Open();
                SqlCommand cmd = new SqlCommand("select  llamada.duracion from llamada join empleado on(llamada.id_empleado = empleado.id_empleado) where llamada.id_campaña=@idcamp and empleado.id_empleado=@idemp and llamada.resultado='Vendido'", con);
                cmd.Parameters.AddWithValue("@idemp", idemp);
                cmd.Parameters.AddWithValue("@idcamp", idcamp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant[0] = dt.Rows.Count;
                cant[1] = 0;
                foreach (DataRow dtRow in dt.Rows)
                {
                    object cell = dtRow.ItemArray[0];
                    TimeSpan time = TimeSpan.Parse((cell).ToString());

                    cant[1] = cant[1] + Convert.ToInt32(time.TotalMinutes);

                }
                cant[1] = cant[1] / cant[0];


                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }        

        public string[] promedioVentasCamapaña( int idcamp)
        {
            try
            {
                
                string[] cant1 = new string[3];
                con.Open();
                SqlCommand cmd = new SqlCommand("select  llamada.duracion from llamada join empleado on(llamada.id_empleado = empleado.id_empleado) where llamada.id_campaña=@idcamp  and llamada.resultado='Vendido'", con);
            
                cmd.Parameters.AddWithValue("@idcamp", idcamp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                
                TimeSpan timefirst = new TimeSpan(00, 00, 00);

                foreach (DataRow dtRow in dt.Rows)
                {
                    object cell = dtRow.ItemArray[0];
                    TimeSpan time = TimeSpan.Parse((cell).ToString());
                    timefirst = timefirst + time;
                    
                    

                }
                
                    
                    cant1[0]=timefirst.ToString();//total tiempos de ventas
                    cant1[1] = dt.Rows.Count.ToString();//total ventas
                    float a =  timefirst.Minutes;
                    float b=dt.Rows.Count;
                    float prom = a / b;//promedio llamadas de ventas
                     cant1[2] = prom.ToString("0.00");

                //return cant;
                return cant1;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rendimientoCampaña(int id)
        {
            DataTable rendimientos = new DataTable();
            DataTable miembros = new DataTable(); 
            miembros = miembros_de_campaña(id);

            rendimientos.Columns.Add("Id", typeof(int));
            rendimientos.Columns.Add("Empleado", typeof(String));
            rendimientos.Columns.Add("Tiempo Productivo(min)", typeof(String));
            rendimientos.Columns.Add("Tiempo Improductivo(min)", typeof(String));
            rendimientos.Columns.Add("Tiempo de Espera(min)", typeof(String));
            rendimientos.Columns.Add("Ventas", typeof(float));
            rendimientos.Columns.Add("Efectividad", typeof(string));
            rendimientos.Columns.Add("Duracion llamadas Vendidas(min)", typeof(float));           
            rendimientos.Columns.Add("Duracion llamadas(min)", typeof(float));
            rendimientos.Columns.Add("PromedioEfect", typeof(float));

            float promEfectividad = 0;
            int tot = 0;
            foreach (DataRow dtRow in miembros.Rows)
            {
                int  idempleado =  Convert.ToInt32(dtRow.ItemArray[0]);
                float[] cantLlamadas = LlamadasCampaña(idempleado, id);
                string totProd = totalTiempoProductivo(idempleado,id);
                string totImp = totalTiempoImproductivo(idempleado,id);
                string espera = totalEspera(idempleado,id);
                float[] canVentas = VentasCampaña(idempleado, id);
                float efectividad = Convert.ToInt32((canVentas[0] * 100) / cantLlamadas[0]);

                promEfectividad = promEfectividad + efectividad;
                tot = tot + 1;

                if (tot > 0)
                {
                    promEfectividad = promEfectividad / tot;
                }
                else
                {
                    promEfectividad = 0;
                }

                rendimientos.Rows.Add(dtRow.ItemArray[0], dtRow.ItemArray[1], totProd,totImp,espera,canVentas[0],efectividad, canVentas[1], cantLlamadas[1], promEfectividad);
                
            }
            return rendimientos;
        }

        #endregion


        #region funciones de CLIENTES

        public DataTable listarClientes()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cliente, nombre as Cliente, cuil as CUIL, domicilio_legal as 'Domicilio Legal', contacto as 'Nombre de contacto', telefono as 'Telefono de contacto', mail as 'Mail de contacto', f_eliminado as Eliminado " +
                    "FROM cliente", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool actualizar_cliente(clsCliente cliente)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SET nombre = @nombre, cuil = @cuil, domicilio_legal = @domicilio_legal, contacto = @contacto, mail = @mail, telefono = @telefono" +
                    " WHERE id_cliente = @id_cliente", con);
                cmd.Parameters.AddWithValue("id_cliente", cliente.Id );
                cmd.Parameters.AddWithValue("nombre", cliente.Nombre );
                cmd.Parameters.AddWithValue("cuil", cliente.Cuil );
                cmd.Parameters.AddWithValue("domicilio_legal", cliente.Domicilio );
                cmd.Parameters.AddWithValue("contacto", cliente.Contacto );
                cmd.Parameters.AddWithValue("mail", cliente.Mail );
                cmd.Parameters.AddWithValue("telefono", cliente.Telefono );
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        public bool eliminar_clientes(List<int> ids_clientes)
        {
            try
            {
                string clientes = "(" + string.Join(",", ids_clientes.ToArray()) + ")";
                string f_eliminado = DateTime.Now.ToString("yyyy/MM/dd").Replace('-', '/');
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE cliente SET f_eliminado = @f_eliminado WHERE id_cliente IN " + clientes, con);
                cmd.Parameters.AddWithValue("f_eliminado", f_eliminado);
                return (cmd.ExecuteNonQuery() == ids_clientes.Count) ? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public clsCliente datos_cliente(int id_cliente)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from cliente where id_cliente = @id_cliente", con);
                cmd.Parameters.AddWithValue("id_cliente", id_cliente);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                clsCliente cliente = new clsCliente();
                cliente.Id = id_cliente;
                cliente.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                cliente.Cuil = Convert.ToInt32(dt.Rows[0]["Cuil"]);
                cliente.Contacto = Convert.ToString(dt.Rows[0]["Contacto"]);
                cliente.Mail = Convert.ToString(dt.Rows[0]["Mail"]);
                cliente.Telefono = Convert.ToInt32(dt.Rows[0]["Telefono"]);
                cliente.Domicilio = Convert.ToString(dt.Rows[0]["domicilio_legal"]);
                return cliente;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool insertar_cliente(clsCliente cliente)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO cliente(nombre,cuil,domicilio_legal,contacto,telefono,mail)" +
                    " VALUES(@nombre, @cuil, @domicilio, @contacto, @telefono, @mail)", con);
                cmd.Parameters.AddWithValue("nombre",cliente.Nombre);
                cmd.Parameters.AddWithValue("cuil",cliente.Cuil);
                cmd.Parameters.AddWithValue("domicilio",cliente.Domicilio);
                cmd.Parameters.AddWithValue("contacto",cliente.Contacto);
                cmd.Parameters.AddWithValue("telefono",cliente.Telefono);
                cmd.Parameters.AddWithValue("mail",cliente.Mail);
                return (cmd.ExecuteNonQuery() == 1)? true : false;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listado_campañas_cliente(int id_cliente)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT campaña.id_campaña, campaña.nombre, count(llamada.id_llamada) as 'Cant Llamadas', count (id_venta) as 'Cant Ventas'" +
                    " FROM campaña LEFT JOIN llamada ON (llamada.id_campaña = campaña.id_campaña) LEFT JOIN venta ON (venta.id_llamada = llamada.id_llamada)" +
                    " WHERE campaña.id_cliente = @id_cliente GROUP BY campaña.id_campaña, campaña.nombre", con);
                cmd.Parameters.AddWithValue("id_cliente", id_cliente);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #region funciones de LLAMADAS (+ programadas)

        public int obtener_id_llamada() // ELIMINAR ESTA FUNCION
        {
            try
            {
                int cant = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(*) as cantidad  from llamada", con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cant = Convert.ToInt32(dt.Rows[0][0]);
                cant++;
                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }
        }//obtengo el numero de llamadas y le sumo para tener un ID unico

        public int obtener_id_llamadaDeNuevo()
        {
            try
            {
                int cant = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(*) as cantidad  from LlamadaDeNuevo", con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cant = Convert.ToInt32(dt.Rows[0][0]);
                cant++;
                return cant;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }
        }//obtengo el numero de llamadas y le sumo para tener un ID unico
        
        public int insertar_llamada(clsLlamada llam)//nueva llamadaDenuevo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO llamada (id_contacto, id_campaña, duracion, t_espera, resultado, observaciones, fecha, id_empleado)" +
                    " VALUES (@idcontacto, @idcampaña, @duracion, @t_espera, @resultado, @observaciones, @fecha, @idempleado)", con);
                
                cmd.Parameters.AddWithValue("idcontacto", llam.Id_contacto);
                cmd.Parameters.AddWithValue("idcampaña", llam.Id_campaña);
                cmd.Parameters.AddWithValue("resultado", llam.Resultado);
                cmd.Parameters.AddWithValue("duracion", llam.Duracion_total);
                cmd.Parameters.AddWithValue("t_espera", llam.T_espera);
                cmd.Parameters.AddWithValue("observaciones", llam.Observaciones);
                cmd.Parameters.AddWithValue("fecha", llam.Fecha);
                cmd.Parameters.AddWithValue("idempleado", llam.Id_empleado);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
               // MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarLlamadas()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_llamada as #, e.nombre+' '+e.apellido as Empleado, cam.nombre as Campaña, cliente.nombre as Cliente, c.nombre +' '+ c.apellido as Destinatario, fecha as Fecha, duracion as Duracion, resultado as Resultado, observaciones as Observaciones " +
                    "FROM llamada l JOIN contacto c ON (l.id_contacto = c.id_contacto) JOIN campaña cam ON (l.id_campaña = cam.id_campaña) JOIN empleado e ON (l.id_empleado = e.id_empleado) JOIN cliente ON (cam.id_cliente = cliente.id_cliente)", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public clsLLamadaDeNuevo hayLLamadaEnEstaHora(DateTime fecha, int id_campaña)
        {
            clsLLamadaDeNuevo llmda = new clsLLamadaDeNuevo();
            int hora = fecha.Hour;
            int minuto = fecha.Minute;
            string fechallamada = fecha.ToString("yyyy/MM/dd").Replace('-', '/');
            int aux = (minuto / 10) + 1;
            minuto = aux * 10;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * from LlamadaDeNuevo ld JOIN llamada l ON (ld.idllamada = l.id_llamada) where l.id_campaña = @id_campaña AND ld.fecha=@fecha AND ((hora = @hora AND minutos <= @minutos) OR hora < @hora)", con);
                cmd.Parameters.AddWithValue("id_campaña", id_campaña);
                cmd.Parameters.AddWithValue("fecha", fechallamada);
                cmd.Parameters.AddWithValue("hora", hora);
                cmd.Parameters.AddWithValue("minutos", minuto);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    llmda.Id_nueva_llamada = -1;
                }
                else
                {
                    llmda.Id_nueva_llamada = Convert.ToInt32(dt.Rows[0]["IdNueva"]);
                    llmda.Id_empleado = Convert.ToInt32(dt.Rows[0]["IdEmpleado"]);
                    llmda.Id_contacto = Convert.ToInt32(dt.Rows[0]["IdContacto"]);
                    llmda.Id_llamada = Convert.ToInt32(dt.Rows[0]["IdLlamada"]);
                    llmda.Fecha = Convert.ToDateTime(dt.Rows[0]["Fecha"]); //(DateTime)dt.Rows[0]["Fecha"];
                    llmda.Hora = Convert.ToInt32(dt.Rows[0]["Hora"]);
                    llmda.Minutos = Convert.ToInt32(dt.Rows[0]["Minutos"]);
                    llmda.Observaciones = Convert.ToString(dt.Rows[0]["Observaciones"]);
                }
                return llmda;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void insertar_llamadaDeNuevi(clsLLamadaDeNuevo llam)//nueva llamadaDenuevo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LlamadaDeNuevo (idnueva, idempleado, idcontacto, idllamada, fecha, hora, minutos) values (@idnueva, @idempleado, @idcontacto, @idllamada, @fecha, @hora, @minutos)", con);

                cmd.Parameters.AddWithValue("idnueva", llam.Id_nueva_llamada);
                cmd.Parameters.AddWithValue("idempleado", llam.Id_empleado);
                cmd.Parameters.AddWithValue("idcontacto", llam.Id_contacto);
                cmd.Parameters.AddWithValue("idllamada", llam.Id_llamada);
                cmd.Parameters.AddWithValue("fecha", llam.Fecha);
                cmd.Parameters.AddWithValue("hora", llam.Hora);
                cmd.Parameters.AddWithValue("minutos", llam.Minutos);

                int result = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void eliminarLlamadaDeNuevo(int idnueva)//nueva llamadaDenuevo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LlamadaDeNuevo where idnueva=@idnueva", con);
                cmd.Parameters.AddWithValue("idnueva", idnueva);

                int result = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion


        #region funciones de JORNADA

        public List<clsJornada> buscar_jornadas(int empleado, DateTime fecha)
        {
            string fecha_consulta = String.Format("{0:yyyy-MM-dd}", fecha);
            try
            {
                List<clsJornada> jornadas = new List<clsJornada>();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT *, (select count(id_llamada) from llamada where fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantLlamadas, (select count(id_llamada) from llamada where resultado = 'Vendido' AND fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantVentas FROM jornada_laboral WHERE id_empleado = @id_empleado AND fecha = @fecha_consulta", con); //'2018-02-16'
                cmd.Parameters.AddWithValue("id_empleado", empleado);
                cmd.Parameters.AddWithValue("fecha_consulta", fecha_consulta);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    clsJornada jornada = new clsJornada();
                    jornada.Id_empleado = Convert.ToInt32(dr["id_empleado"]);
                    jornada.Id_campaña = Convert.ToInt32(dr["id_campaña"]);
                    jornada.Fecha = Convert.ToDateTime(dr["fecha"]);
                    jornada.T_atendiendo = TimeSpan.Parse(Convert.ToString(dr["t_atendiendo"]));
                    jornada.T_descanso = TimeSpan.Parse(Convert.ToString(dr["t_descanso"]));
                    jornada.T_reunion = TimeSpan.Parse(Convert.ToString(dr["t_reunion"]));
                    jornada.T_llenadoFormularios = TimeSpan.Parse(Convert.ToString(dr["t_llenadoFormularios"]));
                    jornada.T_sinContactos = TimeSpan.Parse(Convert.ToString(dr["t_sinContactos"]));
                    jornada.T_sinCampaña = TimeSpan.Parse(Convert.ToString(dr["t_sinCampaña"]));
                    jornada.T_inactivo = TimeSpan.Parse(Convert.ToString(dr["t_inactivo"]));
                    jornada.T_baño = TimeSpan.Parse(Convert.ToString(dr["t_baño"]));
                    jornada.T_capacitacion = TimeSpan.Parse(Convert.ToString(dr["t_capacitacion"]));
                    jornada.T_almuerzo = TimeSpan.Parse(Convert.ToString(dr["t_almuerzo"]));
                    jornada.Inicio_sesion = TimeSpan.Parse(Convert.ToString(dr["inicio_sesion"]));
                    jornada.CantLlamadas = Convert.ToInt32(dr["CantLlamadas"]);
                    jornada.CantVentas = Convert.ToInt32(dr["CantVentas"]);
                    jornada.Cierre_sesion = (string.IsNullOrEmpty(dr["cierre_sesion"].ToString())) ? TimeSpan.Parse("0") : TimeSpan.Parse(Convert.ToString(dr["cierre_sesion"]));
                    jornadas.Add(jornada);
                }
                return jornadas;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public clsJornada buscar_jornada(int empleado, int campaña, DateTime fecha)
        {
            string fecha_consulta = String.Format("{0:yyyy-MM-dd}", fecha);
            try
            {
                clsJornada jornada = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT *, (select count(id_llamada) from llamada where fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantLlamadas, (select count(id_llamada) from llamada where resultado = 'Vendido' AND fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantVentas FROM jornada_laboral" +
                    " WHERE id_empleado = @id_empleado AND fecha = @fecha_consulta AND id_campaña = @id_campaña", con); //'2018-02-16'
                cmd.Parameters.AddWithValue("id_empleado", empleado);
                cmd.Parameters.AddWithValue("id_campaña", campaña);
                cmd.Parameters.AddWithValue("fecha_consulta", fecha_consulta);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("La jornada para la fecha actual fue guardada. Los nuevos datos erán agregados a los valores existentes.", "Atención: Jornada existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    jornada = new clsJornada();
                    jornada.Id_empleado = Convert.ToInt32(dt.Rows[0]["id_empleado"]);
                    jornada.Id_campaña = Convert.ToInt32(dt.Rows[0]["id_campaña"]);
                    jornada.Fecha = Convert.ToDateTime(dt.Rows[0]["fecha"]);
                    jornada.T_atendiendo = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_atendiendo"]));
                    jornada.T_descanso = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_descanso"]));
                    jornada.T_reunion = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_reunion"]));
                    jornada.T_llenadoFormularios = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_llenadoFormularios"]));
                    jornada.T_sinContactos = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_sinContactos"]));
                    jornada.T_sinCampaña = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_sinCampaña"]));
                    jornada.T_inactivo = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_inactivo"]));
                    jornada.T_baño = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_baño"]));
                    jornada.T_capacitacion = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_capacitacion"]));
                    jornada.T_almuerzo = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["t_almuerzo"]));
                    jornada.Inicio_sesion = TimeSpan.Parse(Convert.ToString(dt.Rows[0]["inicio_sesion"]));
                    jornada.CantLlamadas = Convert.ToInt32(dt.Rows[0]["CantLlamadas"]);
                    jornada.CantVentas = Convert.ToInt32(dt.Rows[0]["CantVentas"]);
                    jornada.Cierre_sesion = (string.IsNullOrEmpty(dt.Rows[0]["cierre_sesion"].ToString())) ? TimeSpan.Parse("0") : TimeSpan.Parse(Convert.ToString(dt.Rows[0]["cierre_sesion"]));
                }
                return jornada;
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void insertar_jornada(clsJornada jornada)
        {
            try
            {
                string id_campaña = (jornada.Id_campaña == -1) ? "NULL" : jornada.Id_campaña.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO jornada_laboral (id_empleado,id_campaña,fecha,inicio_sesion,t_atendiendo,t_descanso,t_reunion,t_llenadoFormularios,t_sinContactos,t_sinCampaña,t_inactivo,t_baño,t_capacitacion,t_almuerzo)" +
                    " values (@id_empleado," + id_campaña + ",@fecha,@inicio_sesion,@t_atendiendo,@t_descanso,@t_reunion,@t_llenadoFormularios,@t_sinContactos,@t_sinCampaña,@t_inactivo,@t_baño,@t_capacitacion,@t_almuerzo)", con);

                cmd.Parameters.AddWithValue("id_empleado", jornada.Id_empleado);
                cmd.Parameters.AddWithValue("fecha", jornada.Fecha);
                cmd.Parameters.AddWithValue("inicio_sesion", jornada.Inicio_sesion);
                cmd.Parameters.AddWithValue("t_atendiendo", jornada.T_atendiendo);
                cmd.Parameters.AddWithValue("t_descanso", jornada.T_descanso);
                cmd.Parameters.AddWithValue("t_reunion", jornada.T_reunion);
                cmd.Parameters.AddWithValue("t_llenadoFormularios", jornada.T_llenadoFormularios);
                cmd.Parameters.AddWithValue("t_sinContactos", jornada.T_sinContactos);
                cmd.Parameters.AddWithValue("t_sinCampaña", jornada.T_sinCampaña);
                cmd.Parameters.AddWithValue("t_inactivo", jornada.T_inactivo);
                cmd.Parameters.AddWithValue("t_baño", jornada.T_baño);
                cmd.Parameters.AddWithValue("t_capacitacion", jornada.T_capacitacion);
                cmd.Parameters.AddWithValue("t_almuerzo", jornada.T_almuerzo);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se creó el registro para la jornada de la fecha actual.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void actualizar_jornada(clsJornada jornada)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE jornada_laboral SET t_atendiendo=@t_atendiendo,t_descanso=@t_descanso,t_reunion=@t_reunion,t_llenadoFormularios=@t_llenadoFormularios,t_sinContactos=@t_sinContactos,t_sinCampaña=@t_sinCampaña,t_inactivo=@t_inactivo,t_baño=@t_baño,t_capacitacion=@t_capacitacion,t_almuerzo=@t_almuerzo,cierre_sesion=@cierre_sesion" +
                    " WHERE id_empleado = @id_empleado AND fecha = @fecha AND id_campaña = @id_campaña", con);//fecha='2018-02-16'", con);

                cmd.Parameters.AddWithValue("id_empleado", jornada.Id_empleado);
                cmd.Parameters.AddWithValue("id_campaña", jornada.Id_campaña);
                cmd.Parameters.AddWithValue("fecha", jornada.Fecha);
                cmd.Parameters.AddWithValue("t_atendiendo", jornada.T_atendiendo);
                cmd.Parameters.AddWithValue("t_descanso", jornada.T_descanso);
                cmd.Parameters.AddWithValue("t_reunion", jornada.T_reunion);
                cmd.Parameters.AddWithValue("t_llenadoFormularios", jornada.T_llenadoFormularios);
                cmd.Parameters.AddWithValue("t_sinContactos", jornada.T_sinContactos);
                cmd.Parameters.AddWithValue("t_sinCampaña", jornada.T_sinCampaña);
                cmd.Parameters.AddWithValue("t_inactivo", jornada.T_inactivo);
                cmd.Parameters.AddWithValue("t_baño", jornada.T_baño);
                cmd.Parameters.AddWithValue("t_capacitacion", jornada.T_capacitacion);
                cmd.Parameters.AddWithValue("t_almuerzo", jornada.T_almuerzo);
                cmd.Parameters.AddWithValue("cierre_sesion", jornada.Cierre_sesion);

                if (cmd.ExecuteNonQuery() == 1) // CHECK que devuelva 1, sino no se updateo
                {
                    MessageBox.Show("Actualización a la jornada de la fecha.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public TimeSpan calcular_tiempo_espera_total(int empleado, DateTime fecha)
        {
            string fecha_consulta = String.Format("{0:yyyy-MM-dd}", fecha);
            try
            {
                TimeSpan espera = TimeSpan.Zero;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_espera FROM llamada WHERE id_empleado = @id_empleado AND fecha = @fecha_consulta", con);
                cmd.Parameters.AddWithValue("id_empleado", empleado);
                cmd.Parameters.AddWithValue("fecha_consulta", fecha_consulta);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        string aux = string.IsNullOrEmpty((dr["t_espera"]).ToString()) ? "0" : Convert.ToString(dr["t_espera"]);
                        espera = espera.Add(TimeSpan.Parse(aux));
                    }
                }
                return espera;
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                return TimeSpan.Zero;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #region Otras funciones

        public void msjError(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion




        #region Estadisticas 

        #region -> Cliente
            public List<clsEstadisticas> numeros_cliente(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT count(distinct campaña.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', (SELECT count(id_llamada) FROM llamada JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) where campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha) as 'Cant llamadas'" +
                        " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT count(distinct campaña.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', (SELECT count(id_llamada) FROM llamada JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) where campaña.id_cliente = @id_cliente AND llamada.fecha >= @fecha) as 'Cant llamadas'" +
                        " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha >= @fecha AND llamada.fecha <= @fecha_hasta";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_cliente", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsEstadisticas> arreglo = new List<clsEstadisticas>();
                        foreach (DataColumn dc in dt.Columns)
                        {
                            clsEstadisticas aux = new clsEstadisticas();
                            aux.Clave = dc.ColumnName;
                            aux.Valor = (float)Convert.ToDouble(dt.Rows[0][dc.ColumnName]);
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }

            public List<clsEstadisticas> campañas_cliente(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron a partir de ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                        " FROM venta JOIN llamada ON (venta.id_llamada = llamada.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha" +
                        " GROUP BY campaña.id_campaña,campaña.nombre", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                        " FROM Call_Center.dbo.venta JOIN Call_Center.dbo.llamada ON (venta.id_llamada = llamada.id_llamada) JOIN Call_Center.dbo.campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha" +
                        " GROUP BY campaña.id_campaña,campaña.nombre";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_cliente", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsEstadisticas> arreglo = new List<clsEstadisticas>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            clsEstadisticas aux = new clsEstadisticas();
                            aux.Clave = Convert.ToString(dr["nombre"]);
                            aux.Valor = (float)Convert.ToDouble(dr["Ventas"]);
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }

            public List<clsJornada> jornadas_cliente(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM jornada_laboral JOIN llamada ON (jornada_laboral.id_empleado = llamada.id_empleado AND jornada_laboral.fecha = llamada.fecha) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND jornada_laboral.fecha = @fecha", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT * FROM jornada_laboral JOIN llamada ON (jornada_laboral.id_empleado = llamada.id_empleado AND jornada_laboral.fecha = llamada.fecha) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                        " WHERE campaña.id_cliente = @id_cliente AND jornada_laboral.fecha >= @fecha";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_cliente", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsJornada> arreglo = new List<clsJornada>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            clsJornada aux = new clsJornada();
                            aux.Id_empleado = Convert.ToInt32(dr["id_empleado"]);
                            aux.Id_campaña = (string.IsNullOrEmpty(dr["id_campaña"].ToString()))? -1 : Convert.ToInt32(dr["id_campaña"]);
                            aux.Fecha = Convert.ToDateTime(dr["fecha"]);
                            aux.T_atendiendo = TimeSpan.Parse(Convert.ToString(dr["t_atendiendo"]));
                            aux.T_descanso = TimeSpan.Parse(Convert.ToString(dr["t_descanso"]));
                            aux.T_reunion = TimeSpan.Parse(Convert.ToString(dr["t_reunion"]));
                            aux.T_llenadoFormularios = TimeSpan.Parse(Convert.ToString(dr["t_llenadoFormularios"]));
                            aux.T_sinContactos = TimeSpan.Parse(Convert.ToString(dr["t_sinContactos"]));
                            aux.T_sinCampaña = TimeSpan.Parse(Convert.ToString(dr["t_sinCampaña"]));
                            aux.T_inactivo = TimeSpan.Parse(Convert.ToString(dr["t_inactivo"]));
                            aux.T_baño = TimeSpan.Parse(Convert.ToString(dr["t_baño"]));
                            aux.T_capacitacion = TimeSpan.Parse(Convert.ToString(dr["t_capacitacion"]));
                            aux.T_almuerzo = TimeSpan.Parse(Convert.ToString(dr["t_almuerzo"]));
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        #endregion

        #region -> Empleado
            public List<clsEstadisticas> numeros_empleado(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT count(distinct jornada_laboral.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', count(llamada.id_llamada) as 'Cant llamadas'" +
                        " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN jornada_laboral ON (llamada.id_campaña = jornada_laboral.id_campaña)" +
                        " WHERE jornada_laboral.id_empleado = @id_empleado AND llamada.fecha = @fecha", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT count(distinct jornada_laboral.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', count(llamada.id_llamada) as 'Cant llamadas'" +
                        " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN jornada_laboral ON (llamada.id_campaña = jornada_laboral.id_campaña)" +
                        " WHERE jornada_laboral.id_empleado = @id_empleado  AND llamada.fecha >= @fecha AND llamada.fecha <= @fecha_hasta";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_empleado", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsEstadisticas> arreglo = new List<clsEstadisticas>();
                        foreach (DataColumn dc in dt.Columns)
                        {
                            clsEstadisticas aux = new clsEstadisticas();
                            aux.Clave = dc.ColumnName;
                            aux.Valor = (float)Convert.ToDouble(dt.Rows[0][dc.ColumnName]);
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }

            public List<clsEstadisticas> campañas_empleado(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron a partir de ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                        " FROM venta JOIN llamada ON (venta.id_llamada = llamada.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) JOIN jornada_laboral ON (campaña.id_campaña = jornada_laboral.id_campaña)" +
                        " WHERE jornada_laboral.id_empleado = @id_empleado AND llamada.fecha = @fecha" +
                        " GROUP BY campaña.id_campaña,campaña.nombre", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                        " FROM venta JOIN llamada ON (venta.id_llamada = llamada.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) JOIN jornada_laboral ON (campaña.id_campaña = jornada_laboral.id_campaña)" +
                        " WHERE jornada_laboral.id_empleado = @id_empleado AND llamada.fecha >= @fecha AND llamada.fecha <= @fecha_hasta" +
                        " GROUP BY campaña.id_campaña,campaña.nombre";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_empleado", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsEstadisticas> arreglo = new List<clsEstadisticas>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            clsEstadisticas aux = new clsEstadisticas();
                            aux.Clave = Convert.ToString(dr["nombre"]);
                            aux.Valor = (float)Convert.ToDouble(dr["Ventas"]);
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }

            public List<clsJornada> jornadas_empleado(int id, DateTime fechaDesde, DateTime fechaHasta)
            {
                // No mide las campañas que arrancaron ese día o que estan activas ese día.
                try
                {
                    string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM jornada_laboral WHERE jornada_laboral.id_empleado = @id_empleado AND jornada_laboral.fecha = @fecha", con);
                    if (fechaHasta != DateTime.MinValue)
                    {
                        string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                        cmd.CommandText = "SELECT * FROM jornada_laboral WHERE jornada_laboral.id_empleado = @id_empleado AND jornada_laboral.fecha >= @fecha AND jornada_laboral.fecha <= @fecha_hasta";
                        cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                    }
                    cmd.Parameters.AddWithValue("id_empleado", id);
                    cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        List<clsJornada> arreglo = new List<clsJornada>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            clsJornada aux = new clsJornada();
                            aux.Id_empleado = Convert.ToInt32(dr["id_empleado"]);
                            aux.Fecha = Convert.ToDateTime(dr["fecha"]);
                            aux.Id_campaña = (string.IsNullOrEmpty(dr["id_campaña"].ToString()))? -1 : Convert.ToInt32(dr["id_campaña"]);

                            aux.T_atendiendo = TimeSpan.Parse(Convert.ToString(dr["t_atendiendo"]));
                            aux.T_descanso = TimeSpan.Parse(Convert.ToString(dr["t_descanso"]));
                            aux.T_reunion = TimeSpan.Parse(Convert.ToString(dr["t_reunion"]));
                            aux.T_llenadoFormularios = TimeSpan.Parse(Convert.ToString(dr["t_llenadoFormularios"]));
                            aux.T_sinContactos = TimeSpan.Parse(Convert.ToString(dr["t_sinContactos"]));
                            aux.T_sinCampaña = TimeSpan.Parse(Convert.ToString(dr["t_sinCampaña"]));
                            aux.T_inactivo = TimeSpan.Parse(Convert.ToString(dr["t_inactivo"]));
                            aux.T_baño = TimeSpan.Parse(Convert.ToString(dr["t_baño"]));
                            aux.T_capacitacion = TimeSpan.Parse(Convert.ToString(dr["t_capacitacion"]));
                            aux.T_almuerzo = TimeSpan.Parse(Convert.ToString(dr["t_almuerzo"]));
                            arreglo.Add(aux);
                        }
                        return arreglo;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    msjError(e.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        #endregion

        #region -> Campaña
        public List<clsEstadisticas> numeros_campaña(int id, DateTime fechaDesde, DateTime fechaHasta)
        {
            // No mide las campañas que arrancaron ese día o que estan activas ese día.
            try
            {
                string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(distinct campaña.id_campaña) 'Cant de campañas', count(id_venta) as 'Cant ventas', count(llamada.id_llamada) as 'Cant llamadas'" +
                    " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) " +
                    " WHERE llamada.id_campaña = @id_campaña AND llamada.fecha = @fecha", con);
                if (fechaHasta != DateTime.MinValue)
                {
                    string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                    cmd.CommandText = "SELECT count(distinct campaña.id_campaña) 'Cant de campañas', count(id_venta) as 'Cant ventas', count(llamada.id_llamada) as 'Cant llamadas'" +
                    " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) " +
                    " WHERE llamada.id_campaña = @id_campaña AND llamada.fecha >= @fecha AND llamada.fecha <= @fecha_hasta";
                    cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                }
                cmd.Parameters.AddWithValue("id_campaña", id);
                cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    List<clsEstadisticas> arreglo = new List<clsEstadisticas>();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        clsEstadisticas aux = new clsEstadisticas();
                        aux.Clave = dc.ColumnName;
                        aux.Valor = (float)Convert.ToDouble(dt.Rows[0][dc.ColumnName]);
                        arreglo.Add(aux);
                    }
                    return arreglo;
                }
                return null;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<clsJornada> jornadas_campaña(int id, DateTime fechaDesde, DateTime fechaHasta)
        {
            // No mide las campañas que arrancaron ese día o que estan activas ese día.
            try
            {
                string fecha_parseada1 = String.Format("{0:yyyy-MM-dd}", fechaDesde);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM jornada_laboral WHERE jornada_laboral.id_campaña = @id_campaña AND jornada_laboral.fecha = @fecha", con);
                if (fechaHasta != DateTime.MinValue)
                {
                    string fecha_parseada2 = String.Format("{0:yyyy-MM-dd}", fechaHasta);
                    cmd.CommandText = "SELECT * FROM jornada_laboral WHERE jornada_laboral.id_campaña = @id_campaña AND jornada_laboral.fecha >= @fecha AND jornada_laboral.fecha <= @fecha_hasta";
                    cmd.Parameters.AddWithValue("fecha_hasta", fecha_parseada2);
                }
                cmd.Parameters.AddWithValue("id_campaña", id);
                cmd.Parameters.AddWithValue("fecha", fecha_parseada1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    List<clsJornada> arreglo = new List<clsJornada>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        clsJornada aux = new clsJornada();
                        aux.Id_empleado = Convert.ToInt32(dr["id_empleado"]);
                        aux.Fecha = Convert.ToDateTime(dr["fecha"]);
                        aux.Id_campaña = Convert.ToInt32(dr["id_campaña"]);

                        aux.T_atendiendo = TimeSpan.Parse(Convert.ToString(dr["t_atendiendo"]));
                        aux.T_descanso = TimeSpan.Parse(Convert.ToString(dr["t_descanso"]));
                        aux.T_reunion = TimeSpan.Parse(Convert.ToString(dr["t_reunion"]));
                        aux.T_llenadoFormularios = TimeSpan.Parse(Convert.ToString(dr["t_llenadoFormularios"]));
                        aux.T_sinContactos = TimeSpan.Parse(Convert.ToString(dr["t_sinContactos"]));
                        aux.T_sinCampaña = TimeSpan.Parse(Convert.ToString(dr["t_sinCampaña"]));
                        aux.T_inactivo = TimeSpan.Parse(Convert.ToString(dr["t_inactivo"]));
                        aux.T_baño = TimeSpan.Parse(Convert.ToString(dr["t_baño"]));
                        aux.T_capacitacion = TimeSpan.Parse(Convert.ToString(dr["t_capacitacion"]));
                        aux.T_almuerzo = TimeSpan.Parse(Convert.ToString(dr["t_almuerzo"]));
                        arreglo.Add(aux);
                    }
                    return arreglo;
                }
                return null;
            }
            catch (Exception e)
            {
                msjError(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #endregion
    }

}