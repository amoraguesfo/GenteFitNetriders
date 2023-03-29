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
                throw new Exception("Error an insertar el ussuario " + ex.Message);
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


        public void exportUsusariosXML()
        {

            //List<Modelo.UserViewModel> users = (List<UserViewModel>)this.getUsers();
            var  users = this.getUsers();
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
            using (XmlWriter writer = XmlWriter.Create("usuarios2.xml"))
            {
                xml.WriteTo(writer);
            } 

        }

        public void importarUsuariosXML()
        {

                XDocument xDoc = XDocument.Load(@"usuarios2.xml");
                Debug.WriteLine(xDoc.ToString());


                List<Usuarios> users = xDoc.Descendants("Usuario").Select
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
              
                MessageBox.Show("Se ha cargado el XML Usuarios");



        }

        


    }


}