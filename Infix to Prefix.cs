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
    public partial class Infix_to_Prefix : Form
    {
        public Infix_to_Prefix()
        {
            InitializeComponent();
        }
        // Function to check if given character is an operator or not.
        static bool isOperator(char c)
        {
            return (!(c >= 'a' && c <= 'z') &&
                    !(c >= '0' && c <= '9') &&
                    !(c >= 'A' && c <= 'Z'));
        }

        // Function to find priority of given operator.
        static int getPriority(char C)
        {
            if (C == '-' || C == '+')
                return 1;
            else if (C == '*' || C == '/')
                return 2;
            else if (C == '^')
                return 3;
            return 0;
        }

        // Function that converts infix expression to prefix expression.
        static String infixToPrefix(String infix)
        {
            // stack for operators.
            Stack<char> operators = new Stack<char>();

            // stack for operands.
            Stack<String> operands = new Stack<String>();

            for (int i = 0; i < infix.Length; i++)
            {

                // If current character is an opening bracket, then push into the operators stack.
                if (infix[i] == '(')
                {
                    operators.Push(infix[i]);
                }

                // If current character is a closing bracket, then pop from both stacks and push result
                // in operands stack until  matching opening bracket is not found.
                else if (infix[i] == ')')
                {
                    while (operators.Count != 0 &&
                        operators.Peek() != '(')
                    {

                        // operand 1
                        String op1 = operands.Peek();
                        operands.Pop();

                        // operand 2
                        String op2 = operands.Peek();
                        operands.Pop();

                        // operator
                        char op = operators.Peek();
                        operators.Pop();

                        // Add operands and operator in form operator + operand1 + operand2.
                        String tmp = op + op2 + op1;
                        operands.Push(tmp);
                    }

                    // Pop opening bracket from stack.
                    operators.Pop();
                }

                // If current character is an  operand then push it into operands stack.
                else if (!isOperator(infix[i]))
                {
                    operands.Push(infix[i] + "");
                }

                // If current character is an operator, then push it into  operators stack after popping
                // high priority operators from operators stack and pushing result in operands stack.
                else
                {
                    while (operators.Count != 0 &&
                        getPriority(infix[i]) <=
                            getPriority(operators.Peek()))
                    {

                        String op1 = operands.Peek();
                        operands.Pop();

                        String op2 = operands.Peek();
                        operands.Pop();

                        char op = operators.Peek();
                        operators.Pop();

                        String tmp = op + op2 + op1;
                        operands.Push(tmp);
                    }

                    operators.Push(infix[i]);
                }
            }

            // Pop operators from operators stack until it is empty and  operation in add result of
            // each pop operands stack.
            while (operators.Count != 0)
            {
                String op1 = operands.Peek();
                operands.Pop();

                String op2 = operands.Peek();
                operands.Pop();

                char op = operators.Peek();
                operators.Pop();

                String tmp = op + op2 + op1;
                operands.Push(tmp);
            }

            // Final prefix expression is present in operands stack.
            return operands.Peek();
        }

        //function to check if textbox input is empty, otherwise execute the function infixtoPrefix to convert the
        //infix expression into prefix
        private void CheckInput(string input)
        {
            // string input = toPrefixInput.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter an Infix expression.");
            }
            else
            {
                toPrefixResult.Text = infixToPrefix(input);
            }
        }

        //function for button to convert the infix expression by calling CheckInput
        private void ConverttoPrefixBTN_Click(object sender, EventArgs e)
        {
            CheckInput(toPrefixInput.Text);
        }

        //function to prevent user from inputting consecutive characters in the textbox such as AA, 11, ++
        //only single characters are allowed
        private void toPrefixInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetterOrDigit(keyPressed) || "+-*/^()".Contains(keyPressed) || keyPressed == '\b')
            {
                if (keyPressed != '\b' && toPrefixInput.Text.Length > 0)
                {
                    char lastChar = toPrefixInput.Text[toPrefixInput.Text.Length - 1];
                    if (Char.IsLetterOrDigit(keyPressed) && Char.IsLetterOrDigit(lastChar))
                    {
                        e.Handled = true;
                    }
                    else if ("+-*/^".Contains(keyPressed) && "+-*/^".Contains(lastChar))
                    {
                        e.Handled = true;
                    }
                    else if (keyPressed == ')' && toPrefixInput.Text.Count(c => c == '(') <= toPrefixInput.Text.Count(c => c == ')'))
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

        //function to close form
        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
