﻿using System.Web.Mvc;
using System.Web.Routing;

namespace RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}",
                defaults: new { Controller = "Home", action = "MostraCategoria" }
                );

            routes.MapRoute(
                name: "Mostra Noticia",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { Controller = "Home", action = "Mostrar Noticia", Id = @"\d+" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
