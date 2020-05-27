using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class giohangController : ApiController
    {
        [HttpGet]
        public List<giohang> giohangtheotkkh(string id)
        {
            banhangDataContext context = new banhangDataContext();
            List<giohang> dsgh = context.giohangs.Where(x => x.tkkh == id).ToList();
            return dsgh;
        }
       

        [HttpPost]
        public bool themvaogiohang(string tkkh,int mahang, int soluong)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                giohang gh = new giohang();
                gh.tkkh = tkkh;
                gh.mahang = mahang;
                gh.soluong = soluong;
                context.giohangs.InsertOnSubmit(gh);
                context.SubmitChanges();
                return true;
            }
            catch { };
            return false;
        }

        [HttpPut]
        public bool suasoluong(string tkkh, int mahang, int soluong)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                giohang gh = context.giohangs.FirstOrDefault(x => x.tkkh == tkkh && x.mahang == mahang);
                if(gh != null)
                {
                    gh.soluong = soluong;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }

        [HttpDelete]
        public bool xoa1(string tkkh, int mahang)
        {
            {
                try
                {
                    banhangDataContext context = new banhangDataContext();
                    giohang xoagh = context.giohangs.FirstOrDefault(x => x.tkkh == tkkh && x.mahang == mahang);
                    if (xoagh != null)
                    {
                        context.giohangs.DeleteOnSubmit(xoagh);
                        context.SubmitChanges();
                        return true;
                    }
                }
                catch { }
                return false;
            }
        }
        [HttpDelete]
        public bool xoahet(string tkkh)
        {
            {
                try
                {
                    banhangDataContext context = new banhangDataContext();
                    List<giohang> dsxoa = context.giohangs.Where(x => x.tkkh == tkkh ).ToList();
                    if(dsxoa.Count() != 0)
                    {
                        context.giohangs.DeleteAllOnSubmit(dsxoa);
                        context.SubmitChanges();
                        return true;
                    }
                }
                catch { }
                return false;
            }
        }
    }
}
