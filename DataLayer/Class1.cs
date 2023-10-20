using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List <Movie> movies = new List<Movie>(){
        new Movie{ Id=1, Name= "Toofan", Ryear= 2021, Ratings= 3},
        new Movie{ Id=1, Name= "Ludo", Ryear= 2021, Ratings= 3},
        new Movie{ Id=1, Name= "Gunjan", Ryear= 2021, Ratings= 3},
        new Movie{ Id=1, Name= "Big Bull", Ryear= 2021, Ratings= 3},
        new Movie{ Id=1, Name= "Laxmi", Ryear= 2021, Ratings= 3}
    };
    public List<Movie> GetMovies(){
        return movies;
    }
    
}
