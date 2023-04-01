using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GenteFitNetriders.Controlador
{
    internal class MainController
    {
        //TODO
        //- pasar el acceso a datos del FormLogin a esta clase


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
                throw new Exception("Error an actualizar el ussuario " + ex.Message);
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
                                                                 id_clase = r.id_clase,
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
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase " + ex.Message);
            }
        }

        public void exportUsusariosXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var users = this.getUsers();
            var xml = new XElement("Usuarios");

            foreach (var u in users)
            {
                Debug.WriteLine(u.email);
                xml.Add(new XElement("Usuario",
                                       new XAttribute("id", u.id),
                                       new XElement("Nombre", u.nombre),
                                       new XElement("Email", u.email),
                                       new XElement("Sexo", (u.sexo == "m" ? "Masculino" : "Femenino")),
                                       new XElement("Edad", u.edad.ToString()),
                                       new XElement("Telefono", u.num_telefono),
                                       new XElement("Password", u.password))
                               );

            }


            Debug.WriteLine(xml.ToString());
            using (XmlWriter writer = XmlWriter.Create("export_usuarios.xml"))
            {
                xml.WriteTo(writer);
            }

            MessageBox.Show("El XML de Usuarios se ha exportado correctamente");

        }

        public void importarUsuariosXML()
        {


            XDocument xml= XDocument.Load(@"import_usuarios.xml");
            Debug.WriteLine(xml.ToString());


            List<Usuarios> users = xml.Descendants("Usuario").Select
            (user =>
            new Usuarios
            {
                id = int.Parse(user.Attribute("id").Value), //no tendremos el i en cuenta ya que la clave para identificar al usuario es el email
                nombre = user.Element("Nombre").Value,
                email = user.Element("Email").Value,
                sexo = user.Element("Sexo").Value == "Masculino" ? "m" : "f",
                edad = int.Parse(user.Element("Edad").Value),
                num_telefono = user.Element("Telefono").Value,
                password = user.Element("Password").Value
            }
            ).ToList();


            foreach (var u in users)
            {
                //Debug.WriteLine(u.email);
                addUser(u.nombre, u.email, u.sexo, u.edad, u.num_telefono, u.password);
            }

            MessageBox.Show("El XML de usuarios se ha importado correctamente ");

        }

        public void exportarClaseXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var clases = this.getClases();
            var xml = new XElement("Clases");

            foreach (var c in clases)
            {
              
                xml.Add(new XElement("Clase",
                                       new XAttribute("id", c.id),
                                       new XElement("Nombre", c.nombre_clase),
                                       new XElement("Profesor", c.profesor),
                                       new XElement("Plazas", c.plazas),
                                       new XElement("Fecha", c.fecha_clase),
                                       new XElement("Hora", c.hora_clase.ToString()),
                                       new XElement("Duracion", c.duracion))

                               );

            }


            Debug.WriteLine(xml.ToString());
            using (XmlWriter writer = XmlWriter.Create("export_clases.xml"))
            {
                xml.WriteTo(writer);
            }

            MessageBox.Show("El XML de clases se ha exportado correctamente");

        }

        public void importarClasesXML()
        {

            XDocument xml = XDocument.Load(@"import_clases.xml");
            Debug.WriteLine(xml.ToString());

            List<Clases> clases =xml.Descendants("Clase").Select
            (clase =>
            new Clases
            {
                id = int.Parse(clase.Attribute("id").Value), //no tendremos el i en cuenta ya que la clave para identificar al usuario es el email
                nombre_clase = clase.Element("Nombre").Value,
                nrofesor = clase.Element("Profesor").Value,
                plazas = int.Parse(clase.Element("Plazas").Value),
                fecha_clase = DateTime.Parse(clase.Element("Fecha").Value),
                hora_clase = TimeSpan.Parse(clase.Element("Hora").Value),
                duracion = int.Parse(clase.Element("Duracion").Value)
            }
            ).ToList();


            foreach (var c in clases)
            {
                //Debug.WriteLine(u.email);
                addClase(c.nombre_clase, c.nrofesor, c.plazas, c.fecha_clase, c.hora_clase, c.duracion);
            }

            MessageBox.Show("El XML de clases se ha importado correctamente ");

        }

        public void exportarReservasXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var reservas = this.getReservas();
            var xml = new XElement("Reservas");

            foreach (var r in reservas)
            {

                xml.Add(new XElement("Reserva",
                                       new XAttribute("id", r.id),
                                       new XElement("IdUsuario", r.id_usuario),
                                       new XElement("IdClase", r.id_clase),
                                       new XElement("Estado", r.estado))
                               );

            }


            Debug.WriteLine(xml.ToString());
            using (XmlWriter writer = XmlWriter.Create("export_clases.xml"))
            {
                xml.WriteTo(writer);
            }

            MessageBox.Show("El XML de reservas se ha exportado correctamente");

        }

        public void importarReservasXML()
        {

            XDocument xml = XDocument.Load(@"import_reservas.xml");
            Debug.WriteLine(xml.ToString());

            List<Reserva> reservas = xml.Descendants("Reserva").Select
            (res =>
            new Reserva
            {
                id = int.Parse(res.Attribute("id").Value), //no tendremos el i en cuenta ya que la clave para identificar al usuario es el email
                id_usuario = int.Parse(res.Element("IdUsuario").Value),
                id_clase = int.Parse(res.Element("IdClase").Value),
                estado = res.Element("Estado").Value
            }
            ).ToList();


            foreach (var r in reservas)
            {
                //Debug.WriteLine(u.email);
                addReserva(r.id_usuario, r.id_clase, r.estado);
            }

            MessageBox.Show("El XML reservas se ha importado correctamente");
        }
    }
   
}