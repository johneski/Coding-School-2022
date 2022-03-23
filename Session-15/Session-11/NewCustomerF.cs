using PetShopLibrary.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class NewCustomerF : Form
    {
        private PetShopManager _petShopManager;
        private Customer _customer = new Customer();
        public NewCustomerF(PetShopManager manager)
        {
            InitializeComponent();
            _petShopManager = manager;
        }

        private void NewCustomerF_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Add(new Binding("EditValue", _customer, "Name", true));
            txtSurname.DataBindings.Add(new Binding("EditValue", _customer, "Surname", true));
            txtPhoneNumber.DataBindings.Add(new Binding("EditValue", _customer, "PhoneNumber", true));
            txtTin.DataBindings.Add(new Binding("EditValue", _customer, "Tin", true));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _petShopManager.Add(_customer);
            _petShopManager.Save();
            this.Close();
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, "Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                this.Close();
        }
    }
}
