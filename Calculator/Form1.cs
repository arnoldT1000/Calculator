using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        //local variables

        //boolean variables
        private bool button2WasClicked = false;
        private bool mbuttonWasClicked = false;
        private bool divbuttonWasClicked = false;
        private bool button5WasClicked = false;
        
        //string variables
        public string expr = ""; 

        //int variables
        private int num1, num2, result;
        public int numplus,numminus, nummult, numdiv, len, lenmin, lenmult, lendiv;
        
        // float variables
        float resultfloat, num1float, num2float;

        public Form1()
        {
            InitializeComponent();
        }


        //clear button method
        private void clrButton_Click(object sender, EventArgs e)
        {
            //set variables to zero
            num1= 0;
            num2 = 0;
            DisplayLabel.Text = "";
            
        }

        //divide method
        private void divButton_Click(object sender, EventArgs e)
        {
            divbuttonWasClicked = true;
            //initialize blank variable
            DisplayLabel.Text = "";

            
            expr = button1.Text + "/";
            
            
            
            // numdiv finds location of / symbol
            numdiv = expr.IndexOf("/");

            // lendiv is integer value location of / symbol 
            lendiv = numdiv;

            // find integer value in front of / symbol
            num1 = int.Parse(expr.Substring(0, lendiv));

            // result is the total in addition to num1
            result = result + num1;

            //display now reads 1/
            DisplayLabel.Text = expr;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close application with x symbol
            Application.Exit();
        }


        // multiply button method
        private void multButton_Click(object sender, EventArgs e)
        {
            mbuttonWasClicked = true;
            DisplayLabel.Text = "";
            expr = button1.Text + "*";
            DisplayLabel.Text = "*";



            // numdiv finds location of * symbol
            nummult = expr.IndexOf("*");

            // lendiv is integer value location of * symbol
            lenmult = nummult;

            // find integer value in front of * symbol
            num1 = int.Parse(expr.Substring(0, lenmult));

            // result is the total in addition to num1
            result = result + num1;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = button1.Text;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            DisplayLabel.Text = "";
            expr = button1.Text;
            
            num1 = int.Parse(expr);

            result = result + num1;

            expr = expr + "-";
            numminus = expr.IndexOf("-");
            lenmin = numminus;

            num1 = int.Parse(expr.Substring(0, lenmin));
            result = result + num1;

            DisplayLabel.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
            expr = button3.Text;
            DisplayLabel.Text = expr; 

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            button2WasClicked = true;
            DisplayLabel.Text = "";
            expr = button1.Text + "+";
            
            num1 = int.Parse(button1.Text);

            result = result + num1;
            //Console.WriteLine(result); expr = expr + "+";
            numplus = expr.IndexOf("+");
            len = numplus;
                 
            num1 = int.Parse(expr.Substring(0, len));
            result = result + num1;
                
            DisplayLabel.Text = "+";
            
        }

        //equal button pressed

        private void button4_Click(object sender, EventArgs e)
        {
            // + sign clicked
            if(button2WasClicked)
            {

                //num2 set to value 2
                num2 = int.Parse(button3.Text);

                // expression 1+2
                expr = expr + num2.ToString();


                // add num1 and num2
                result = num1 + num2;

                // display sum in label
                DisplayLabel.Text = result.ToString(); 

                // disable all buttons
                button2.Enabled = false; 
                button5.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                multButton.Enabled = false;
                divButton.Enabled = false;
                clrButton.Enabled = false;
                num1 = 0;
                num2 = 0;
                result = 0;
                
            }

            // minus button clicked in expression
            else if (button5WasClicked)
            {
                //num2 set to 2
                num2 = 2;

                // expression 1-2
                expr = expr + num2.ToString();
                
                // subtract 1-2
                result = num1 - num2;

                // display label of the result
                DisplayLabel.Text = result.ToString();

                // disable all buttons
                button5.Enabled = false; 
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false; 
                multButton.Enabled = false;
                divButton.Enabled = false;
                clrButton.Enabled = false;
                num1 = 0;
                num2 = 0;
                result = 0;
            }

            // multiply button clicked in expression
            else if (mbuttonWasClicked)
            {
                // num2 set to 2
                num2 = 2;

                // expression set 1*2
                expr = expr + num2.ToString();
                

                // result is total of num1 and num2
                result = num1 * num2;

                // display label of result value
                DisplayLabel.Text = result.ToString();

                // disable all buttons
                button5.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                multButton.Enabled = false;
                divButton.Enabled = false;
                clrButton.Enabled = false;
                num1 = 0;
                num2 = 0;
                result = 0;
            }

            // divide button clicked in expression
            else if (divbuttonWasClicked)
            {
                // num1 convert to float
                num1float = float.Parse(num1.ToString());

                //num2 convert to float
                num2 = 2;
                num2float = float.Parse(num2.ToString());

                // expression reads 1.0 / 2.0
                expr = expr + num2float.ToString();
                
                // resultfloat stores value num1float div num2float
                resultfloat = num1float / num2float;

                // display label of the result of num1float/num2float
                DisplayLabel.Text = resultfloat.ToString();

                //disable all buttons
                button5.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                multButton.Enabled = false;
                divButton.Enabled = false;
                clrButton.Enabled = false;
                num1 = 0;
                num2 = 0;
                result = 0;
            }

            // reset everything else to zero
            else
            {
                num1 = 0;
                num2 = 0;
                result = 0;
                DisplayLabel.Text = "";

                // disable all buttons
                button5.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false; 
                clrButton.Enabled = false; 
                multButton.Enabled = false;
                divButton.Enabled = false;
            } 


        }
    }
}
