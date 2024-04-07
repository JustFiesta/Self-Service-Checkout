namespace Self_Service_Checkout
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //important for function -> mainForm_FormClosed
            this.FormClosed += mainForm_FormClosed;
        }
        //a super special function that removes applications running in the background
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
