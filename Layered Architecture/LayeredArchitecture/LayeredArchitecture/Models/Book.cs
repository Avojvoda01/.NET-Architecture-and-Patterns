using System.ComponentModel.DataAnnotations;

namespace LayeredArchitecture.Models
{
    public class Book
    {
        //String
        //String is nullable type, so we have to define if it is required or not e.g
        //var string Author {get;set;} = "" ; // this is one way to make it required, by assigning it an empty string as default value NULL NOT ALLOWED
        //var string? Author {get;set;} // this is a way to make it nullable, by adding a question mark after the type. NULL ALLOWED

        //Non nullable Types
        //For value types like int, bool, etc. they are non-nullable by default, so we don't have to do anything to make them required.
        //But if we want to make them nullable, we can add a question mark after the type e.g

        public int Id {  get; set; } //EF Core automatically knows that this is the primary key because of the naming Convention

        [MaxLength(200)]
        public string Title { get; set; } = "";  // = "" is used to let EF know this field is Required, otherwise it will be nullable and we would have to add [Required] attribute

        
        [MaxLength(100)]
        public string Author { get; set; } = "";

        public int YearPublished { get; set; }
        
        public bool isAvailable { get; set; }


    }
}
