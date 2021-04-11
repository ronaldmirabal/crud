using crud2.Models.Response;
using crud2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly IArticuloService _articuloService;

        public ArticuloController(IArticuloService articuloService)
        {
            _articuloService = articuloService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _respuesta.Data = _articuloService.GetAll();
                _respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }


    }
}
