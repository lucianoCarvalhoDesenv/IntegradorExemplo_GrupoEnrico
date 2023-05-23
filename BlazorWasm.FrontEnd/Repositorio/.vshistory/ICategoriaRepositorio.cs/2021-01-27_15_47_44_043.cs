﻿using BlazorMovies.Base.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Repositorio
{
    public interface ICategoriaRepositorio
    {
        Task CreateCategoria(Categoria categoria);
    }
}
