using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Calculator_App
{
    public partial class ResultCalculatorForm : Form
    {
        public ResultCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void marksShowButton_Click(object sender, EventArgs e)
        {
            ResultCalculator aResultCalculator = new ResultCalculator();
            aResultCalculator.MarksPhysics = Convert.ToDouble(marksPhysicaTextBox.Text);
            aResultCalculator.MarksMath = Convert.ToDouble(marksMathTextBox.Text);
            aResultCalculator.MarksChemistry = Convert.ToDouble(marksChemistryTextBox.Text);



            marksAverageTextBox.Text = aResultCalculator.GetMarksAverage().ToString();
            marksGradeLetterTextBox.Text = aResultCalculator.GetGradeLetter().ToString();





        }

      
    }
}
