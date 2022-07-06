namespace AnimalShelter {
    public partial class Form1 : Form {

        public Customer[] customerArray = new Customer[10];
        public int customerArrayIndex = 0;

        public Form1() {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e) {
            customerArray[customerArrayIndex] = new Customer(CustomNewFirstName.Text, CustomNewLastName.Text,
                DateTime.Parse(CustomNewBirthday.Text));
            customerArray[customerArrayIndex].address = CustomNewAddress.Text;
            customerArray[customerArrayIndex].description = CustomNewDescription.Text;

            CustomerList.Items.Add(customerArray[customerArrayIndex].firstName);

            customerArrayIndex++;
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

            for (int i=0; i<customerArrayIndex; i++) {
                if (customerArray[i].firstName == selectedFirstName) {
                    showDetails(customerArray[i]);
                    break;
                }
            }
        }

    }
}