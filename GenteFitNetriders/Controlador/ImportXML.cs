using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace GenteFitNetriders.Controlador
{
    internal class ImportXML
    {
        MainController controller;
        public ImportXML()
        {
            controller = new MainController();
        }

        public void importUsuariosXML()
        {


            XDocument xml = XDocument.Load(@"import_usuarios.xml");
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
                controller.addUser(u.nombre, u.email, u.sexo, u.edad, u.num_telefono, u.password);
            }

            MessageBox.Show("El XML de usuarios se ha importado correctamente ");

        }



        public void importClasesXML()
        {

            XDocument xml = XDocument.Load(@"import_clases.xml");
            Debug.WriteLine(xml.ToString());

            List<Clases> clases = xml.Descendants("Clase").Select
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
                controller.addClase(c.nombre_clase, c.nrofesor, c.plazas, c.fecha_clase, c.hora_clase, c.duracion);
            }

            MessageBox.Show("El XML de clases se ha importado correctamente ");

        }



        public void importReservasXML()
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
                controller.addReserva(r.id_usuario, r.id_clase, r.estado);
            }

            MessageBox.Show("El XML reservas se ha importado correctamente");
        }
    }
}

