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
    internal class ExportXML
    {
        MainController controller;

        public ExportXML()
        {
            controller = new MainController();
        }

        public void exportUsusariosXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var users = controller.getUsers();
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

        public void exportClaseXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var clases = controller.getClases();
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

        public void exportReservasXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var reservas = controller.getReservas();
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
            using (XmlWriter writer = XmlWriter.Create("export_reservas.xml"))
            {
                xml.WriteTo(writer);
            }

            MessageBox.Show("El XML de reservas se ha exportado correctamente");

        }
    }
}
