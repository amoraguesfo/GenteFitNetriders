using GenteFitNetriders.Modelo;
using GenteFitNetriders.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }

}