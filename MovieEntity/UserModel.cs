using System.ComponentModel.DataAnnotations;

namespace MovieEntity
{
    public class UserModel
    {
        [Key]

        public int Id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public long phone { get; set; }
        public string password { get; set; }
    }
}