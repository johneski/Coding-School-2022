namespace Session_11
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            this.gridCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlFullname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.Layout = new DevExpress.XtraLayout.LayoutControlItem();
            this.Surname = new DevExpress.XtraLayout.LayoutControlItem();
            this.TelephoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.TIN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCustomerList.Location = new System.Drawing.Point(12, 132);
            this.gridCustomerList.MainView = this.gridViewCustomers;
            this.gridCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.Size = new System.Drawing.Size(680, 142);
            this.gridCustomerList.TabIndex = 6;
            this.gridCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridName,
            this.gridSurname,
            this.gridPhone,
            this.gridTIN,
            this.gridStatus});
            this.gridViewCustomers.DetailHeight = 262;
            this.gridViewCustomers.GridControl = this.gridCustomerList;
            this.gridViewCustomers.Name = "gridViewCustomers";
            // 
            // gridName
            // 
            this.gridName.Caption = "Name";
            this.gridName.FieldName = "Name";
            this.gridName.MinWidth = 22;
            this.gridName.Name = "gridName";
            this.gridName.Visible = true;
            this.gridName.VisibleIndex = 0;
            this.gridName.Width = 82;
            // 
            // gridSurname
            // 
            this.gridSurname.Caption = "Surname";
            this.gridSurname.FieldName = "Surname";
            this.gridSurname.MinWidth = 22;
            this.gridSurname.Name = "gridSurname";
            this.gridSurname.Visible = true;
            this.gridSurname.VisibleIndex = 1;
            this.gridSurname.Width = 82;
            // 
            // gridPhone
            // 
            this.gridPhone.Caption = "Phone";
            this.gridPhone.FieldName = "PhoneNumber";
            this.gridPhone.MinWidth = 22;
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.Visible = true;
            this.gridPhone.VisibleIndex = 2;
            this.gridPhone.Width = 82;
            // 
            // gridTIN
            // 
            this.gridTIN.Caption = "TIN";
            this.gridTIN.FieldName = "Tin";
            this.gridTIN.MinWidth = 22;
            this.gridTIN.Name = "gridTIN";
            this.gridTIN.Visible = true;
            this.gridTIN.VisibleIndex = 3;
            this.gridTIN.Width = 82;
            // 
            // gridStatus
            // 
            this.gridStatus.Caption = "Status";
            this.gridStatus.FieldName = "ObjectStatus";
            this.gridStatus.Name = "gridStatus";
            this.gridStatus.Width = 66;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(111, 36);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(107, 20);
            this.ctrlName.StyleController = this.layoutControl1;
            this.ctrlName.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.ctrlFullname);
            this.layoutControl1.Controls.Add(this.gridCustomerList);
            this.layoutControl1.Controls.Add(this.ctrlTIN);
            this.layoutControl1.Controls.Add(this.ctrlPhoneNumber);
            this.layoutControl1.Controls.Add(this.ctrlName);
            this.layoutControl1.Controls.Add(this.ctrlSurname);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1135, 77, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(704, 338);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(354, 304);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(338, 22);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(12, 304);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(338, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(354, 278);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(338, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(12, 278);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(338, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ctrlFullname
            // 
            this.ctrlFullname.Location = new System.Drawing.Point(111, 12);
            this.ctrlFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlFullname.Name = "ctrlFullname";
            this.ctrlFullname.Size = new System.Drawing.Size(153, 20);
            this.ctrlFullname.StyleController = this.layoutControl1;
            this.ctrlFullname.TabIndex = 0;
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(111, 108);
            this.ctrlTIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Size = new System.Drawing.Size(107, 20);
            this.ctrlTIN.StyleController = this.layoutControl1;
            this.ctrlTIN.TabIndex = 5;
            // 
            // ctrlPhoneNumber
            // 
            this.ctrlPhoneNumber.Location = new System.Drawing.Point(111, 84);
            this.ctrlPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlPhoneNumber.Name = "ctrlPhoneNumber";
            this.ctrlPhoneNumber.Size = new System.Drawing.Size(107, 20);
            this.ctrlPhoneNumber.StyleController = this.layoutControl1;
            this.ctrlPhoneNumber.TabIndex = 4;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(111, 60);
            this.ctrlSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(107, 20);
            this.ctrlSurname.StyleController = this.layoutControl1;
            this.ctrlSurname.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FullName,
            this.Layout,
            this.Surname,
            this.TelephoneNumber,
            this.TIN,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(704, 338);
            this.Root.TextVisible = false;
            // 
            // FullName
            // 
            this.FullName.Control = this.ctrlFullname;
            this.FullName.Location = new System.Drawing.Point(0, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(256, 24);
            this.FullName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // Layout
            // 
            this.Layout.Control = this.ctrlName;
            this.Layout.Location = new System.Drawing.Point(0, 24);
            this.Layout.Name = "Name";
            this.Layout.Size = new System.Drawing.Size(210, 24);
            this.Layout.TextSize = new System.Drawing.Size(87, 13);
            // 
            // Surname
            // 
            this.Surname.Control = this.ctrlSurname;
            this.Surname.Location = new System.Drawing.Point(0, 48);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(210, 24);
            this.Surname.TextSize = new System.Drawing.Size(87, 13);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Control = this.ctrlPhoneNumber;
            this.TelephoneNumber.Location = new System.Drawing.Point(0, 72);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Size = new System.Drawing.Size(210, 24);
            this.TelephoneNumber.TextSize = new System.Drawing.Size(87, 13);
            // 
            // TIN
            // 
            this.TIN.Control = this.ctrlTIN;
            this.TIN.Location = new System.Drawing.Point(0, 96);
            this.TIN.Name = "TIN";
            this.TIN.Size = new System.Drawing.Size(210, 24);
            this.TIN.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridCustomerList;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(684, 146);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnNew;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 266);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(342, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(342, 266);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(342, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnDelete;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 292);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(342, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnClose;
            this.layoutControlItem10.Location = new System.Drawing.Point(342, 292);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(342, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(256, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(428, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(210, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(474, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(210, 48);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(474, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(210, 72);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(474, 24);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(210, 96);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(474, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 338);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCustomer";
            this.Text = "FormCustomers";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridTIN;
        private BindingSource bsCustomers;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlFullname;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.TextEdit ctrlPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem FullName;
        private DevExpress.XtraLayout.LayoutControlItem Layout;
        private DevExpress.XtraLayout.LayoutControlItem Surname;
        private DevExpress.XtraLayout.LayoutControlItem TelephoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem TIN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraGrid.Columns.GridColumn gridStatus;
    }
}