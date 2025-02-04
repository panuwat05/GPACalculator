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
                if (input >= 0.00 && input <= 4.00)  // ��Ǩ�ͺ��ǧ��Ңͧ GPA
                {
                    gPACalculator.setGPA(input);

                    // �ѻവ��ҷҧ˹�Ҩ�
                    UpdateDisplay();

                    this.tbInputGpa.Clear(); // ��ҧ��� input ��ѧ�ҡ����
                }
                else
                {
                    MessageBox.Show("��سһ�͹��� GPA �����ҧ 0.00 - 4.00");
                    this.tbInputGpa.Clear();
                }
            }
            else
            {
                MessageBox.Show("��سһ�͹��ҷ���繵���Ţ��ҹ��");
                this.tbInputGpa.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ���絤�ҷ�����
            gPACalculator = new GPACalculator();

            // �ѻവ��ҷҧ˹�Ҩ�
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            // �ѻവ��������������Һ
            this.tbGpax.Text = gPACalculator.getGPAX().ToString("F2");
            this.tbGpaMax.Text = gPACalculator.getMaxGPA().ToString("F2");
            this.tbGpaMin.Text = gPACalculator.getMinGPA().ToString("F2");
            this.tbStudentCount.Text = gPACalculator.getStudentCount().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���絤�ҷ�����
            gPACalculator = new GPACalculator();

            // ��ҧ������� TextBox
            this.tbGpax.Clear();
            this.tbGpaMax.Clear();
            this.tbGpaMin.Clear();
            this.tbStudentCount.Clear();
            this.tbInputGpa.Clear();

            // �ѻവ˹�Ҩ�
            UpdateDisplay();
        }
    }
}
