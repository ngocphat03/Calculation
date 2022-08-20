namespace calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calculation, cache;
        float mathFuction1, mathFuction2;
        private void button1_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "0";
            cache += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "9";
            cache += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "1";
            cache += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "2";
            cache += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "3";
            cache += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "4";
            cache += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "5";
            cache += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "6";
            cache += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "7";
            cache += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + "8";
            cache += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            screenOutput.Text = screenOutput.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calculation == "addition")
            {
                mathFuction2 = mathFuction1 + float.Parse(cache);
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
            if (calculation == "subtraction")
            {
                mathFuction2 = mathFuction1 - float.Parse(cache);
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
            if (calculation == "multiplication")
            {
                mathFuction2 = mathFuction1 * float.Parse(cache);
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
            if (calculation == "division")
            {
                mathFuction2 = mathFuction1 / float.Parse(cache);
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
            if (calculation == "negative")
            {
                mathFuction2 = mathFuction1 * -1;
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
            if (calculation == "percent")
            {
                mathFuction2 = mathFuction1 * Convert.ToSingle(0.01);
                screenOutput.Text = mathFuction2.ToString();
                cache = mathFuction2.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculation = "subtraction";
            screenOutput.Text = screenOutput.Text + "-";
            mathFuction1 = float.Parse(cache);
            cache = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculation = "multiplication";
            screenOutput.Text = screenOutput.Text + "x";
            mathFuction1 = float.Parse(cache);
            cache = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculation = "division";
            screenOutput.Text = screenOutput.Text + "/";
            mathFuction1 = float.Parse(cache);
            cache = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calculation = "negative";
            screenOutput.Text = "-" + screenOutput.Text;
            mathFuction1 = float.Parse(cache);
            cache = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            calculation = "percent";
            screenOutput.Text = screenOutput.Text + "%";
            mathFuction1 = float.Parse(cache);
            cache = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenOutput.Clear();
            cache = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculation = "addition";
            screenOutput.Text = screenOutput.Text + "+";
            mathFuction1 = float.Parse(cache);
            cache = "";
        }
    }
}