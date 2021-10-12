using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(12)]
    
    public string HairColor { get; set; }
    [Required, MaxLength(12)]
    public string EyeColor { get; set; }
    [Required]
    [Range(18,110)]
    
    public int Age { get; set; }
    [Required]
    [Range(20,250)]
    public float Weight { get; set; }
    [Required]
    [Range(100,250)]
    public int Height { get; set; }
    
    [Required]
    public string Sex { get; set; }
}


}