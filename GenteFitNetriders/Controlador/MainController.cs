using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenteFitNetriders.Controlador
{
    internal class MainController
    {
        //TODO
        //- pasar el acceso a datos del FormLogin a esta clase

        //- Guardar el usuario logeado
        private Modelo.Usuarios userLogged;
        public bool UserLogin(String email, String password)
        {       
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    var user = (from u in db.Usuarios
                              where u.email == email
                              && u.password == password
                              select u).FirstOrDefault(); ;
                if (user != null)
                {
                    userLogged = user;
                    return true;
                }
                return false;
            }
            
        }

        public Usuarios GetUserLogged()
        {
            return userLogged;
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
    }

}