using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class nhomhangController : ApiController
    {
        [HttpGet]
        public List<nhomhang> danhsachnhomhang()
        {
            banhangDataContext context = new banhangDataContext();
            List<nhomhang> dsnhomhang = context.nhomhangs.ToList();
            return dsnhomhang;
        }
        [HttpGet]
        public nhomhang nhomhang(int id)
        {
            banhangDataContext context = new banhangDataContext();
            nhomhang nh = context.nhomhangs.FirstOrDefault(x => x.manhom == id);
            return nh;
        }
        [HttpGet]
        public List<nhomhang> danhsachnhomhangtheomaloai(string maloai)
        {
            banhangDataContext context = new banhangDataContext();
            List<nhomhang> dslh = context.nhomhangs.Where(x => x.maloai == maloai).ToList();
            return dslh;
        }

        [HttpPost]
        public bool themnhomhang(string maloai, string tennhom)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhomhang lhmoi = new nhomhang();
                lhmoi.maloai = maloai;
                lhmoi.tennhom = tennhom;
                context.nhomhangs.InsertOnSubmit(lhmoi);
                context.SubmitChanges();
                return true;
            }
            catch { }
            return false;
        }

        [HttpPut]
        public bool suanhomhang(int manhom, string maloai, string tennhom)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhomhang sualh = context.nhomhangs.FirstOrDefault(x => x.manhom == manhom);
                if (sualh != null)
                {
                    sualh.maloai = maloai;
                    sualh.tennhom = tennhom;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }

        [HttpDelete]
        public bool xoanhomhang(int manhom)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhomhang xoalh = context.nhomhangs.FirstOrDefault(x => x.manhom == manhom);
                if (xoalh != null)
                {
                    context.nhomhangs.DeleteOnSubmit(xoalh);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
