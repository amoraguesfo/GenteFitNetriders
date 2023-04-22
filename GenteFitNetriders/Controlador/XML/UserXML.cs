using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Windows;
using GenteFitNetriders.Modelo;

namespace GenteFitNetriders.Controlador.XML
{
    internal class UserXML
    {
        UserController controller;

        public UserXML()
        {
            controller = new UserController();
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
    }
}
