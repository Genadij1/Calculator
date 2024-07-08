using System.Globalization;

namespace Calculator 
{

    public partial class MainPage : ContentPage
    {

        private string currentNumber = string.Empty;
        private string operation = string.Empty;
        private double result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string number = ((Button)sender).Text;
            currentNumber += number;
            ENTRY.Text += ((Button)sender).Text;
            RES.Text = currentNumber;
        }
        private void Operator_Clicked(System.Object sender, System.EventArgs e)
        {
            operation = ((Button)sender).Text;
            result = double.Parse(currentNumber);
            currentNumber = string.Empty;
        }
        private void Result_Clicked(System.Object sender, System.EventArgs e)
        {
            double secondNumber = double.Parse(currentNumber);
            switch (operation)
            {
                case "+":
                    result += secondNumber;
                    break;
                case "-":
                    result -= secondNumber;
                    break;
                case "*":
                    result *= secondNumber;
                    break;
                case "/":
                    result /= secondNumber;
                    break;
            }
            RES.Text = result.ToString();
            currentNumber = string.Empty;
            operation = string.Empty;
        }
        private void ClearAll_Clicked(System.Object sender, System.EventArgs e)
        {
            currentNumber = string.Empty;
            operation = string.Empty;
            RES.Text = "0";
        }
        private void Clear_Clicked(System.Object sender, System.EventArgs e)
        {

        }
    }
}
