namespace Celcius_to_Fahrenheit
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettava astetta tai antanut oikea lukua";
                VastausLB.Visible = true;
            }
        }
    }
}