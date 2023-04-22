using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using GenteFitNetriders.Modelo;

namespace GenteFitNetriders.Controlador
{
    internal class ReservasXML
    {
        ReservasController controller;

        public ReservasXML()
        {
            controller = new ReservasController();
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
