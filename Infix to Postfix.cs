using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infix_to_Prefix_and_Postfix_Conversion_Program
{
    public partial class Infix_to_Postfix : Form
    {
        public Infix_to_Postfix()
        {
            InitializeComponent();
        }
        public static string ConverttoPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";

            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];

                if (Char.IsDigit(c) || Char.IsLetter(c))
                {
                    postfix += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }

        private static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        //function for to check if toPrefixInput textbox is empty
        private void CheckInput(string input)
        {
            // string input = textBox1.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter an Infix expression in the textbox.");
                return;
            }
        }

        //function for buttong to execute the Infix to Postfix Convert function
        private void Infix_to_Postfix_Click(object sender, EventArgs e)
        {
            CheckInput(toPostfixInput.Text);
            toPostfixResult.Text = ConverttoPostfix(toPostfixInput.Text);
        }


        //function to prevent user from inputting consecutive characters in the textbox such as AA, 11, ++
        //only single characters are allowed
        private void toPostfixInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetterOrDigit(keyPressed) || "+-*/^()".Contains(keyPressed) || keyPressed == '\b')
            {
                if (keyPressed != '\b' && toPostfixInput.Text.Length > 0)
                {
                    char lastChar = toPostfixInput.Text[toPostfixInput.Text.Length - 1];
                    if (Char.IsLetterOrDigit(keyPressed) && Char.IsLetterOrDigit(lastChar))
                    {
                        e.Handled = true;
                    }
                    else if ("+-*/^".Contains(keyPressed) && "+-*/^".Contains(lastChar))
                    {
                        e.Handled = true;
                    }
                    else if (keyPressed == ')' && toPostfixInput.Text.Count(c => c == '(') <= toPostfixInput.Text.Count(c => c == ')'))
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
