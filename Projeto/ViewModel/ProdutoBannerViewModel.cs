using App.Models;
namespace Projeto.Models;
public class ProdutoBannerViewModel
{
    public IEnumerable<Produto> ListaProdutos { get; set; }
    public IEnumerable<Banner> ListaBanners { get; set; }
}
