using System.ComponentModel.DataAnnotations;

namespace MovieEntity
{
    public class TheatreModel
    {
        [Key]

        public int Id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string city { get; set; }
    }
}