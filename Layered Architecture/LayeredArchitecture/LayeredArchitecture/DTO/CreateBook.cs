using System.ComponentModel.DataAnnotations;

namespace LayeredArchitecture.DTO
{
    public class CreateBook
    {

        public string Title { get; set; }  

        public string Author { get; set; }

        public int YearPublished { get; set; }
    }
}
