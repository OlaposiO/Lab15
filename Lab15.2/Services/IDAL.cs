using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15._2.Services
{
    public interface IDAL
    { 
        
        //int CreateMovie(Movie prod);
        //int DeleteMovieById(int id);
        //Movie GetMovieById(int id);
        string[] GetMovieCategories();
        IEnumerable<Movie> GetMovieAll();
        IEnumerable<Movie> GetMovieByCategory(string category);
        //int UpdateProductById(Product prod);
    }
}
 
