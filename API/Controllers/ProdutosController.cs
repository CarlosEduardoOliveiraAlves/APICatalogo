using API.Context;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly ApiCatalogoContext _context;

    //Injeta Context no Controller para que esse controlador tenha acesso
    //ao Banco sem instanciar um objeto do tipo ApiCatalogoContext
    public ProdutosController(ApiCatalogoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get() //ActionResult utilizado para poder retornar os status http e o parâmetro passado por ele, nesse caso: IEnumerable<Produto> .
    {
        var produtos = _context.Produtos.ToList();
        if(produtos is null)
        {
            return NotFound("Produtos não encontrados");
        }
        return produtos;
    }

    [HttpGet("{id:int}", Name="ObterProduto")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
        if(produto is null)
        {
            return NotFound("Produto não encontrado");
        }
        return produto;
    }

    [HttpPost]

    public ActionResult Post(Produto produto)
    {
        if(produto is null)
        {
            return BadRequest();
        }   

        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return new CreatedAtRouteResult("ObterProduto",
            new { id = produto.ProdutoId }, produto);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id,Produto produto) 
    {
        
        if (produto.ProdutoId != id)
        {
            BadRequest();
        }

        _context.Entry(produto).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(produto);

    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        if (produto is null)
        {
            return NotFound("Produto não localizado");
        }

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();

        return NoContent();
    }

}
