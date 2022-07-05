namespace CuteCat {
    public partial class Form1 : Form {
        private Cat MyCat = new Cat("Lucas", 1);

        public Form1() {
            InitializeComponent();
            updateDisplay();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            MyCat.Play();
            updateDisplay();
        }

        private void FeedButton_Click(object sender, EventArgs e) {
            MyCat.Eat();
            updateDisplay();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            MyCat.GetBored();
            updateDisplay();
        }

        private void updateDisplay() {
            CatScreen.Text = MyCat.Express();
            HappinessBar.Value = MyCat.getHappiness();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}