using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class loaihangController : ApiController
    {
        [HttpGet]
        public List<loaihang> danhsachloaihang()
        {
            banhangDataContext context = new banhangDataContext();
            List < loaihang > dsloaihang = context.loaihangs.ToList();
            return dsloaihang;
        }
        
    }
}
