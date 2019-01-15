using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FGC.Loyalty.Gateway.Common;
using FGC.Microservice.Common;

namespace Testing.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string StringToEncrypt = "Data Source=fgclaps.database.windows.net;Initial Catalog=GatewayCoreNew5000;User ID=fgcprodb;Password=nayake77@b@nk";
            string CryptoKey = "4DC1D6CDCD924F79DD2073C64EDDAA997E705F5683F6423E9CB54F7A2118C4DF";
            string str = FGC.Microservice.Common.StringEncryptor.Encrypt(StringToEncrypt, CryptoKey);

            string StringToDecrypt = @"o213zccPQd/0osAHfAS7lnJRYJsRkTyvNrfIqQMWOWV+YEBWv/gYnydKyhqQvaXq/BxivSEGgVJ2osp1ZK0MZwOpbeKkhSXmwXMmgLC61i/se4UA1F25Z/h6w36r2MJeE57Q6jbe13qgA+oBAOXre+TbcIbGoVAC65gicXkQgIuFcW80D6YbJkydRLfK+Qvb/Xi8gyjQKWGoAdr3M2DOUw==";
            string Dstr = FGC.Microservice.Common.StringEncryptor.Decrypt(StringToDecrypt, CryptoKey);

            return View();
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}