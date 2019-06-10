﻿using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class THAMSO_BUS
    {
        // Lấy tất cả tham số
        public static List<THAMSO> LayTatCaThamSo()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.THAMSOs.ToList();
            }
        }
    }
}
