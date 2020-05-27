using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class noibacController : ApiController
    {
        [HttpGet]
        public List<noibac> danhsachnoibac()
        {
            banhangDataContext context = new banhangDataContext();
            List<noibac> dsnb = context.noibacs.ToList();
            return dsnb;
        }

        [HttpPut]
        public bool suanoibac(int thutu, int mahang)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                noibac nb = context.noibacs.FirstOrDefault(x => x.thutu == thutu);
                if (nb != null)
                {
                    nb.mahang = mahang;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
