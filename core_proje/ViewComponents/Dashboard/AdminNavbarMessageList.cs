﻿using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList: ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessagedal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values =writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();

            return View(values);
        }
    }
}