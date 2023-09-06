using Basket.Model;
using Basket.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasketController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Item> Get()
    {
        var cesta = new BasketRepository();
        return cesta.GetCarrinho();
    }

    [HttpPost]
    public void Create(Item item)
    {
        var cesta = new BasketRepository();
        cesta.AdicionarItem(item);
    }

    [HttpGet("{id}")]
    public Item? Get(int id)
    {
        var cesta = new BasketRepository();
        return cesta.GetById(id);
    }

}
