using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }    

        [HttpGet("Apresentar/{nome}/{genero}")]
        public IActionResult Apresentar(string nome, string genero)
        {
            string bemVindo = genero == "F" ? "Seja bem-vinda" : "Seja bem-vindo";
            var msg = $"Olá, {nome}! {bemVindo}!";
            return Ok(new { msg });
        }   
    }
}