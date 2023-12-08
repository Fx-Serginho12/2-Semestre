using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Context;
using App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Filters;
using System.Xml;
using System.Text;
using X.PagedList;

namespace Projeto.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Produto
        public async Task<IActionResult> Index(string botao, string? txtFiltro, string cboOrdenacao, int pagina = 1)
        {
            IQueryable<Produto> lista = _context.Produto;   

             int pageSize = 10; // Número de itens por página


            if (!string.IsNullOrEmpty(txtFiltro))
            {
                ViewData["txtFiltro"] = txtFiltro;
                lista = lista.Where(item => item.NomeProduto.ToLower().Contains(txtFiltro));
            }
            if (cboOrdenacao == "NomeProduto")
            {
            lista = lista.OrderBy(item => item.NomeProduto);
            }
            else if (cboOrdenacao == "ProdutoID")
            {
            lista = lista.OrderBy(item => item.ProdutoID);
            }
             ViewData["Ordem"] = cboOrdenacao;
            

            //Verificando se o botão clicado foi o XML
            if (botao == "XML")
            {
                //Chamando o método para exportar o XML enviando como parâmentro a lista já filtrada
                return ExportarXML(lista.ToList());
            }
            else if (botao == "Json")
            {
                //Chamando o método para exportar o Json enviando como parâmentro a lista já filtrada
                return ExportarJson(lista.ToList());
            }
            return View(lista.ToPagedList(pagina, pageSize));

        }

        private IActionResult ExportarJson(List<Produto> lista)
        {
            var json = new StringBuilder();
            json.AppendLine("{");
            json.AppendLine("  \"Produtos\": [");
            int total = 0;
            foreach (var produtos in lista)
            {
                json.AppendLine("    {");
                json.AppendLine($"      \"Id\": {produtos.ProdutoID},");
                json.AppendLine($"      \"NomeProduto\": \"{produtos.NomeProduto}\",");
                json.AppendLine($"      \"Preco\": \"{produtos.Preco}\",");
                json.AppendLine($"      \"Descricao\": \"{produtos.Descricao.ToString()}\",");
                json.AppendLine($"      \"Foto\": {produtos.Foto.ToString()}");
                json.AppendLine("    }");
                total++;
                if (total < lista.Count())
                {
                    json.AppendLine("    ,");
                }
            }
            json.AppendLine("  ]");
            json.AppendLine("}");

            return File(Encoding.UTF8.GetBytes(json.ToString()), "application/json", "dados_paises.json");
        }

        private IActionResult ExportarXML(List<Produto> lista)
        {
            var stream = new StringWriter();
            var xml = new XmlTextWriter(stream);
            xml.Formatting = System.Xml.Formatting.Indented;
            xml.WriteStartDocument();
            xml.WriteStartElement("NomeProduto");
            xml.WriteStartElement("Usuários");
            foreach (var item in lista)
            {
                xml.WriteStartElement("Descricao");
                xml.WriteElementString("Id", item.ProdutoID.ToString());
                xml.WriteElementString("NomeProduto", item.NomeProduto.ToString());
                xml.WriteElementString("Preco", item.Preco.ToString());
                xml.WriteElementString("Foto", item.Foto);
                xml.WriteEndElement(); // </Usuario>
            }
            xml.WriteEndElement(); // </Usuarios>
            xml.WriteEndElement(); // </Dados>
            return File(Encoding.UTF8.GetBytes(stream.ToString()), "application/xml", "dados_usuarios.xml");
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.ProdutoID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (true)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

        }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            ViewData["Categorias"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");

            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Produto produto)
        {
            if (id != produto.ProdutoID)
            {
                return NotFound();
            }

            if (true)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ProdutoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.ProdutoID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produto == null)
            {
                return Problem("Entity set 'AppDbContext.Produto'  is null.");
            }
            var produto = await _context.Produto.FindAsync(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return (_context.Produto?.Any(e => e.ProdutoID == id)).GetValueOrDefault();
        }
    }
}
