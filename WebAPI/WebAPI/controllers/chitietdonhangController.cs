using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class chitietdonhangController : ApiController
    {
        [HttpGet]
        public List<chitietdonhang> thongtindonhang(int id)
        {
            banhangDataContext context = new banhangDataContext();
            List<chitietdonhang> ttdh = context.chitietdonhangs.Where(x => x.masodh == id).ToList();
            return ttdh;
        }

        [HttpPost]
        public bool them(int masodh, int mahang, int soluong ,int gia1sp)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                chitietdonhang themvaodh = new chitietdonhang();
                themvaodh.masodh = masodh;
                themvaodh.mahang = mahang;
                themvaodh.soluong = soluong;
                themvaodh.giadathang1sp = gia1sp;
                context.chitietdonhangs.InsertOnSubmit(themvaodh);
                context.SubmitChanges();
                return true;
            }
            catch { };
            return false;
        }
    }
}
