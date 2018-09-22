using ExamenFinalIX.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ExamenFinalIX.Controllers
{
    public class RegistroController : ApiController
    {
        private PearEntities db = new PearEntities();

        //GET:  api/registo
        public IQueryable<Registro> GetRegistro()
        {
            return db.Registro;
        }

        //GET: api/registro/1
        [ResponseType(typeof(Registro))]
        public IHttpActionResult GetRegistro(int id)
        {
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return NotFound();
            }
            return Ok(registro);
        }

        //PUT: api/Registro/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegistro(Registro registro)
        {
            //validar estado
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //validar que venga el parametro id

            // modificar
            db.Entry(registro).State = EntityState.Modified;
            try
            {
                //lo que yo haga aca si no funciona 
                //guarda modicicación
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {


            }
            return StatusCode(HttpStatusCode.NoContent);
        }


        //Post:api/alumno
        [ResponseType(typeof(Registro))]
        public IHttpActionResult PostResgistro(Registro registro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Insersion
            db.Registro.Add(registro);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                if (TableExists(registro.Id_registro))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            //return Ok();
            return CreatedAtRoute("Registro", new { id = registro.Id_registro }, registro);
        }


        //Delete: api/alumno/5
        [ResponseType(typeof(Registro))]
        public IHttpActionResult DeleteRegistro(int id)
        {
            Registro alumno = db.Registro.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }
            db.Registro.Remove(alumno);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return Ok(alumno);
        }

        //Hacer que se livere la base de datos
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TableExists(int id)
        {
            //Selecciona de Registros todas las filas que corresponda
            //al id enviado como parametro
            return db.Registro.Count(e => e.Id_registro == id) > 0;
        }

    }
}
