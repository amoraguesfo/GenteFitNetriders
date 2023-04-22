using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitNetriders.Controlador
{
    internal class ReservasController
    {


        /********************
         *     RESERVAS     *
         ********************/
        public IEnumerable<Modelo.ReservaViewModel> getReservas()
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.ReservaViewModel> reservas = (from r in db.Reserva
                                                                 select new Modelo.ReservaViewModel
                                                                 {
                                                                     id = r.id,
                                                                     id_usuario = r.id_usuario,
                                                                     nombre_usuario = r.Usuarios.nombre,
                                                                     email_usuario = r.Usuarios.email,
                                                                     id_clase = r.id_clase,
                                                                     nombre_clase = r.Clases.nombre_clase,
                                                                     fecha_clase = r.Clases.fecha_clase,
                                                                     hora_clase = r.Clases.hora_clase,
                                                                     estado = r.estado
                                                                 }
                                                       ).ToList();
                return reservas;
            }
        }
        public IEnumerable<Modelo.ReservaViewModel> getReservasByUser(int idUsusario)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.ReservaViewModel> reservas = (from r in db.Reserva
                                                                 where r.id_usuario == idUsusario
                                                                 select new Modelo.ReservaViewModel
                                                                 {
                                                                     id = r.id,
                                                                     id_usuario = r.id_usuario,
                                                                     nombre_usuario = r.Usuarios.nombre,
                                                                     email_usuario = r.Usuarios.email,
                                                                     id_clase = r.id_clase,
                                                                     nombre_clase = r.Clases.nombre_clase,
                                                                     fecha_clase = r.Clases.fecha_clase,
                                                                     hora_clase = r.Clases.hora_clase,
                                                                     estado = r.estado
                                                                 }
                                                       ).ToList();
                return reservas;
            }
        }
        public IEnumerable<Modelo.ReservaViewModel> getReservasByClass(int idClase)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.ReservaViewModel> reservas = (from r in db.Reserva
                                                                 where r.id_clase == idClase
                                                                 select new Modelo.ReservaViewModel
                                                                 {
                                                                     id = r.id,
                                                                     id_usuario = r.id_usuario,
                                                                     nombre_usuario = r.Usuarios.nombre,
                                                                     email_usuario = r.Usuarios.email,
                                                                     id_clase = r.id_clase,
                                                                     nombre_clase = r.Clases.nombre_clase,
                                                                     fecha_clase = r.Clases.fecha_clase,
                                                                     hora_clase = r.Clases.hora_clase,
                                                                     estado = r.estado
                                                                 }
                                                       ).ToList();
                return reservas;
            }
        }

        public IEnumerable<Modelo.ReservaViewModel> getReservasByFilter(String nombreUsuario, String nombreClase, String fechaClaseStr)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IQueryable<Modelo.Reserva> query = db.Reserva;

                if (!string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(nombreClase) && !string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.Usuarios.nombre.Contains(nombreUsuario) && c.Clases.nombre_clase.Contains(nombreClase) && c.Clases.fecha_clase == fechaClaseDate.Date);
                }
                else if (!string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(nombreClase))
                {
                    query = query.Where(c => c.Usuarios.nombre.Contains(nombreUsuario) && c.Clases.nombre_clase.Contains(nombreClase));
                }
                else if (!string.IsNullOrEmpty(nombreClase) && !string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.Clases.nombre_clase.Contains(nombreClase) && c.Clases.fecha_clase == fechaClaseDate.Date);
                }
                else if (!string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.Usuarios.nombre.Contains(nombreUsuario) && c.Clases.fecha_clase == fechaClaseDate.Date);
                }
                else if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    query = query.Where(c => c.Usuarios.nombre.Contains(nombreUsuario));

                }
                else if (!string.IsNullOrEmpty(nombreClase))
                {
                    query = query.Where(c => c.Clases.nombre_clase.Contains(nombreClase));

                }
                else if (!string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.Clases.fecha_clase == fechaClaseDate.Date);

                }

                IEnumerable<Modelo.ReservaViewModel> reservas = (from r in query
                                                                 select new Modelo.ReservaViewModel
                                                                 {
                                                                     id = r.id,
                                                                     id_usuario = r.id_usuario,
                                                                     nombre_usuario = r.Usuarios.nombre,
                                                                     email_usuario = r.Usuarios.email,
                                                                     id_clase = r.id_clase,
                                                                     nombre_clase = r.Clases.nombre_clase,
                                                                     fecha_clase = r.Clases.fecha_clase,
                                                                     hora_clase = r.Clases.hora_clase,
                                                                     estado = r.estado
                                                                 }
                                            ).ToList();
                return reservas;

            }
        }
        public bool addReserva(int idUsuario, int idClase, string estado)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                Reserva res = new Reserva();
                {
                    res.id_usuario = idUsuario;
                    res.id_clase = idClase;
                    res.estado = estado;
                };
                db.Reserva.Add(res);

                db.SaveChanges();
            }

            return true;


        }
        public bool editReserva(int id, int idUsuario, int idClase, string estado)
        {
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Reserva res = (from r in db.Reserva
                                   where r.id == id
                                   select r).FirstOrDefault();

                    res.id_usuario = idUsuario;
                    res.id_clase = idClase;
                    res.estado = estado;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la clase " + ex.Message);
            }
        }
        public bool deleteReserva(int id)
        {

            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Reserva res = (from r in db.Reserva
                                   where r.id == id
                                   select r).FirstOrDefault();

                    db.Reserva.Remove(res);
                    db.SaveChanges();


                    //Buscar la primera en espera  y actualizar su reserva mejorar con transaccion?transaccion?
                    Reserva espera = (from r in db.Reserva
                                      where r.id_clase == res.id_clase && r.estado == "espera"
                                      orderby r.id
                                      select r).FirstOrDefault();

                    //Solo si es necesario mirar si hay esperas
                    if (espera != null)
                    {
                        espera.estado = "reservada";
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase " + ex.Message);
            }
        }
    }
}
