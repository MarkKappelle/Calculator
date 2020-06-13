using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        String mem_one;
        String mem_two;
        String mem_three;
        bool euro_mode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumClick(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0") || (operation_pressed == true))
                resultBox.Clear();
            Button bNum = (Button)sender;
            resultBox.Text = resultBox.Text + bNum.Text;
            operation_pressed = false;

        }

        private void OpClick(object sender, EventArgs e)
        {

            
            Button bNum = (Button)sender;
            operation = bNum.Text;
            if (resultBox.Text == null && operation == "-" )
            {
                resultBox.Text = resultBox.Text + bNum.Text;
                operation_pressed = true;
            }
            else
            {
                if (NumberCheck(resultBox.Text) == true)
                {
                    value = Double.Parse(resultBox.Text);
                    operation_pressed = true;
                    historyBox.Text = resultBox.Text;
                    resultBox.Text = resultBox.Text + bNum.Text;
                }
                else
                {
                    resultBox.Text = "Syntax Error";
                }

            }









        }

        private void solveClick(object sender, EventArgs e)

        {
            String result = "";

            if (NumberCheck(resultBox.Text) == true)
            {
                switch (operation)
                {
                    case "+":
                        result = (value + Double.Parse(resultBox.Text)).ToString();

                        if (euro_mode == true)
                        {
                            resultBox.Text = EuroConverter(result);

                        }
                        else
                        {
                            resultBox.Text = result;
                        }

                        break;

                    case "-":
                        result = (value - Double.Parse(resultBox.Text)).ToString();
                        if (euro_mode == true)
                        {
                            resultBox.Text = EuroConverter(result);

                        }
                        else
                        {
                            resultBox.Text = result;
                        }


                        break;
                    case "*":
                        result = (value * Double.Parse(resultBox.Text)).ToString();
                        if (euro_mode == true)
                        {
                            resultBox.Text = EuroConverter(result);

                        }
                        else
                        {
                            resultBox.Text = result;
                        }

                        break;

                    case "/":
                        result = (value / Double.Parse(resultBox.Text)).ToString();
                        if (euro_mode == true)
                        {
                            resultBox.Text = EuroConverter(result);

                        }
                        else
                        {
                            resultBox.Text = result;
                        }

                        break;
                    case "%":
                        result = ((Double.Parse(resultBox.Text) / value) * 100).ToString();
                        if (euro_mode == true)
                        {
                            resultBox.Text = EuroConverter(result);

                        }
                        else
                        {
                            resultBox.Text = result;
                        }

                        break;

                }
                historyBox.Clear();
                operation_pressed = true;
            }
            else
            {
                resultBox.Text = "Syntax Error";
            }






        }

        private void CClick(object sender, EventArgs e)
        {
            resultBox.Clear();
            historyBox.Clear();
            value = 0;
            operation_pressed = false;
        }

        private void CEClick(object sender, EventArgs e)
        {
            resultBox.Clear();
            operation_pressed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MemoryOneClick(object sender, EventArgs e)
        {

            if (mem_one == null)
            {
                if (NumberCheck(resultBox.Text) == true)
                {
                    mem_one = resultBox.Text;
                    operation_pressed = true;
                }
                else
                {
                    resultBox.Text = "Memory Error";
                }


            }
            else
            {
                resultBox.Text = mem_one;

            }



        }

        private void MemoryTwoClick(object sender, EventArgs e)
        {
            if (mem_two == null)
            {
                if (NumberCheck(resultBox.Text) == true)
                {
                    mem_two = resultBox.Text;
                    operation_pressed = true;
                }
                else
                {
                    resultBox.Text = "Memory Error";
                }


            }
            else
            {
                resultBox.Text = mem_two;

            }

        }

        private void MemoryThreeClick(object sender, EventArgs e)
        {

            if (mem_three == null)
            {
                if (NumberCheck(resultBox.Text) == true)
                {
                    mem_three = resultBox.Text;
                    operation_pressed = true;
                }
                else
                {
                    resultBox.Text = "Memory Error";
                }


            }
            else
            {
                resultBox.Text = mem_three;

            }
        }

        private void MemoryClearClick(object sender, EventArgs e)
        {
            mem_one = null;
            mem_two = null;
            mem_three = null;
            resultBox.Clear();

        }

        public bool NumberCheck(String check)
        {
            Double test;
            try
            {
                test = Double.Parse(check);
            }

            catch (System.FormatException)
            {
                return false;

            }
            return true;

        }


        private void CheckBox1_Euro(object sender, EventArgs e)
        {
            if (checkBoxEuro.Checked == true)
            {
                euro_mode = true;
            }
            else
            {
                euro_mode = false;
            }
        }

        public String EuroConverter(String bedrag)
        {
            Double getal = 0;
            Double afgerond = 0;
            String euro_string = "";

            if (NumberCheck(bedrag) == true)
            {
                getal = Double.Parse(bedrag);
                afgerond = (Math.Round(getal, 2));

                euro_string = ("€" + (afgerond).ToString());

                return euro_string;
            }

            else
            {
                return "Syntax Error";
            }

        
        }
    }

}
