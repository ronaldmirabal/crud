using crud2.Data;
using crud2.Models.Request;
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
        private readonly DataContext _context;

        public ArticuloController(IArticuloService articuloService, DataContext context)
        {
            _articuloService = articuloService;
            _context = context;
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


        [HttpPost]
        public IActionResult Add(ArticuloRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _articuloService.Add(request);
                _respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }

        [HttpPut]
        public IActionResult Edit(ArticuloRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _articuloService.Edit(request);
                _respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                var _articulo = _context.Articulos.FirstOrDefault(a => a.Id == id);
                if (_articulo !=null)
                {
                    _context.Articulos.Remove(_articulo);
                    _context.SaveChanges();
                    _respuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }





    }
}
