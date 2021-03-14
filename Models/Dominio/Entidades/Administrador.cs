

using System.ComponentModel.DataAnnotations;

namespace admin_cms.Models.Dominio.Entidades
{
  public class Administrador
  {
    [Required]
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(15)]
    public string Telefone { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    [MaxLength(150)]
    public string Senha { get; set; }
  }
}