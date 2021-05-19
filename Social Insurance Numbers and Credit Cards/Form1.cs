using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Social_Insurance_Numbers_and_Credit_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 1. It is possible to devise an account number which is self-checking to prevent fraud or clerical errors. One digit in the
         * number is assigned by some fixed sequence of operations on the other digits. Assume that the account numbers are ten
         * digits and the left most digit is the check digit. The account number is validated in the following way.
         * Account Number -> 8213267894
         * Last 9 digits -> 213267894
         * 2*2 + 1*2 + 3*2 + 2*2 + 6*2 +7*2 + 8*2 + 9*2 + 4*2 = 84
         * If the first digit of the sum of the last nine digits doubled is the check digit the account number is valid. Write a
         * program to check a set of account numbers. Your output should list each account number and below it the word valid
         * or invalid. The number 1111111111 is a valid number.*/
        private void Btn_Number_Validator_Click(object sender, EventArgs e)
        {
            string accountNumber;

            do
            {
                accountNumber = Interaction.InputBox("Enter an account number 10 digits long", "", "");

                if (accountNumber.Length != 10)
                    MessageBox.Show("Account Number is not 10 digits long.");
            } while (accountNumber.Length != 10);

            char checkValue = Convert.ToChar(accountNumber.Substring(0, 1));
            string evaluationNumber = accountNumber.Substring(1);
            int sum = 0;

            for (int digit = 0; digit < evaluationNumber.Length; digit++)
                sum += Convert.ToInt32(evaluationNumber.Substring(digit, 1)) * 2;
            
            if (Convert.ToString(sum).Substring(0,1) == checkValue.ToString())
                TxtDisplay.Text = "Account Number: " + accountNumber.ToString() + Environment.NewLine + "Is Valid.";
            else
                TxtDisplay.Text = accountNumber.ToString() + Environment.NewLine + "Is Invalid.";

        }

        /* 2. J.M. Schneider Ltd. has a very sophisticated computer operation. As with most computerized operations, each product
         * is referred to with a unique product code. The first 4 digits are information digits and the last is a check digit. The
         * checking system involves modulo 11 arithmetic. Here's how it works:
         * Example: code -> 43982
         * 5*4 + 4*3 + 3*9 + 2*8 = 75
         * Take the sum 75 and divide it by 11
         * Keep the remainder only -> 9
         * Then do 11 - 9 = 2 this answer should equal the check digit to be a valid product code.
         * Write a program to check the validity of any number of (J.M. Schneider) product codes.*/
        private void Btn_Product_Codes_Click(object sender, EventArgs e)
        {
            string productCode;
            int divider = 11;
            do
                productCode = Interaction.InputBox("Enter a product code 5 digits long", "", "");
            while (productCode.Length != 5);

            string checkValue = productCode.Substring(4, 1); // e.g) check digit is 2
            string evaluationNumber = productCode.Substring(0,4); //e.g) evaluation code is 4398

            string a = evaluationNumber.Substring(3, 1);
            string b = evaluationNumber.Substring(2, 1);

            int sum = productCode.Length * Convert.ToInt32(evaluationNumber.Substring(0, 1)); // e.g.) 5 * 4 = 20
            sum += Convert.ToInt32(evaluationNumber.Substring(0, 1)) * Convert.ToInt32(evaluationNumber.Substring(1, 1)); // e.g.) 20 + (4 * 3) = 32
            sum += Convert.ToInt32(evaluationNumber.Substring(1, 1)) * Convert.ToInt32(evaluationNumber.Substring(2, 1)); // e.g.) 32 + (3 * 9) = 59
            sum += Convert.ToInt32(evaluationNumber.Substring(3, 1)) * Convert.ToInt32(checkValue); // e.g.) 59 + (8 * 2) = 75
            
            int remainder = sum % divider; // e.g) 9

            if (divider - remainder == Convert.ToInt32(checkValue)) // e.g) 11 - 9 = 2
                TxtDisplay.Text = "Product Code: " + productCode + Environment.NewLine + "Is Valid.";
            else
                TxtDisplay.Text = "Product Code: " + productCode + Environment.NewLine + "Is Invalid.";
        }
    }
}
