﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThemNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmNguoiDung"].Enabled = true;
            Application.OpenForms["frmNguoiDung"].Refresh();
        }
    }
}