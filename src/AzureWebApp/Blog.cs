using System.ComponentModel.DataAnnotations;

namespace AzureWebApp
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }
    }
}