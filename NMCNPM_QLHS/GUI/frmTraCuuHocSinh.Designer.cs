﻿namespace NMCNPM_QLHS.GUI
{
    partial class frmTraCuuHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cboHocSinh = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.dgvQuaTrinhHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_NamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_Lop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_HocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_DiemTBHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboHocSinh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(677, 89);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(677, 89);
            this.Root.TextVisible = false;
            // 
            // cboHocSinh
            // 
            this.cboHocSinh.Location = new System.Drawing.Point(75, 42);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocSinh.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboHocSinh.Size = new System.Drawing.Size(578, 20);
            this.cboHocSinh.StyleController = this.layoutControl1;
            this.cboHocSinh.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboHocSinh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(633, 27);
            this.layoutControlItem1.Text = "Học sinh: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 13);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(657, 69);
            this.layoutControlGroup1.Text = "Thông tin học sinh";
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(0, 89);
            this.gridControlHocSinh.MainView = this.dgvQuaTrinhHoc;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(677, 355);
            this.gridControlHocSinh.TabIndex = 3;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvQuaTrinhHoc});
            // 
            // dgvQuaTrinhHoc
            // 
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvQuaTrinhHoc.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvQuaTrinhHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maHS,
            this.col_hoTen,
            this.col_NamHoc,
            this.col_Lop,
            this.col_HocKy,
            this.col_DiemTBHK});
            this.dgvQuaTrinhHoc.GridControl = this.gridControlHocSinh;
            this.dgvQuaTrinhHoc.GroupPanelText = "QUÁ TRÌNH HỌC";
            this.dgvQuaTrinhHoc.Name = "dgvQuaTrinhHoc";
            this.dgvQuaTrinhHoc.OptionsBehavior.Editable = false;
            this.dgvQuaTrinhHoc.OptionsView.ShowFooter = true;
            // 
            // col_maHS
            // 
            this.col_maHS.Caption = "Mã Học Sinh";
            this.col_maHS.ColumnEdit = this.col_maHS_edit;
            this.col_maHS.FieldName = "MAHS";
            this.col_maHS.MinWidth = 21;
            this.col_maHS.Name = "col_maHS";
            this.col_maHS.Visible = true;
            this.col_maHS.VisibleIndex = 0;
            this.col_maHS.Width = 81;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_hoTen
            // 
            this.col_hoTen.Caption = "Họ Tên";
            this.col_hoTen.ColumnEdit = this.col_hoTen_edit;
            this.col_hoTen.FieldName = "HOTEN";
            this.col_hoTen.MinWidth = 21;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.Visible = true;
            this.col_hoTen.VisibleIndex = 1;
            this.col_hoTen.Width = 81;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_NamHoc
            // 
            this.col_NamHoc.Caption = "Năm học";
            this.col_NamHoc.MinWidth = 21;
            this.col_NamHoc.Name = "col_NamHoc";
            this.col_NamHoc.Visible = true;
            this.col_NamHoc.VisibleIndex = 2;
            this.col_NamHoc.Width = 81;
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_Lop
            // 
            this.col_Lop.Caption = "Lớp";
            this.col_Lop.MinWidth = 21;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Visible = true;
            this.col_Lop.VisibleIndex = 3;
            this.col_Lop.Width = 81;
            // 
            // col_ngaySinh_edit
            // 
            this.col_ngaySinh_edit.AutoHeight = false;
            this.col_ngaySinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.Name = "col_ngaySinh_edit";
            // 
            // col_HocKy
            // 
            this.col_HocKy.Caption = "Học kỳ";
            this.col_HocKy.MinWidth = 21;
            this.col_HocKy.Name = "col_HocKy";
            this.col_HocKy.Visible = true;
            this.col_HocKy.VisibleIndex = 4;
            this.col_HocKy.Width = 81;
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_DiemTBHK
            // 
            this.col_DiemTBHK.Caption = "Điểm trung bình";
            this.col_DiemTBHK.MinWidth = 21;
            this.col_DiemTBHK.Name = "col_DiemTBHK";
            this.col_DiemTBHK.Visible = true;
            this.col_DiemTBHK.VisibleIndex = 5;
            this.col_DiemTBHK.Width = 81;
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            // 
            // frmTraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 444);
            this.Controls.Add(this.gridControlHocSinh);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTraCuuHocSinh";
            this.Text = "Quá trình học";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SearchLookUpEdit cboHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvQuaTrinhHoc;
        private DevExpress.XtraGrid.Columns.GridColumn col_maHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_hoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_NamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn col_Lop;
        private DevExpress.XtraGrid.Columns.GridColumn col_HocKy;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiemTBHK;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
    }
}