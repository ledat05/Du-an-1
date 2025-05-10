﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Du_an_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

public class RegisterController : Controller
{
    private IHostingEnvironment hosting;
    public RegisterController(IHostingEnvironment _hosting)
    {
        hosting = _hosting;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult XuLy(PersonViewModel m, IFormFile FHinh)
    {
        if (FHinh != null)
        {
            //xử lý upload
            // string filename = FHinh.FileName;
            string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
            string path = Path.Combine(hosting.WebRootPath, "images");
            using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
            {
                //sao chép lên server
                FHinh.CopyTo(filestream);
            }
            m.Picture = filename;
        }
        return View(m);
    }
}