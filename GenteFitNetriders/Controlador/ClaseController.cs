using GenteFitNetriders.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitNetriders.Controlador
{
    internal class ClaseController
    {
        /********************
        *     CLASES       *
        ********************/
        public IEnumerable<Modelo.ClaseViewModel> getClases()
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IEnumerable<Modelo.ClaseViewModel> clases = (from c in db.Clases
                                                             select new Modelo.ClaseViewModel
                                                             {
                                                                 id = c.id,
                                                                 nombre_clase = c.nombre_clase,
                                                                 profesor = c.nrofesor,
                                                                 plazas = c.plazas,
                                                                 reservas = c.Reserva.Count(),
                                                                 fecha_clase = c.fecha_clase,
                                                                 hora_clase = c.hora_clase,
                                                                 duracion = c.duracion
                                                             }
                                                       ).ToList();
                return clases;
            }
        }
        public Clases getClaseById(int id)
        {
            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                var clase = (from c in db.Clases
                             where c.id == id
                             select c).FirstOrDefault();

                return clase;
            }
        }
        public IEnumerable<Modelo.ClaseViewModel> getClasesByFecha(String nombreClase, String fechaClaseStr)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                IQueryable<Modelo.Clases> query = db.Clases;

                if (!string.IsNullOrEmpty(nombreClase) && !string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.nombre_clase.Contains(nombreClase) && c.fecha_clase == fechaClaseDate.Date);
                }
                else if (!string.IsNullOrEmpty(nombreClase))
                {
                    query = query.Where(c => c.nombre_clase.Contains(nombreClase));

                }
                else if (!string.IsNullOrEmpty(fechaClaseStr))
                {
                    DateTime fechaClaseDate = DateTime.Parse(fechaClaseStr);
                    query = query.Where(c => c.fecha_clase == fechaClaseDate.Date);

                }


                IEnumerable<Modelo.ClaseViewModel> clases = (from c in query
                                                             select new Modelo.ClaseViewModel
                                                             {
                                                                 id = c.id,
                                                                 nombre_clase = c.nombre_clase,
                                                                 profesor = c.nrofesor,
                                                                 plazas = c.plazas,
                                                                 reservas = c.Reserva.Count(),
                                                                 fecha_clase = c.fecha_clase,
                                                                 hora_clase = c.hora_clase,
                                                                 duracion = c.duracion
                                                             }
                                                       ).ToList();
                return clases;
            }
        }
        public IEnumerable<Modelo.ClaseViewModel> getClasesByName(String nombreClase)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {



                IEnumerable<Modelo.ClaseViewModel> clases = (from c in db.Clases
                                                             where c.nombre_clase.Contains(nombreClase)
                                                             select new Modelo.ClaseViewModel
                                                             {
                                                                 id = c.id,
                                                                 nombre_clase = c.nombre_clase,
                                                                 profesor = c.nrofesor,
                                                                 plazas = c.plazas,
                                                                 reservas = c.Reserva.Count(),
                                                                 fecha_clase = c.fecha_clase,
                                                                 hora_clase = c.hora_clase,
                                                                 duracion = c.duracion
                                                             }
                                                       ).ToList();
                return clases;
            }
        }
        public bool addClase(String nombreClase, String profesor, int plazas, DateTime fechaClase, TimeSpan horaClase, int duracion)
        {

            using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
            {
                Clases clase = new Clases
                {
                    nombre_clase = nombreClase,
                    nrofesor = profesor,
                    plazas = plazas,
                    fecha_clase = fechaClase,
                    hora_clase = horaClase,
                    duracion = duracion
                };
                db.Clases.Add(clase);

                db.SaveChanges();
            }

            return true;


        }
        public bool editClase(int id, String nombreClase, String profesor, int plazas, DateTime fechaClase, TimeSpan horaClase, int duracion)
        {
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Clases clase = (from c in db.Clases
                                    where c.id == id
                                    select c).FirstOrDefault();

                    clase.nombre_clase = nombreClase;
                    clase.nrofesor = profesor;
                    clase.plazas = plazas;
                    clase.fecha_clase = fechaClase;
                    clase.hora_clase = horaClase;
                    clase.duracion = duracion;

                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la clase " + ex.Message);
            }
        }
        public bool deleteClase(int id)
        {
            //TODO checkear si la clase que intenta elminiar a otro es admin
            //Common.userLogged.tipo == "admin"
            try
            {
                using (Modelo.NetridersEntities db = new Modelo.NetridersEntities())
                {
                    Clases clase = (from c in db.Clases
                                    where c.id == id
                                    select c).FirstOrDefault();

                    db.Clases.Remove(clase);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase " + ex.Message);
            }
        }
    }
}
