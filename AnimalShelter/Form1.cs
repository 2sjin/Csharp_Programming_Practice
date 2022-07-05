namespace AnimalShelter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e) {
            Customer cus = new Customer("Richet", "Barton", new DateTime(2000, 1, 1));
            cus.address = "123 Wilshire Blvd.";

            NameLabel.Text = cus.FullName;
            BirthdayLabel.Text = cus.Birthday.Date.ToString("yyyy-mm-dd");
            AddressLabel.Text = cus.address;
            DescriptionLabel.Text = cus.description;
            IsQualifiedLabel.Text = cus.IsQualified.ToString();
        }
    }
}