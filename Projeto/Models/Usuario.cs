using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.Models
{
[Table("Usuarios")]
public class Usuario
{
[Key]
public int UsuarioId { get; set; }
public string Nome { get; set; }
public string Login { get; set; }
public string Senha { get; set; }
}
}
