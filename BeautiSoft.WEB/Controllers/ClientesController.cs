﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautiSoft.WEB.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult ListarClientes()
        {
            @ViewData["Title"] = "Clientes";
            return View();
        }

        public IActionResult CrearCliente()
        {
            @ViewData["Title"] = "Crear Cliente";
            return View();
        }

    }
}
