using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.Models
{
[Table("Produtos")]
public class Produto
{
[Key]
public int ProdutoID { get; set; }
public string NomeProduto { get; set; }
public string Descricao { get; set; }
public decimal Preco { get; set; }
public string Foto{ get; set; }
public bool EmEstoque { get; set; }
public int CategoriaID { get; set; }
}
}
