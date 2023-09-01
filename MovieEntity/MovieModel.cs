using System.ComponentModel.DataAnnotations;

namespace MovieEntity

{
    public class MovieModel
    {
        [Key]

        public int Id { get; set; }

        public string name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }
    }
}