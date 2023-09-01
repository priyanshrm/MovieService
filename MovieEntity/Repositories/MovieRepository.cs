using Microsoft.EntityFrameworkCore;

namespace MovieEntity.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _db;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _db = movieDbContext;
        }
        public string AddMovie(MovieModel movie)
        {
            _db.movie.Add(movie);
            _db.SaveChanges();
            return "Inserted";
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public string DeleteMovieByid(int id)
        {
            // select * from movie where id=value;
            var movie = _db.movie.Find(id);
            // delete from movie where id=movieid;
            _db.movie.Remove(movie);
            _db.SaveChanges();
            return "Deleted";
        }

        public List<MovieModel> GetAll()
        {
            List<MovieModel> movielist = _db.movie.ToList();
            return movielist;
        }

        public MovieModel GetMovieById(int id)
        {
            return _db.movie.Find(id);
        }

        public string UpdateMovie(MovieModel movie)
        {
            _db.Entry(movie).State = EntityState.Modified; //update statement
            _db.SaveChanges();
            return "Updated";
        }

        public string Updatemovie(MovieModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
