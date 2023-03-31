using DigitalBank.WSUsuario;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalBank.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("Usuario");
        }

        public ActionResult Usuario()
        {
            return View();
        }

        public ActionResult UsuarioConsulta()
        {
            WSUsuario.IService1 oCliente = new WSUsuario.Service1Client();
            ViewBag.Usuarios =  oCliente.SelectUsuario().ToList();
            return View();
        }

        public JsonResult setUsuario(Usuario oUsuario)
        {
            WSUsuario.IService1 oCliente = new WSUsuario.Service1Client();
            oCliente.InsertUsuario(oUsuario);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }


        public JsonResult DeleteUsuario(Usuario oUsuario) 
        {
            WSUsuario.IService1 oCliente = new WSUsuario.Service1Client();
            oCliente.DeleteUsuario(oUsuario);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }


        public JsonResult SaveUsuario(Usuario oUsuario)
        {
            WSUsuario.IService1 oCliente = new WSUsuario.Service1Client();
            oCliente.UpdateUsuario(oUsuario);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
     
    }
}