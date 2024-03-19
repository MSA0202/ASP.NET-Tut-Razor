using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazerPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; } = string.Empty;
    

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)] // can also combine attributes to one line
    public string? Genre { get; set; } = string.Empty; //? indicates that it is a nullable string, so that an exception is not thrown but instead "null" is thrown when Genre is null


    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] // these are restriction attributes for the below entries
    [StringLength(5)]
    [Required]
    public string Rating { get; set; } = string.Empty;
}