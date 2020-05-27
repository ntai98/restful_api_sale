using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.controllers
{
    public class nhavienController : ApiController
    {
        [HttpGet]
        public List<nhavien> danhsachnhanvien()
        {
            banhangDataContext context = new banhangDataContext();
            List<nhavien> dsnv = context.nhaviens.ToList();
            foreach (nhavien x in dsnv)
            {
                x.mknv = null;
            }
            return dsnv;
        }
        [HttpGet]
        public nhavien thongtinhanvien(string id)
        {
            banhangDataContext context = new banhangDataContext();
            nhavien nv = context.nhaviens.FirstOrDefault(x => x.tknv == id);
            nv.mknv = null;
            return nv;
        }

        [HttpPost]
        public bool themnhanvien(string tknv, string mknv, string htnv, string gtnv, string dcnv, int sdtnv, int cmndnv)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhavien nvmoi = new nhavien();
                nvmoi.tknv = tknv;
                nvmoi.mknv = mknv;
                nvmoi.hotennv = htnv;
                nvmoi.gioitinhnv = gtnv;
                nvmoi.diachinv = dcnv;
                nvmoi.sdtnv = sdtnv;
                nvmoi.cmndnv = cmndnv;
                context.nhaviens.InsertOnSubmit(nvmoi);
                context.SubmitChanges();
                return true;
            }
            catch { }
            return false;
        }
        [HttpPost]
        public bool dangnhap(string tknv,string mknv)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhavien tk = context.nhaviens.FirstOrDefault(x => x.tknv == tknv && x.mknv == mknv);
                if (tk != null)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }

        [HttpPut]
        public bool suathongthongtinnhanvien(string tknv, string htnv, string gtnv, string dcnv, int sdtnv, int cmndnv)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhavien suanv = context.nhaviens.FirstOrDefault(x => x.tknv == tknv);
                if (suanv != null)
                {
                    suanv.hotennv = htnv;
                    suanv.gioitinhnv = gtnv;
                    suanv.diachinv = dcnv;
                    suanv.sdtnv = sdtnv;
                    suanv.cmndnv = cmndnv;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        [HttpPut]
        public bool doimatkhaunhanvien(string tknv, string mknv, string mkmoi)
        {
            try
            {
                banhangDataContext context = new banhangDataContext();
                nhavien doimknv = context.nhaviens.FirstOrDefault(x => x.tknv == tknv && x.mknv == mknv);
                if (doimknv != null)
                {
                    doimknv.mknv = mkmoi;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }

        [HttpDelete]
        public bool xoanhanvien(string tknv)
        {
            {
                try
                {
                    banhangDataContext context = new banhangDataContext();
                    nhavien xoanv = context.nhaviens.FirstOrDefault(x => x.tknv == tknv);
                    if (xoanv != null)
                    {
                        context.nhaviens.DeleteOnSubmit(xoanv);
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
