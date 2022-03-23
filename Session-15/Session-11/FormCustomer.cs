using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using PetShopLibrary;
using PetShopLibrary.DataObjects;
using PetShopLibrary.EF;

namespace Session_11
{
    public partial class FormCustomer : Form
    {

        private Customer _customer = new Customer();
        CustomerPolicies _customerpolicies = new CustomerPolicies();
        private List<Customer> CustomerList;
        private PetShopManager _petshopManager;
        private bool allowChange = false;



        public FormCustomer(PetShopManager petshopManager)
        {
            InitializeComponent();
            this.CenterToScreen();
            _petshopManager = petshopManager;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadToCustomerList();
            SetDataBindings();
            InitialView();            
        }

        private void InitialView()
        {
            gridViewCustomers.OptionsBehavior.Editable = false;
            gridViewCustomers.Columns["ObjectStatus"].FilterInfo = new ColumnFilterInfo("ObjectStatus == 'Active'");
            ctrlFullname.ReadOnly = true;
            ctrlFullname.BackColor = System.Drawing.SystemColors.Window;
        }

        private void LoadToCustomerList()
        {
            CustomerList = _petshopManager.GetCustomers();
        }

        private void SetDataBindings()
        {
            BindingSource bsCustomers = new BindingSource();
            bsCustomers.DataSource = CustomerList;
            gridCustomerList.DataSource = bsCustomers;

            if (CustomerList.Count > 0)
            {
                BindCellsWithCustomer();
            }


        }

        private void BindCellsWithCustomer()
        {
            ctrlFullname.DataBindings.Add("EditValue", gridViewCustomers.DataSource, "Fullname", true);
            ctrlName.DataBindings.Add("EditValue", gridViewCustomers.DataSource, "Name", true);
            ctrlSurname.DataBindings.Add("EditValue", gridViewCustomers.DataSource, "Surname", true);
            ctrlPhoneNumber.DataBindings.Add("EditValue", gridViewCustomers.DataSource, "PhoneNumber", true);
            ctrlTIN.DataBindings.Add("EditValue", gridViewCustomers.DataSource, "Tin", true);
            gridViewCustomers.RefreshData();
        }


        
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _petshopManager.Save();
            MessageBox.Show("Record saved!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void DeleteCustomer()
        {
            if (gridViewCustomers.RowCount <= 0) return;

            var customer = gridViewCustomers.GetFocusedRow() as Customer;
            _petshopManager.Delete(customer);
            gridViewCustomers.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer();
        }



        private void OnRowFocusChange(object sender, EventArgs e)
        {
            OutOfFocusDeleteNewCustomer();

        }


        private void SaveCustomerToGrid(CustomerPolicies _customerpolicies)
        {
            if (_customerpolicies.CheckValidSave(ctrlPhoneNumber.Text, ctrlTIN.Text))
            {

                var _rowCustomer = (gridViewCustomers.GetFocusedRow() as Customer);

                _rowCustomer.Tin = ctrlTIN.Text;
                _rowCustomer.Name = ctrlName.Text;
                _rowCustomer.Surname = ctrlSurname.Text;
                _rowCustomer.PhoneNumber = ctrlPhoneNumber.Text;
                _petshopManager.Add(_rowCustomer);
                gridViewCustomers.RefreshData();

            }
            else
            {
                MessageBox.Show("Could not save last input.", "Save-Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign);
                gridViewCustomers.RefreshData();
            }
        }

        private void NewCustomer()
        {
            NewCustomerF form = new NewCustomerF(_petshopManager);
            form.ShowDialog();
            bsCustomers.DataSource = _petshopManager.GetCustomers();
            gridCustomerList.DataSource = bsCustomers;
            gridCustomerList.Refresh();
        }
        
        private void SaveCustomer()
        {
            _petshopManager.Save();
        }



        private void OutOfFocusDeleteNewCustomer()
        {
            var row = gridViewCustomers.GetRow(gridViewCustomers.RowCount - 1) as Customer;
            if (row.Tin == "Insert TIN" && allowChange)
            {
                gridViewCustomers.DeleteRow(gridViewCustomers.RowCount - 1);
                allowChange = true;
            }
        }





    }
}