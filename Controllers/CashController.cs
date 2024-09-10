using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_APIs_Problema_2._2.Models;

namespace WEB_APIs_Problema_2._2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CashController : ControllerBase
    {
        private static readonly List<Coin> coins = new List<Coin>();

        [HttpGet]
        public IActionResult GetAllCoins()
        {
            return Ok(coins);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            Coin? selectedCoin = coins.Find(coin => coin.Name == name);

            if (selectedCoin != null)
            {
                return Ok(selectedCoin);

            }

            return NotFound("Unregistered coin");
        }

        [HttpPost]
        public IActionResult CreateCoin([FromBody] Coin coin)
        {
            if (coin == null)
            {
                return BadRequest("The body is missing");
            }

            if (coin.Value < 0)
            {
                return BadRequest("Invalid value");
            }

            coins.Add(coin);

            return Ok(coin);
        }

    }
}