namespace GPAaCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPAcal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxG_Click(object sender, EventArgs e)
        {
            string input = this.TextBoxGPA_input.Text;
            string name  = this.TextBoxName_Input.Text;
            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.getGPAX();
            TextBoxGPAxx.Text = gpax.ToString();

            double max = oGPAcal.getMax();
            TextBoxMaxGPA.Text = max.ToString();
            string maxname = oGPAcal.getMaxName();
            TextBoxMaxname.Text = maxname.ToString();

            double min = oGPAcal.getMin();
            TextBoxMinGPA.Text = min.ToString();
            string minname = oGPAcal.getMinName();
            TextBoxMinname.Text = minname.ToString();

            TextBoxGPA_input.Text = "";
            TextBoxName_Input.Text = string.Empty;
            TextBoxAllData.Text = oGPAcal.getAlldata();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxGPAxx.Text = "";
            TextBoxGPA_input.Text = "";
            TextBoxMinGPA.Text = "";
            TextBoxMaxGPA.Text = "";
            TextBoxMaxname.Text = "";
            TextBoxMinname.Text = "";

        }
    }
}