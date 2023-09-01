﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity.Repositories
{
    public interface IMovieRepository
    {
        string AddMovie(MovieModel movie);
        string Updatemovie(MovieModel movie);

        string DeleteMovieByid(int id);

        void DeleteAll();

        MovieModel GetMovieById(int id);

        List<MovieModel> GetAll();
    }
}
