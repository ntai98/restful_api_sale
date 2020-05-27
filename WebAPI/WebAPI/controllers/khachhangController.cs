using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class khachhangController : ApiController
    {
        [HttpGet]
        public List<khachhang> danhsachkhachhang()
        {
            banhangDataContext context = new banhangDataContext();
            List<khachhang> dskh = context.khachhangs.ToList();
            foreach (khachhang x in dskh)
            {
                x.mkkh = null;
            }
            return dskh;
        }
        [HttpGet]
        public khachhang thongtikhachhang(string id)
        {
            banhangDataContext context = new banhangDataContext();
            khachhang kh = context.khachhangs.FirstOrDefault(x => x.tkkh == id);
           kh.mkkh = null;
            return kh;
        }

        [HttpPost]
        public bool them(string tkkh, string mkkh, string htkh, string gioitinhkh, string dckh, int sdtkh, int cmndkh)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                khachhang khmoi = new khachhang();
                khmoi.tkkh = tkkh;
                khmoi.mkkh = mkkh;
                khmoi.hotenkh = htkh;
                khmoi.gioitinhkh = gioitinhkh;
                khmoi.diachikh = dckh;
                khmoi.sdtkh = sdtkh;
                khmoi.cmndkh = cmndkh;
                context.khachhangs.InsertOnSubmit(khmoi);
                context.SubmitChanges();
                return true;
            }
            catch { }
            return false;
        }
        [HttpPost]
        public bool dangnhap(string tkkh, string mkkh)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                khachhang tk = context.khachhangs.FirstOrDefault(x => x.tkkh == tkkh && x.mkkh == mkkh);
                if (tk != null)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }

        [HttpPut]
        public bool suathongthongtinkhachhang(string tkkh, string htkh, string gioitinhkh, string dckh, int sdtkh, int cmndkh)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                khachhang suakh = context.khachhangs.FirstOrDefault(x => x.tkkh == tkkh);
                if (suakh != null)
                {
                    suakh.hotenkh = htkh;
                    suakh.gioitinhkh = gioitinhkh;
                    suakh.diachikh = dckh;
                    suakh.sdtkh = sdtkh;
                    suakh.cmndkh = cmndkh;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        [HttpPut]
        public bool doimatkhaukhachhang(string tkkh, string mkkh, string mkmoi)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                khachhang doimkkh = context.khachhangs.FirstOrDefault(x => x.tkkh == tkkh && x.mkkh == mkkh);
                if (doimkkh != null)
                {
                    doimkkh.mkkh = mkmoi;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }

        [HttpDelete]
        public bool xoakhachhang(string tkkh)
        {
            {
                try
                {
                    banhangDataContext context = new banhangDataContext();
                    khachhang xoakh = context.khachhangs.FirstOrDefault(x => x.tkkh == tkkh);
                    if (xoakh != null)
                    {
                        context.khachhangs.DeleteOnSubmit(xoakh);
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
