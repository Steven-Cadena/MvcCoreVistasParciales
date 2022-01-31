using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using MvcCoreVistasParciales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.ViewComponents
{
    /*importante la herencia de viewcomponent*/
    public class MenuCochesViewComponent:ViewComponent
    {
        private RepositoryCoches repo;
        public MenuCochesViewComponent(RepositoryCoches repo) 
        {
            this.repo = repo;
        }

        //AQUI PODEMOS TENER CUALQUIER CODIGO COMO HERRAMIENTA 
        //OBLIGATORIO TENER EL METODO InvokeAsync QUE SERA EL 
        //QUE LLAMAREMOS DESDE EL LAYOUT 
        //ESTE METODO CARGARA UN MODEL EN UNA VISTA PARA EL LAYOUT
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
