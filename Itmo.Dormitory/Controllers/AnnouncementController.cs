﻿using Itmo.Dormitory.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Controllers
{
    public class AnnouncementController : Controller
    {
        public IActionResult Index()
        {
            var announcements = GetAnnouncements();
            return View(announcements);
        }

        public List<Announcement> GetAnnouncements()
        {
            var announcementList = new List<Announcement>();
            for(int i = 0; i < 8; i++)
            {
                var announcement = new Announcement 
                       { Title = $"{i} Объявление", Content = $"Содержимое {i} объявления", CreationTime = DateTime.Now };
                announcementList.Add(announcement);
            }
            return announcementList;
        }
    }
}
