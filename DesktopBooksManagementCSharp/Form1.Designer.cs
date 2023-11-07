namespace DesktopBooksManagementCSharp
{
    partial class MainForm
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
            this.grdBooks = new DevExpress.XtraGrid.GridControl();
            this.gridViewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPublished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthor = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthor = new DevExpress.XtraEditors.TextEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPages = new DevExpress.XtraEditors.TextEdit();
            this.lblPublished = new DevExpress.XtraEditors.LabelControl();
            this.dtPublished = new DevExpress.XtraEditors.DateEdit();
            this.lblPages = new DevExpress.XtraEditors.LabelControl();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPublished.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPublished.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBooks
            // 
            this.grdBooks.Location = new System.Drawing.Point(10, 241);
            this.grdBooks.MainView = this.gridViewBooks;
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(860, 300);
            this.grdBooks.TabIndex = 0;
            this.grdBooks.UseEmbeddedNavigator = true;
            this.grdBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBooks});
            // 
            // gridViewBooks
            // 
            this.gridViewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColId,
            this.grdColTitle,
            this.grdColAuthor,
            this.grdColDescription,
            this.grdColPublished,
            this.grdColPages});
            this.gridViewBooks.GridControl = this.grdBooks;
            this.gridViewBooks.Name = "gridViewBooks";
            this.gridViewBooks.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewBooks.OptionsSelection.MultiSelect = true;
            this.gridViewBooks.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewBooks.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewBooks.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBooks_FocusedRowChanged);
            // 
            // grdColId
            // 
            this.grdColId.Caption = "Id";
            this.grdColId.FieldName = "Oid";
            this.grdColId.MinWidth = 25;
            this.grdColId.Name = "grdColId";
            this.grdColId.OptionsColumn.ReadOnly = true;
            this.grdColId.Visible = true;
            this.grdColId.VisibleIndex = 5;
            this.grdColId.Width = 94;
            // 
            // grdColTitle
            // 
            this.grdColTitle.Caption = "Title";
            this.grdColTitle.FieldName = "Title";
            this.grdColTitle.MinWidth = 25;
            this.grdColTitle.Name = "grdColTitle";
            this.grdColTitle.Visible = true;
            this.grdColTitle.VisibleIndex = 1;
            this.grdColTitle.Width = 146;
            // 
            // grdColAuthor
            // 
            this.grdColAuthor.Caption = "Author";
            this.grdColAuthor.FieldName = "Author";
            this.grdColAuthor.MinWidth = 25;
            this.grdColAuthor.Name = "grdColAuthor";
            this.grdColAuthor.Visible = true;
            this.grdColAuthor.VisibleIndex = 2;
            this.grdColAuthor.Width = 146;
            // 
            // grdColDescription
            // 
            this.grdColDescription.Caption = "Description";
            this.grdColDescription.FieldName = "Description";
            this.grdColDescription.MinWidth = 25;
            this.grdColDescription.Name = "grdColDescription";
            this.grdColDescription.Visible = true;
            this.grdColDescription.VisibleIndex = 3;
            this.grdColDescription.Width = 240;
            // 
            // grdColPublished
            // 
            this.grdColPublished.Caption = "Published";
            this.grdColPublished.FieldName = "Published";
            this.grdColPublished.MinWidth = 25;
            this.grdColPublished.Name = "grdColPublished";
            this.grdColPublished.Visible = true;
            this.grdColPublished.VisibleIndex = 4;
            this.grdColPublished.Width = 109;
            // 
            // grdColPages
            // 
            this.grdColPages.Caption = "Pages";
            this.grdColPages.FieldName = "Pages";
            this.grdColPages.MinWidth = 25;
            this.grdColPages.Name = "grdColPages";
            this.grdColPages.Visible = true;
            this.grdColPages.VisibleIndex = 6;
            this.grdColPages.Width = 94;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(48, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(35, 47);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 16);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(10, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(94, 44);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(264, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(94, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(264, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 84);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 107);
            this.txtDescription.TabIndex = 7;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(464, 41);
            this.txtPages.Name = "txtPages";
            this.txtPages.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPages.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPages.Properties.MaskSettings.Set("mask", "d");
            this.txtPages.Size = new System.Drawing.Size(153, 22);
            this.txtPages.TabIndex = 9;
            // 
            // lblPublished
            // 
            this.lblPublished.Location = new System.Drawing.Point(398, 15);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(59, 16);
            this.lblPublished.TabIndex = 8;
            this.lblPublished.Text = "Published:";
            // 
            // dtPublished
            // 
            this.dtPublished.EditValue = null;
            this.dtPublished.Location = new System.Drawing.Point(464, 13);
            this.dtPublished.Name = "dtPublished";
            this.dtPublished.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPublished.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPublished.Properties.MaskSettings.Set("mask", "d");
            this.dtPublished.Properties.UseMaskAsDisplayFormat = true;
            this.dtPublished.Size = new System.Drawing.Size(153, 22);
            this.dtPublished.TabIndex = 10;
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(418, 44);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(39, 16);
            this.lblPages.TabIndex = 11;
            this.lblPages.Text = "Pages:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(94, 206);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(94, 29);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(441, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 16);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(464, 78);
            this.txtId.Name = "txtId";
            this.txtId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtId.Properties.MaskSettings.Set("mask", "d");
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(153, 22);
            this.txtId.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.dtPublished);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.lblPublished);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdBooks);
            this.Name = "MainForm";
            this.Text = "Books Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPublished.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPublished.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBooks;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTitle;
        private DevExpress.XtraGrid.Columns.GridColumn grdColAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPublished;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPages;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl lblAuthor;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtAuthor;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.TextEdit txtPages;
        private DevExpress.XtraEditors.LabelControl lblPublished;
        private DevExpress.XtraEditors.DateEdit dtPublished;
        private DevExpress.XtraEditors.LabelControl lblPages;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn grdColId;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.TextEdit txtId;
    }
}

