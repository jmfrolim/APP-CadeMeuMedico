﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MessagensController : Controller
    {
        //
        // GET: /Messagens/

       public ActionResult BomDia()
       {
           return Content("Bom dia!");
       }

       public ActionResult BoaTarde()
       {
           return Content("Boa tarde!");
       }

    }
}
