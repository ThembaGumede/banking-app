using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("Users")]

public class Class1
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]

    public int UserID { get; set; }
    [Column("Full-name")]
    public string FirstName { get; set; }
    [column("Last-name")]
    public string LastName { get; set; }
    [column("Email")]
    public string Email { get; set; }
    [column("DOB")]
    public int DOB { get; set; }
    [column("Status")]
    public string Status {  get; set; }
}
