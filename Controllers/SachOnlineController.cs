﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        dbSachOnlineDataContext data = new dbSachOnlineDataContext();
        private List<Book> LaySachMoi(int count)
        {
            return data.Books.OrderByDescending(a =>
            a.Publication_date).Take(count).ToList();
        }
        // GET: SachOnline
        public ActionResult Index()
        {
            var listSachMoi = LaySachMoi(6);
            return View(listSachMoi);
        }
        // GET: SachOnline
        public ActionResult SachBanNhieuPartial()
        {
            var listSachBanNhieu = from cd in data.SachBanNhieus select cd;
            return PartialView(listSachBanNhieu);
        }
        public ActionResult ChuDePartial() {
            var listChuDe = from cd in data.ChuDes select cd;
            return PartialView(listChuDe);
        }
        public ActionResult NhaXuatBanPartial()
        {
            var listNhaXuatBan = from cd in data.Publishers select cd;
            return PartialView(listNhaXuatBan);
        }
    }
}