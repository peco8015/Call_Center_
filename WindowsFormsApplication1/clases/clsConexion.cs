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
        string conx = @"Data Source=CLAUDIO\SQLEXPRESS;Initial Catalog=Call_Center;Integrated Security=True";


        public clsConexion()
        { con = new SqlConnection(conx); }
        

        public bool logear(int dni, string pss)
        {
            bool logeado = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre,password,jefe from empleado where dni=@usuario and password=@password", con);
                cmd.Parameters.AddWithValue("usuario", dni);
                cmd.Parameters.AddWithValue("password", pss);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                logeado = dt.Rows.Count == 1? true : false; //si user y pass son correctos
                return logeado;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
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
                    contacto.Fecha_nac = (DateTime)dt.Rows[0][4];
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

                cmd.Parameters.AddWithValue("id_venta", venta.IdVenta);
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
        
        #region Funciones de tiempo  CHEKC HECK CHECK
        public int tiempoHoyProductivo(DateTime hoy,int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DATEPART(MINUTE, t_atendiendo) + DATEPART(HOUR, t_atendiendo) * 60 + DATEPART(MINUTE, t_reunion) + DATEPART(HOUR, t_reunion) * 60 + DATEPART(MINUTE, t_llenadoFormularios) + DATEPART(HOUR, t_llenadoFormularios) * 60 + DATEPART(MINUTE, t_capacitacion) + DATEPART(HOUR, t_capacitacion) * 60   as 'TotalTime' from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where jornada_laboral.id_empleado =" + id+" and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant = Convert.ToInt32(dt.Rows[0][0]);





                return cant;


            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoHoyImproductivo(DateTime hoy)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DATEPART(MINUTE, t_descanso) + DATEPART(HOUR, t_descanso) * 60 + DATEPART(MINUTE, t_sinContactos) + DATEPART(HOUR, t_sinContactos) * 60 + DATEPART(MINUTE, t_sinCampaña) + DATEPART(HOUR, t_sinCampaña) * 60 + DATEPART(MINUTE, t_inactivo) + DATEPART(HOUR, t_inactivo) * 60 + DATEPART(MINUTE, t_baño) + DATEPART(HOUR, t_baño) * 60 + DATEPART(MINUTE, t_almuerzo) + DATEPART(HOUR, t_almuerzo) * 60  as 'TotalTime' from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado  where fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cant = Convert.ToInt32(dt.Rows[0][0]);





                return cant;


            }

            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoSemanaProductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();
            

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion,t_reunion,t_llenadoFormularios,t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where fecha between DATEADD(wk,DATEDIFF(wk,0,GETDATE()),0) and DATEADD(wk,DATEDIFF(wk,0,GETDATE()),6) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                
                int minutos = 0;

               minutos = dameMinutos(dt);




                return minutos;


            }

            catch (Exception e)
            {
                //// MessageBox.Show(e.Message);
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoSemanaImproductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT   t_descanso, t_sinContactos, t_sinCampaña,t_inactivo, t_baño,  t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where fecha between DATEADD(wk,DATEDIFF(wk,0,GETDATE()),0) and DATEADD(wk,DATEDIFF(wk,0,GETDATE()),6) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);




                return minutos;



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

        public int tiempoMesProductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion,t_reunion,t_llenadoFormularios,t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);




                return minutos;



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

        public int tiempoMesImproductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT   t_descanso, t_sinContactos, t_sinCampaña,t_inactivo, t_baño,  t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);




                return minutos;



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

        public int tiempoAñoProductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion,t_reunion,t_llenadoFormularios,t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);




                return minutos;



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


        public int tiempoAñoImproductivo(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT   t_descanso, t_sinContactos, t_sinCampaña,t_inactivo, t_baño,  t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;

                minutos = dameMinutos(dt);




                return minutos;



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

        public int tiempoDetalleCapacitacionHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_capacitacion   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

               
                

                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleFormularioHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_llenadoFormularios   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleAtendiendoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_atendiendo   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleReunionHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_reunion   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleDescansoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_descanso   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleSinContactoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_sinContactos   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


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

        public int tiempoDetalleSinCampañaHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_sinCampaña   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


            }

            catch (Exception e)
            {
                // //////MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleInactivoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_inactivo   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleBañoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_baño   FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAlmuerzoHoyProductivo(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int cant = 0;
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT t_almuerzo  FROM jornada_laboral, empleado  where jornada_laboral.id_empleado =" + id + " and fecha ='" + fecha + "'", con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);




                TimeSpan time = TimeSpan.Parse((dt.Rows[0][0]).ToString());

                cant = Convert.ToInt32(time.TotalMinutes);




                return cant;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

 /*semana*/    public int tiempoDetalleCapacitacionSemana( int id)
        {

            clsCampaña campaña = new clsCampaña();
           
           

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                

                int minutos = 0;
                minutos = dameMinutos(dt);
                

                return minutos;
                                         


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleFormularioSemana( int id)
        {

            clsCampaña campaña = new clsCampaña();
           
           

            try
            {
                con.Open(); 

                SqlCommand cmd = new SqlCommand("select t_llenadoFormularios from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAtendiendoSemana(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleReunionSemana(int id)
        {

            clsCampaña campaña = new clsCampaña();
            

            try
            {
                con.Open(); 
              SqlCommand cmd = new SqlCommand("select t_reunion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);




                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleDescansoSemana(int id)
        {

            clsCampaña campaña = new clsCampaña();
           

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_descanso from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinContactoSemana( int id)
        {

            clsCampaña campaña = new clsCampaña();
         

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinContactos from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);
             

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;

            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinCampañaSemana(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinCampaña from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleInactivoSemana(int id)
        {

            clsCampaña campaña = new clsCampaña();
      

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_inactivo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleBañoSemana( int id)
        {

            clsCampaña campaña = new clsCampaña();
     

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_baño from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAlmuerzoSemana( int id)
        {

            clsCampaña campaña = new clsCampaña();
         

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(ww, Fecha) = datepart(ww, getdate())  and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

    /**/    public int tiempoDetalleCapacitacionMes(int id)
        {

            clsCampaña campaña = new clsCampaña();



            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleFormularioMes(int id)
        {

            clsCampaña campaña = new clsCampaña();



            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select t_llenadoFormularios from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAtendiendoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleReunionMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_reunion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);




                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleDescansoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_descanso from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinContactoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinContactos from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;

            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinCampañaMes(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinCampaña from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleInactivoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_inactivo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleBañoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_baño from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAlmuerzoMes(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleCapacitacionAño(int id)
        {

            clsCampaña campaña = new clsCampaña();



            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);

                //SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where  where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleFormularioAño(int id)
        {

            clsCampaña campaña = new clsCampaña();



            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select t_llenadoFormularios from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAtendiendoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_atendiendo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;



            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleReunionAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_reunion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);




                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleDescansoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_descanso from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinContactoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinContactos from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;

            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleSinCampañaAño(int id)
        {

            clsCampaña campaña = new clsCampaña();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_sinCampaña from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleInactivoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_inactivo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(mm, Fecha) = datepart(mm, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;


            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleBañoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_baño from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }

        public int tiempoDetalleAlmuerzoAño(int id)
        {

            clsCampaña campaña = new clsCampaña();


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select t_almuerzo from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                int minutos = 0;
                minutos = dameMinutos(dt);


                return minutos;





            }

            catch (Exception e)
            {
               // MessageBox.Show(e.Message);//
                return 0000;
            }
            finally
            {
                con.Close();
            }

        }


        //SqlCommand cmd = new SqlCommand("select t_capacitacion from jornada_laboral INNER Join  empleado on empleado.id_empleado = jornada_laboral.id_empleado where  where datepart(yy, Fecha) = datepart(yy, getdate()) and jornada_laboral.id_empleado=" + id, con);



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


        #endregion




        #region funciones de EMPLEADO

        public clsEmpleado datos_empleado(int dni)//consulta y devuelve datos de un empleado
        {
            //updateEmpleado
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
                usuario.FechaInicio = (DateTime)dt.Rows[0]["f_comienza"];
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
        
        public DataTable listarEmpleados()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, empleado.nombre +' '+ apellido as Empleado, dni as DNI, campaña.nombre as 'Campaña actual', f_comienza as 'Fecha de ingreso', telefono as Telefono, mail as Mail, f_nacimiento as Nacimiento " +
                    "FROM empleado JOIN campaña ON (empleado.id_campaña = campaña.id_campaña) WHERE jefe = 0", con);
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

        public DataTable filtro_empleados(string txtinput)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado,nombre,apellido,dni,f_comienza as Inicio ,telefono,mail,domicilio FROM empleado where nombre like @input or apellido like @input or dni like @input", con);
                cmd.Parameters.AddWithValue("input", txtinput);
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
                sda.Fill(dt);
                return (dt.Rows.Count == 1) ? true : false;
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

        public bool  updateEmpleado(clsEmpleado emp)//consulta y devuelve datos de un empleado
        {
            //updateEmpleado
            try
            {
                con.Open();
                string f1 = emp.FechaInicio.ToString("dd/M/yyyy");
                string f2 =emp.Fecha_naciemiento.ToString("dd/M/yyyy");

                SqlCommand cmd = new SqlCommand("UPDATE empleado SET nombre= '"+emp.Nombre+"',apellido = '"+emp.Apellido+"',dni= "+emp.Dni+",f_comienza = '"+ f1 + "',jefe = "+emp.Jefe+",password= "+emp.Password+",f_nacimiento = '"+ f2 + "',id_campaña = "+emp.Id_campaña+",domicilio = '"+emp.Domicilio+"' ,telefono = "+emp.Telefono+",mail = '"+emp.Mail+"' WHERE id_empleado="+emp.Id_empleado, con);
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

        public DataTable obtenerCampañas()
        {
            try
            {


          
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre,id_campaña FROM campaña where f_fin >= convert(nvarchar(8), getdate(), 112)", con);

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
                campaña.IdCampaña = Convert.ToInt32(dt.Rows[0]["Id_campaña"]);
                campaña.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                campaña.Descripion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                campaña.Precio = Convert.ToInt32(dt.Rows[0]["Precio"]);
                campaña.Fecha_inicio = Convert.ToDateTime(dt.Rows[0]["F_inicio"]);
                campaña.Fecha_fin = (dt.Rows[0]["F_fin"] != null)? Convert.ToDateTime(dt.Rows[0]["F_fin"]) : DateTime.MinValue;
                campaña.IdCliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                campaña.NombreCliente = Convert.ToString(dt.Rows[0]["Nombre1"]);
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
                campaña.IdCampaña = Convert.ToInt32(dt.Rows[0]["Id_campaña"]);
                campaña.Nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                campaña.Descripion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                campaña.Precio = Convert.ToInt32(dt.Rows[0]["Precio"]);
                campaña.NombreCliente = Convert.ToString(dt.Rows[0]["Nombre2"]);
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

        public DataTable listarCampañas()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_campaña, campaña.nombre as Campaña, precio as Costo, f_inicio as Inicia, f_fin as Finaliza, cliente.nombre as Cliente, cliente.contacto as 'Contacto de cliente', descripcion as Descripcion " +
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

        #endregion


        #region funciones de CLIENTES

        public DataTable listarClientes()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cliente, nombre as Cliente, cuil as CUIL, domicilioLegal as 'Domicilio Legal', contacto as 'Nombre de contacto', telefono as 'Telefono de contacto', mail as 'Mail de contacto' " +
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
                cliente.Domicilio = Convert.ToString(dt.Rows[0]["DomicilioLegal"]);
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

        #endregion


        #region funciones de LLAMADAS (+ programadas)

        public int obtener_id_llamada()
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
        
        public void insertar_llamada(clsLllamada llam)//nueva llamadaDenuevo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO llamada (id_llamada, id_contacto, id_campaña, duracion,resultado, observaciones, fecha,id_empleado) values (@idllamada, @idcontacto, @idcampaña, @duracion,@resultado, @observaciones,@fecha,@idempleado)", con);

                cmd.Parameters.AddWithValue("idllamada", llam.Id_llamada);
                cmd.Parameters.AddWithValue("idcontacto", llam.Id_contacto);
                cmd.Parameters.AddWithValue("idcampaña", llam.Id_campaña);
                cmd.Parameters.AddWithValue("resultado", llam.Resultado);
                cmd.Parameters.AddWithValue("duracion", llam.Duracion);
                cmd.Parameters.AddWithValue("observaciones", llam.Observaciones);
                cmd.Parameters.AddWithValue("fecha", llam.Fecha);
                cmd.Parameters.AddWithValue("idempleado", llam.Id_empleado);

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
                    llmda.IdNuevallamada = -1;
                }
                else
                {
                    llmda.IdNuevallamada = Convert.ToInt32(dt.Rows[0]["IdNueva"]);
                    llmda.IdEmpleado = Convert.ToInt32(dt.Rows[0]["IdEmpleado"]);
                    llmda.IdContacto = Convert.ToInt32(dt.Rows[0]["IdContacto"]);
                    llmda.IdLlamada = Convert.ToInt32(dt.Rows[0]["IdLlamada"]);
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

                cmd.Parameters.AddWithValue("idnueva", llam.IdNuevallamada);
                cmd.Parameters.AddWithValue("idempleado", llam.IdEmpleado);
                cmd.Parameters.AddWithValue("idcontacto", llam.IdContacto);
                cmd.Parameters.AddWithValue("idllamada", llam.IdLlamada);
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

        public clsJornada buscar_jornada(int empleado, DateTime fecha)
        {
            string fecha_consulta = String.Format("{0:yyyy-MM-dd}", fecha);
            try
            {
                clsJornada jornada = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT *, (select count(id_llamada) from llamada where fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantLlamadas, (select count(id_llamada) from llamada where resultado = 'Vendido' AND fecha = @fecha_consulta  AND id_empleado = @id_empleado) as CantVentas FROM jornada_laboral WHERE id_empleado = @id_empleado AND fecha = @fecha_consulta", con); //'2018-02-16'
                cmd.Parameters.AddWithValue("id_empleado", empleado);
                cmd.Parameters.AddWithValue("fecha_consulta", fecha_consulta);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("La jornada para la fecha actual fue guardada. Los nuevos datos erán agregados a los valores existentes.", "Atención: Jornada existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    jornada = new clsJornada();
                    jornada.Id_empleado = Convert.ToInt32(dt.Rows[0]["id_empleado"]);
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
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO jornada_laboral (id_empleado,fecha,inicio_sesion,t_atendiendo,t_descanso,t_reunion,t_llenadoFormularios,t_sinContactos,t_sinCampaña,t_inactivo,t_baño,t_capacitacion,t_almuerzo) values (@idempleado,@fecha,@inicio_sesion,@t_atendiendo,@t_descanso,@t_reunion,@t_llenadoFormularios,@t_sinContactos,@t_sinCampaña,@t_inactivo,@t_baño,@t_capacitacion,@t_almuerzo)", con);

                cmd.Parameters.AddWithValue("idempleado", jornada.Id_empleado);
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
                SqlCommand cmd = new SqlCommand("UPDATE jornada_laboral SET t_atendiendo=@t_atendiendo,t_descanso=@t_descanso,t_reunion=@t_reunion,t_llenadoFormularios=@t_llenadoFormularios,t_sinContactos=@t_sinContactos,t_sinCampaña=@t_sinCampaña,t_inactivo=@t_inactivo,t_baño=@t_baño,t_capacitacion=@t_capacitacion,t_almuerzo=@t_almuerzo,cierre_sesion=@cierre_sesion WHERE id_empleado=@id_empleado AND fecha=@fecha", con);//fecha='2018-02-16'", con);

                cmd.Parameters.AddWithValue("id_empleado", jornada.Id_empleado);
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
        #endregion


        #region Otras funciones

        public void msjError(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Funciones estadisticas ventas empleado


        public int[] totalTodasLlamadasHoy(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int[] cant = new int[] { 0, 0, 0, 0 };
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(resultado) as total,resultado FROM llamada where llamada.id_empleado = " + id + "  and llamada.fecha = '" + fecha + "'  group by resultado", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = 0;

                foreach (DataRow fila in dt.Rows)
                {

                    cant[i] = Convert.ToInt32(fila["total"]);
                    i++;

                }




                return cant;


            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public int[] totalTodasLlamadasSemana(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int[] cant = new int[] { 0, 0, 0, 0, 0 };
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT count(resultado) as total,resultado FROM llamada where llamada.id_empleado = " + id + " and datepart(ww, Fecha) = datepart(ww, getdate()) group by resultado", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = 0;

                foreach (DataRow fila in dt.Rows)
                {

                    cant[i] = Convert.ToInt32(fila["total"]);
                    i++;

                }




                return cant;


            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public int[] totalTodasLlamadasMes(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int[] cant = new int[] { 0, 0, 0, 0, 0 };
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT count(resultado) as total,resultado FROM llamada where llamada.id_empleado = " + id + " and datepart(mm, Fecha) = datepart(mm, getdate())   group by resultado", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = 0;

                foreach (DataRow fila in dt.Rows)
                {

                    cant[i] = Convert.ToInt32(fila["total"]);
                    i++;

                }




                return cant;


            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public int[] totalTodasLlamadasAño(DateTime hoy, int id)
        {

            clsCampaña campaña = new clsCampaña();
            int[] cant = new int[] { 0, 0, 0, 0, 0 };
            string fecha = hoy.ToString("yyy/MM/dd").Replace('/', '-');

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand(" SELECT count(resultado) as total,resultado FROM llamada where llamada.id_empleado = " + id + " and  datepart(yy, Fecha) = datepart(yy, getdate())   group by resultado", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = 0;

                foreach (DataRow fila in dt.Rows)
                {

                    cant[i] = Convert.ToInt32(fila["total"]);
                    i++;

                }




                return cant;


            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);//
                return null;
            }
            finally
            {
                con.Close();
            }

        }



        #endregion


        #region Estadisticas cliente
        public List<clsEstadisticas> numeros_cliente(int id, string filtro, DateTime fecha)
        {
            // No mide las campañas que arrancaron ese día o que estan activas ese día.
            try
            {
                string fecha_parseada = String.Format("{0:yyyy-MM-dd}", fecha);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(distinct campaña.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', (SELECT count(id_llamada) FROM llamada JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) where campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha) as 'Cant llamadas'" +
                    " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                    " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha", con);
                if (filtro != "tpHoy")
                {
                    cmd.CommandText = "SELECT count(distinct campaña.id_campaña) as 'Cant de campañas', count(id_venta) as 'Cant ventas', (SELECT count(id_llamada) FROM llamada JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) where campaña.id_cliente = @id_cliente AND llamada.fecha >= @fecha) as 'Cant llamadas'" +
                    " FROM llamada JOIN venta ON (llamada.id_llamada = venta.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                    " WHERE campaña.id_cliente = @id_cliente AND llamada.fecha >= @fecha";
                }
                cmd.Parameters.AddWithValue("id_cliente", id);
                cmd.Parameters.AddWithValue("fecha", fecha_parseada);
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

        public List<clsEstadisticas> campañas_cliente(int id, string filtro, DateTime fecha)
        {
            // No mide las campañas que arrancaron a partir de ese día o que estan activas ese día.
            try
            {
                string fecha_parseada = String.Format("{0:yyyy-MM-dd}", fecha);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                    " FROM venta JOIN llamada ON (venta.id_llamada = llamada.id_llamada) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña) WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha" +
                    " GROUP BY campaña.id_campaña,campaña.nombre", con);
                if(filtro != "tpHoy")
                {
                    cmd.CommandText = "SELECT campaña.nombre, count(id_venta) as 'Ventas'" +
                    " FROM Call_Center.dbo.venta JOIN Call_Center.dbo.llamada ON (venta.id_llamada = llamada.id_llamada) JOIN Call_Center.dbo.campaña ON (llamada.id_campaña = campaña.id_campaña) WHERE campaña.id_cliente = @id_cliente AND llamada.fecha = @fecha" +
                    " GROUP BY campaña.id_campaña,campaña.nombre";
                }
                cmd.Parameters.AddWithValue("id_cliente", id);
                cmd.Parameters.AddWithValue("fecha", fecha_parseada);
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

        public List<clsJornada> jornadas_cliente(int id, string filtro, DateTime fecha)
        {
            // No mide las campañas que arrancaron ese día o que estan activas ese día.
            try
            {
                string fecha_parseada = String.Format("{0:yyyy-MM-dd}", fecha);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM jornada_laboral JOIN llamada ON (jornada_laboral.id_empleado = llamada.id_empleado AND jornada_laboral.fecha = llamada.fecha) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                    " WHERE campaña.id_cliente = @id_cliente AND jornada_laboral.fecha = @fecha", con);
                if (filtro != "tpHoy")
                {
                    cmd.CommandText = "SELECT * FROM jornada_laboral JOIN llamada ON (jornada_laboral.id_empleado = llamada.id_empleado AND jornada_laboral.fecha = llamada.fecha) JOIN campaña ON (llamada.id_campaña = campaña.id_campaña)" +
                    " WHERE campaña.id_cliente = @id_cliente AND jornada_laboral.fecha >= @fecha";
                }
                cmd.Parameters.AddWithValue("id_cliente", id);
                cmd.Parameters.AddWithValue("fecha", fecha_parseada);
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
    }

}