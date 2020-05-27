using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class donhangController : ApiController
    {
        [HttpGet]
        public List<donhang> danhsachdonhang()
        {
            banhangDataContext context = new banhangDataContext();
            List<donhang> dsdh = context.donhangs.ToList();
            return dsdh;
        }
        [HttpGet]
        public List<donhang> danhsachdonhangtheotkkh(string tkkh)
        {
            banhangDataContext context = new banhangDataContext();
            List<donhang> dsdh1 = context.donhangs.Where(x => x.tkkh == tkkh).ToList();
            return dsdh1;
        }
        [HttpGet]
        public List<donhang> danhsachdonhangtheotkkhvatinhtrang(string tkkh, string tinhtrang)
        {
            banhangDataContext context = new banhangDataContext();
            List<donhang> dsdh2 = context.donhangs.Where(x => x.tkkh == tkkh && x.tinhtrang == tinhtrang).ToList();
            return dsdh2;
        }
        [HttpGet]
        public List<donhang> danhsachdonhangtheotinhtrang(string tinhtrang)
        {
            banhangDataContext context = new banhangDataContext();
            List<donhang> dsdh3 = context.donhangs.Where(x => x.tinhtrang == tinhtrang).ToList();
            return dsdh3;
        }
        [HttpGet]
        public donhang thongtindonhang(int id)
        {
            banhangDataContext context = new banhangDataContext();
            donhang dh = context.donhangs.FirstOrDefault(x => x.masodh == id);
            return dh;
        }

        [HttpPost]
        public int themdonhang(string tkkh,DateTime ngaydathang,string diachi,string ghichu)
        {
            int id = 0;
            try
            {
                banhangDataContext context = new banhangDataContext();
                donhang dhmoi = new donhang();
                dhmoi.tkkh = tkkh;
                dhmoi.ngaydathang = ngaydathang;
                dhmoi.diachinhanhang = diachi;
                dhmoi.tinhtrang = "chuaxacnhan";
                dhmoi.ghichu = ghichu;
                context.donhangs.InsertOnSubmit(dhmoi);
                context.SubmitChanges();
                id = dhmoi.masodh;
            }
            catch { };
            return id;
        }
        [HttpPost]
        public int themdonhangtaicuahang(string tknv, DateTime ngaydathang)
        {
            int id = 0;
            try
            {
                banhangDataContext context = new banhangDataContext();
                donhang dhmoi = new donhang();
                dhmoi.tkkh = "muataicuahang";
                dhmoi.tknv1 = tknv;
                dhmoi.tknv2 = tknv;
                dhmoi.ngaydathang = ngaydathang;
                dhmoi.tinhtrang = "muataicuahang";
                dhmoi.diachinhanhang = "tai cua hang";
                context.donhangs.InsertOnSubmit(dhmoi);
                context.SubmitChanges();
                id = dhmoi.masodh;
            }
            catch { };
            return id;
        }

        [HttpPut]
        public bool duyethang(int masodh,string tknv1)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                donhang dh = context.donhangs.FirstOrDefault(x => x.masodh == masodh);
                if (dh != null)
                {
                    dh.tinhtrang = "daxacnhan";
                    dh.tknv1 = tknv1;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }
        [HttpPut]
        public bool hoanthanhdonhang(int masodh, string tknv2)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                donhang dh = context.donhangs.FirstOrDefault(x => x.masodh == masodh);
                if (dh != null)
                {
                    dh.tinhtrang = "hoantat";
                    dh.tknv2 = tknv2;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }
        [HttpPut]
        public bool huydonhang(int masodh)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                donhang dh = context.donhangs.FirstOrDefault(x => x.masodh == masodh);
                if (dh != null)
                {
                    dh.tinhtrang = "huy";
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }
    }
}
