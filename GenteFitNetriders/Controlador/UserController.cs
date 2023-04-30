using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Controlador
{
    internal class UserController
    {
   /********************
   *     USUARIOS     *
   ********************/
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
        public Usuarios getUserById(int id)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var user = (from u in db.Usuarios
                            where u.id == id

                            select u).FirstOrDefault();

                return user;
            }
        }
        public IEnumerable<Modelo.UserViewModel> getUsersByNombre(String nombre)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.UserViewModel> users = (from u in db.Usuarios
                                                           where u.nombre.ToLower().Contains(nombre)

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
                                                           }).ToList();

                return users;
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
                        edad = edad,
                        sexo = sexo,
                        num_telefono = num_telf,
                        password = password,
                        tipo = "cliente" //Solo puede darse de alta nuevos clientes, no admins
                    };
                    db.Usuarios.Add(user);
                    db.SaveChanges();
                }
                Common.userLogged = user;
                return true;

            }
            catch (Exception ex)
            {
                return false;
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
                return false;
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
        public void runPythonScript()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"python.exe";
            var script = @"conectorOdooUser.py";
            psi.Arguments = $"\"{script}\"";
            Process process = new Process();
            process.StartInfo = psi;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.StartInfo.RedirectStandardOutput = true;

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                MessageBox.Show(line);
            }
            process.WaitForExit();
        }
    }
}
