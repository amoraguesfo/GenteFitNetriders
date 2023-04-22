using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GenteFitNetriders.Controlador
{
    internal class MainController
    {
        /*
         * Login del usuario
         */
        public int UserLogin(String email, String password)
        {
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    var user = (from u in db.Usuarios
                                where u.email == email
                                && u.password == password
                                select u).FirstOrDefault();
                    if (user == null)
                    {
                        return 0;
                    }
                    Common.userLogged = user;
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }


        }


    }
   
}