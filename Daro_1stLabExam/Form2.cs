using System.Windows.Forms;

namespace Daro_1stLabExam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(double totalDanielle, double totalEdward, double totalFatima)
            : this()
        {
            labelDanielle.Text = $"Danielle: ₱{totalDanielle}";
            labelEdward.Text = $"Edward: ₱{totalEdward}";
            labelFatima.Text = $"Fatima: ₱{totalFatima}";
        }
    }
}
