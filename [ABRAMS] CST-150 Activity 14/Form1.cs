// Jared L. Abrams// CST-150// October 23, 2022// This is my own work

namespace _ABRAMS__CST_150_Activity_14
{
    public partial class Form1 : Form
    {
        List<String> Employee1 = new List<String>();
        List<String> Employee2 = new List<String>();


        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Employee1.Add("Dave");
            Employee1.Add("Septemeber 1, 2022");
            Employee2.Add("Steve");
            Employee2.Add("October 23, 2022");

            if (employee1Radio.Checked)
            {
                if (nameChk.Checked)
                {
                    outputBox.Items.Add(Employee1[0]);
                }
                if (doeChk.Checked)
                {
                    outputBox.Items.Add(Employee1[1]);
                }
            }

            if (employee2Radio.Checked)
            {
                if (nameChk.Checked)
                {
                    outputBox.Items.Add(Employee2[0]);
                }
                if (doeChk.Checked)
                {
                    outputBox.Items.Add(Employee2[1]);
                }
            }

        }
    }
}