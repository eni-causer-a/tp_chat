using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace WebApplication2.Controllers
{
    public class ChatController : Controller
    {
        

        // GET: Chat
        public ActionResult Index()
        {
            var chats = Chat.GetMeuteDeChats();

            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            var chats = Chat.GetMeuteDeChats();
            
            return View(chats.Where(c => c.Id == id).First());
        }

    

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            var chats = Chat.GetMeuteDeChats();

            return View(chats.Where(c => c.Id == id).First());
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var chats = Chat.GetMeuteDeChats();
                chats.Remove(chats.Where(c => c.Id == id).First());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
