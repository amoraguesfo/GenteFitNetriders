using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GenteFitNetriders.Controlador
{
    internal class MainController
    {
        //TODO
        //- pasar el acceso a datos del FormLogin a esta clase

        //- Guardar el usuario logeado
        public static Modelo.Usuarios userLogged = null;
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
                userLogged = user;
                return true;
            }

        }


        public IEnumerable<Modelo.UserViewModel> getUsers() {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                 IEnumerable<Modelo.UserViewModel> usuarios = (from u in db.Usuarios
                                                        select new Modelo.UserViewModel
                                                        {
                                                            id=u.id,
                                                            nombre=u.nombre,
                                                            email=u.email,
                                                            sexo=u.sexo,
                                                            edad=u.edad,
                                                            num_telefono=u.num_telefono,
                                                            tipo=u.tipo
                                                        }
                                                        ).ToList();
                return usuarios;
            }
        }

        public bool addUser(String nombre, String apellidos, String email, String sexo, int edad, String num_telf, String password)
        {
            try
            {
                Usuarios user = null;
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    user = new Usuarios
                    {
                        nombre = nombre + " " + apellidos,
                        email = email,
                        sexo = sexo,
                        num_telefono = num_telf,
                        password = password,
                        tipo = "cliente" //Solo puede darse de alta nuevos clientes, no 
                    };
                    db.Usuarios.Add(user);
                    db.SaveChanges();
                }
                userLogged = user;
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error an insertar el ussuario " + ex.Message);
            }
        }
    }

}