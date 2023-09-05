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
    public void Create()
    {
        var item1 = new Item () { Id = 3, Nome = "Lapiseira", Quantidade = 2, Valor = 1.2 };     

        var cesta = new BasketRepository();
        cesta.AdicionarItem(item1);

    }
}
