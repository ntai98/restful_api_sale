using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class hanghoaController : ApiController
    {
        [HttpGet]
        public List<hanghoa> danhsachhanghoa()
        {
            banhangDataContext context = new banhangDataContext();
            List<hanghoa> dshh = context.hanghoas.ToList();
            return dshh;
        }
        [HttpGet]
        public hanghoa thongtinhanghoa(int id)
        {
            banhangDataContext context = new banhangDataContext();
            hanghoa hh = context.hanghoas.FirstOrDefault(x => x.mahang == id);
            return hh;
        }
        [HttpGet]
        public List<hanghoa> danhsachhanghoahtheomanhom(int manhom)
        {
            banhangDataContext context = new banhangDataContext();
            List<hanghoa> dshh2 = context.hanghoas.Where(x => x.manhom == manhom).ToList();
            return dshh2;
        }
        [HttpGet]
        public List<hanghoa> danhsachhanghoatheomaloai(string maloai)
        {
            banhangDataContext context = new banhangDataContext();
            List<hanghoa> dshh3 = context.hanghoas.Where(x => x.maloai == maloai).ToList();
            return dshh3;
        }
        [HttpGet]
        public List<hanghoa> timkiem(string tenhang)
        {
            banhangDataContext context = new banhangDataContext();
            List<hanghoa> dshh3 = context.hanghoas.Where(x => x.tenhang.Contains(tenhang)).ToList();
            return dshh3;
        }

        [HttpPost]
        public bool themhanghoa(string maloai, int manhom, string tenhang, int gia, string hinh, string mota)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                hanghoa hhmoi = new hanghoa();
                hhmoi.maloai = maloai;
                hhmoi.manhom = manhom;
                hhmoi.tenhang = tenhang;
                hhmoi.gia = gia;
                hhmoi.hinh = hinh;
                hhmoi.mota = mota;
                context.hanghoas.InsertOnSubmit(hhmoi);
                context.SubmitChanges();
                return true;
            }
            catch { };
            return false;
        }

        [HttpPut]
        public bool suahanghoa(int mahang, string maloai, int manhom, string tenhang, int gia,string hinh, string mota)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                hanghoa suahh = context.hanghoas.FirstOrDefault(x => x.mahang == mahang);
                if(suahh != null)
                {
                    suahh.maloai = maloai;
                    suahh.manhom = manhom;
                    suahh.tenhang = tenhang;
                    suahh.gia = gia;
                    suahh.hinh = hinh;
                    suahh.mota = mota;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }


        [HttpDelete]
        public bool xoahanghoa(int mahang)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                hanghoa xoahh = context.hanghoas.FirstOrDefault(x => x.mahang == mahang);
                if (xoahh != null)
                {
                    context.hanghoas.DeleteOnSubmit(xoahh);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { };
            return false;
        }
    }
}
