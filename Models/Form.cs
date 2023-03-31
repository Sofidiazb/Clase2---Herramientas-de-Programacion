using System.ComponentModel.DataAnnotations;

public class Form{
    [Required]
    public string Mail {get;set;}
    [Required]
    public string Password {get;set;}
}