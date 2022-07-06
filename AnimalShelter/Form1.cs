namespace AnimalShelter {
    public partial class Form1 : Form {

        public List<Customer> customers = new List<Customer>();

        public Form1() {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e) {
            Customer cus = new Customer(CustomNewFirstName.Text, CustomNewLastName.Text,
                DateTime.Parse(CustomNewBirthday.Text));
            cus.address = CustomNewAddress.Text;
            cus.description = CustomNewDescription.Text;

            CustomerList.Items.Add(cus.firstName);
            customers.Add(cus);
        }

        public void showDetails(Customer cus) {
            NameLabel.Text = cus.FullName;
            BirthdayLabel.Text = cus.Age.ToString();
            AddressLabel.Text = cus.address;
            DescriptionLabel.Text = cus.description;
            IsQualifiedLabel.Text = cus.IsQualified;
        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedFirstName = CustomerList.SelectedItem.ToString();

            foreach (Customer cus in customers) {
                if (cus.firstName == selectedFirstName) {
                    showDetails(cus);
                    break;
                }
            }

        }

    }
}