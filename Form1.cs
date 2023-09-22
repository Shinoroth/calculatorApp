using System.Data;
using System.Text;

namespace calculatorApp {
    public partial class Form1 : Form {
        private StringBuilder expression = new StringBuilder();
        private double result = 0;

        public Form1() {
            InitializeComponent();
            wireUpEventHandlers();
        }

        private void wireUpEventHandlers() {
            digitButton_0.Click += button_Click;
            digitButton_1.Click += button_Click;
            digitButton_2.Click += button_Click;
            digitButton_3.Click += button_Click;
            digitButton_4.Click += button_Click;
            digitButton_5.Click += button_Click;
            digitButton_6.Click += button_Click;
            digitButton_7.Click += button_Click;
            digitButton_8.Click += button_Click;
            digitButton_9.Click += button_Click;

            operationButton_add.Click += button_Click;
            operationButton_substract.Click += button_Click;
            operationButton_multiply.Click += button_Click;
            operationButton_divide.Click += button_Click;

            openingBracketButton.Click += button_Click;
            closingBracketButton.Click += button_Click;
            separatorButton.Click += button_Click;

            clearButton.Click += clearButton_Click;
            showResultButton.Click += showResultButton_Click;
            backspaceButton.Click += backspaceButton_Click;
        }

        private void button_Click(object? sender, EventArgs e) {
            if (sender is Button button) {
                string buttonText = button.Text;
                if (buttonText == "." && !expression.ToString().Contains("+-*/.")) {
                    expression.Append(buttonText);
                }
                else if (string.IsNullOrEmpty(expression.ToString()) && "+-*/.".Contains(buttonText)) {
                    expression.Append(result);
                    expression.Append(buttonText);
                }
                else if (buttonText != ".") {
                    expression.Append(buttonText);
                }
                resultTextBox.Text = expression.ToString();
            }
        }

        private void clearButton_Click(object? sender, EventArgs e) {
            expression.Clear();
            resultTextBox.Clear();
        }

        private double calculate(string expression) {
            try {
                if (expression.Contains("/0")) {
                    throw new DivideByZeroException("Nuh-uh. Are you trying to create a black hole?");
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("expression", typeof(string), expression);
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);

                return double.Parse((string)row["expression"]);
            }
            catch (DivideByZeroException ex) {
                MessageBox.Show(ex.Message, "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expression = "";
                return double.NaN;
            }
            catch (Exception) {
                return double.NaN;
            }
        }

        private void showResultButton_Click(object? sender, EventArgs e) {
            result = calculate(expression.ToString());
            resultTextBox.Text = result.ToString();
            expression.Clear();
        }

        private void backspaceButton_Click(object? sender, EventArgs e) {
            if (expression.Length > 0) {
                expression.Length--;
                resultTextBox.Text = expression.ToString();
            }
        }
    }
}
