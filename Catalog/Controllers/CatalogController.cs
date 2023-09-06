using Catalog.Model;
using Catalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatalogController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Item> Get()
    {
        var catalog = new CatalogRepository();
        return catalog.GetCarrinho();
    }

    [HttpPost]
    public void Create(Item item)
    {
        var catalog = new CatalogRepository();
        catalog.AdicionarItem(item);
    }

    
    [HttpGet()]
    [Route("ByCategoria/{id}")]
    public IEnumerable<Item>ByCategoria(int id)
    {
        var cesta = new CatalogRepository();
        return cesta.ByCategoria(id);
    }
}
