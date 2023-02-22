namespace Infix_to_Prefix_and_Postfix_Conversion_Program
{
    public partial class ConverterHomepage : Form
    {
        public ConverterHomepage()
        {
            InitializeComponent();
        }

        private void PrefixBtn_Click(object sender, EventArgs e)
        {
            Infix_to_Prefix form = new Infix_to_Prefix();
            form.Show();
        }

        private void PostfixBtn_Click(object sender, EventArgs e)
        {
            Infix_to_Postfix form = new Infix_to_Postfix();
            form.Show();
        }

        private void QuickBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}