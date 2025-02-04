namespace GPAx
{
    public partial class Form1 : Form
    {
        GPACalculator gPACalculator;

        public Form1()
        {
            InitializeComponent();
            gPACalculator = new GPACalculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.tbInputGpa.Text, out double input))
            {
                if (input >= 0.00 && input <= 4.00)  // µÃÇ¨ÊÍºªèÇ§¤èÒ¢Í§ GPA
                {
                    gPACalculator.setGPA(input);

                    // ÍÑ»à´µ¤èÒ·Ò§Ë¹éÒ¨Í
                    UpdateDisplay();

                    this.tbInputGpa.Clear(); // ÅéÒ§¤èÒ input ËÅÑ§¨Ò¡à¾ÔèÁ
                }
                else
                {
                    MessageBox.Show("¡ÃØ³Ò»éÍ¹¤èÒ GPA ÃĞËÇèÒ§ 0.00 - 4.00");
                    this.tbInputGpa.Clear();
                }
            }
            else
            {
                MessageBox.Show("¡ÃØ³Ò»éÍ¹¤èÒ·Õèà»ç¹µÑÇàÅ¢à·èÒ¹Ñé¹");
                this.tbInputGpa.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ÃÕà«çµ¤èÒ·Ñé§ËÁ´
            gPACalculator = new GPACalculator();

            // ÍÑ»à´µ¤èÒ·Ò§Ë¹éÒ¨Í
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            // ÍÑ»à´µ¢éÍÁÙÅãËé¼Ùéãªé·ÃÒº
            this.tbGpax.Text = gPACalculator.getGPAX().ToString("F2");
            this.tbGpaMax.Text = gPACalculator.getMaxGPA().ToString("F2");
            this.tbGpaMin.Text = gPACalculator.getMinGPA().ToString("F2");
            this.tbStudentCount.Text = gPACalculator.getStudentCount().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ÃÕà«çµ¤èÒ·Ñé§ËÁ´
            gPACalculator = new GPACalculator();

            // ÅéÒ§¢éÍÁÙÅã¹ TextBox
            this.tbGpax.Clear();
            this.tbGpaMax.Clear();
            this.tbGpaMin.Clear();
            this.tbStudentCount.Clear();
            this.tbInputGpa.Clear();

            // ÍÑ»à´µË¹éÒ¨Í
            UpdateDisplay();
        }
    }
}
