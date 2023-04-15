using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GenteFitNetriders.Controlador
{
    internal class MainController
    {

        public bool UserLogin(String email, String password)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var user = (from u in db.Usuarios
                            where u.email == email
                            && u.password == password
                            select u).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                Common.userLogged = user;
                return true;
            }

        }

        public IEnumerable<Modelo.UserViewModel> getUsers()
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.UserViewModel> usuarios = (from u in db.Usuarios
                                                              select new Modelo.UserViewModel
                                                              {
                                                                  id = u.id,
                                                                  nombre = u.nombre,
                                                                  email = u.email,
                                                                  sexo = u.sexo,
                                                                  edad = u.edad,
                                                                  num_telefono = u.num_telefono,
                                                                  tipo = u.tipo,
                                                                  password = u.password
                                                              }
                                                       ).ToList();
                return usuarios;
            }
        }

        public Usuarios getUserById(int id)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var user = (from u in db.Usuarios
                            where u.id == id

                            select u).FirstOrDefault();

                return user;
            }
        }

        public bool addUser(String nombre, String email, String sexo, int edad, String num_telf, String password)
        {
            try
            {
                Usuarios user = null;
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    user = new Usuarios
                    {
                        nombre = nombre,
                        email = email,
                        edad = edad,
                        sexo = sexo,
                        num_telefono = num_telf,
                        password = password,
                        tipo = "cliente" //Solo puede darse de alta nuevos clientes, no 
                    };
                    db.Usuarios.Add(user);
                    db.SaveChanges();
                }
                Common.userLogged = user;
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool editUser(int id, String nombre, String email, String sexo, int edad, String num_telf, String password)
        {
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Usuarios user = (from u in db.Usuarios
                                     where u.id == id
                                     select u).FirstOrDefault();

                    user.nombre = nombre;
                    user.email = email;
                    user.sexo = sexo;
                    user.edad = edad;
                    user.num_telefono = num_telf;
                    user.password = password;
                    db.SaveChanges();

                    Common.userLogged = user;
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteUser(int id)
        {
            //TODO checkear si el usuario que intenta elminiar a otro es admin
            //Common.userLogged.tipo == "admin"
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Usuarios user = (from u in db.Usuarios
                                     where u.id == id
                                     select u).FirstOrDefault();

                    db.Usuarios.Remove(user);
                    db.SaveChanges();
                    //userLogged = null; Si se elimina a el mismo se cierra la sesion

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error an actualizar el ussuario " + ex.Message);
            }
        }


        public IEnumerable<Modelo.ClaseViewModel> getClases()
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.ClaseViewModel> clases = (from c in db.Clases
                                                             select new Modelo.ClaseViewModel
                                                             {
                                                                 id = c.id,
                                                                 nombre_clase = c.nombre_clase,
                                                                 profesor = c.nrofesor,
                                                                 plazas = c.plazas,
                                                                 reservas = c.Reserva.Count(),
                                                                 fecha_clase = c.fecha_clase,
                                                                 hora_clase = c.hora_clase,
                                                                 duracion = c.duracion
                                                             }
                                                       ).ToList();
                return clases;
            }
        }

        public Clases getClaseById(int id)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var clase = (from c in db.Clases
                             where c.id == id
                             select c).FirstOrDefault();

                return clase;
            }
        }
        public bool addClase(String nombreClase, String profesor, int plazas, DateTime fechaClase, TimeSpan horaClase, int duracion)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                Clases clase = new Clases
                {
                    nombre_clase = nombreClase,
                    nrofesor = profesor,
                    plazas = plazas,
                    fecha_clase = fechaClase,
                    hora_clase = horaClase,
                    duracion = duracion
                };
                db.Clases.Add(clase);

                db.SaveChanges();
            }

            return true;


        }

        public bool editClase(int id, String nombreClase, String profesor, int plazas, DateTime fechaClase, TimeSpan horaClase, int duracion)
        {
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Clases clase = (from c in db.Clases
                                    where c.id == id
                                    select c).FirstOrDefault();

                    clase.nombre_clase = nombreClase;
                    clase.nrofesor = profesor;
                    clase.plazas = plazas;
                    clase.fecha_clase = fechaClase;
                    clase.hora_clase = horaClase;
                    clase.duracion = duracion;

                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la clase " + ex.Message);
            }
        }

        public bool deleteClase(int id)
        {
            //TODO checkear si la clase que intenta elminiar a otro es admin
            //Common.userLogged.tipo == "admin"
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Clases clase = (from c in db.Clases
                                    where c.id == id
                                    select c).FirstOrDefault();

                    db.Clases.Remove(clase);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase " + ex.Message);
            }
        }


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

        public Reserva getReservaById(int id)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var res = (from r in db.Reserva
                           where r.id == id
                           select r).FirstOrDefault();

                return res;
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
                    //db.SaveChanges();

                    //TODO buscar si hay alguien en espera por fecha y actualizar su reserva mejorar con transaccion?transaccion?
                    Reserva espera = (from r in db.Reserva
                                      where r.id_clase == res.id_clase && r.estado == "espera"
                                      orderby r.id
                                      select r).FirstOrDefault();

                    espera.estado = "reservada";
                    db.SaveChanges();
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