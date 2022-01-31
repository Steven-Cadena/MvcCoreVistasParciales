using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;
        public CochesController()
        {
            this.Cars = new List<Coche>()
            {
                new Coche{ IdCoche = 1, Marca = "Pontiac", Modelo = "FireBird", VelocidadMaxima = 320 },
                new Coche{ IdCoche = 2, Marca = "Peugeot", Modelo = "307", VelocidadMaxima = 95 },
                new Coche{ IdCoche = 3, Marca = "BMW", Modelo = "A3", VelocidadMaxima = 160 },
                new Coche{ IdCoche = 4, Marca = "AUDI", Modelo = "Q6", VelocidadMaxima = 340 },
                new Coche{ IdCoche = 5, Marca = "Ford", Modelo = "Mondeo", VelocidadMaxima = 320 }
            };
        }
        public IActionResult Index()
        {
            return View(this.Cars);
        }

        //ESTA VISTA NO TENDRA NADA AL CARGAR 
        //EN SU INTERIOR, CARGAREMOS VISTAS PARCIALES CON JQUERY
        //TENDREMOS UNA VISTA PARCIAL CON TODOS LOS COCHES 
        public IActionResult PeticionAsincrona() 
        {
            return View();
        }

        //NECESITAMOS UN METODO QUE SERA LLAMADO MEDIANTE load() DE JQUERY
        //LOS METODOS IACTIONRESULT SIEMPRE DEVULVEN PartialView
        public IActionResult _CochesPartial() 
        {
            return PartialView("_CochesPartial", this.Cars);
        }

        //PODEMOS TENER METODOS QUE RECIBAN PARAMETROS 
        //DEBEMOS ENVIAR SIEMPRE PRIMITIVOS 
        public IActionResult _CochesDetailsPartial(int idcoche) 
        {
            //buscamos un coche por su id 
            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);
            //lo mandamos a la vista partial y el coche encontrado
            return PartialView("_CochesDetailsPartial", car);
        }
    }
}
