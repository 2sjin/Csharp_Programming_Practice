namespace HelloCSharpWin {

    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form {
        public int result = 0;
        public bool isNewNum = true;
        public Operators opt = Operators.Add;

        public Calculator() {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, EventArgs e) {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void OperatorButton_Click(object sender, EventArgs e) {

            if (isNewNum == false) {
                switch (opt) {
                    case Operators.Add:
                        result += int.Parse(NumScreen.Text);
                        break;
                    case Operators.Sub:
                        result -= int.Parse(NumScreen.Text);
                        break;
                    case Operators.Multi:
                        result *= int.Parse(NumScreen.Text);
                        break;
                    case Operators.Div:
                        result /= int.Parse(NumScreen.Text);
                        break;
                }
            }

            NumScreen.Text = result.ToString();
            isNewNum = true;

            Button optButton = (Button)sender;
            switch (optButton.Text) {
                case "+":
                    opt = Operators.Add;
                    break;
                case "-":
                    opt = Operators.Sub;
                    break;
                case "*":
                    opt = Operators.Multi;
                    break;
                case "/":
                    opt = Operators.Div;
                    break;
            }
        }

        private void SetNum(String num) {
            if (isNewNum) {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0") {
                NumScreen.Text = num;
            }
            else {
                NumScreen.Text += num;
            }
        }

        private void AllClearButton_Click(object sender, EventArgs e) {
            result = 0;
            isNewNum = true;
            opt = Operators.Add;
            NumScreen.Text = "0";
        }
    }
}