using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using GenteFitNetriders.Modelo;
using System.Windows;

namespace GenteFitNetriders.Controlador.XML
{
    internal class ClasesXML
    {
       ClaseController controller;
        public ClasesXML()
        {
            controller = new ClaseController();
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
    }
}
