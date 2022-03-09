namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculations.Validator Validator { get; set; }
        public Form1()
        {
            InitializeComponent();
            Validator = new Calculations.Validator();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '8');
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '1');
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '2');
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '5');
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '3');
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '0');
        }

        private void btnSeparator_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.ValidateEntry(this.txtResult.Text, ',');
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '6');
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '4');
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '9');
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '7');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '+');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '=');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Validator.Validate(this.txtResult.Text, '/');
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text.Substring(0, this.txtResult.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = String.Empty;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            string result = Validator.Validate(this.txtResult.Text, '=');
            this.txtResult.Text = Validator.Validate(result, '@');
        }
    }
}