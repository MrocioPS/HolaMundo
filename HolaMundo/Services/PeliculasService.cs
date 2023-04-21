using HolaMundo.Models;
using System;
using System.Collections.Generic;

namespace HolaMundo.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Mi vida",
                Duracion = 256,
                Pais = "España",
                Publicacion = new DateTime(2023, 10, 2)

            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Mi vida",
                Duracion = 256,
                Pais = "España",
                Publicacion = new DateTime(2023, 10, 2)

            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Mi vida 1",
                Duracion = 345,
                Pais = "Francia",
                Publicacion = new DateTime(2022, 9, 1)

            };

            return new List<Pelicula>() { pelicula1, pelicula2 };
        }
    }
}
