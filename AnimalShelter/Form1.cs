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

            CustomerList.Rows.Add(cus.firstName, cus.Age, cus.IsQualified);
            customers.Add(cus);

            CustomNewFirstName.Text = "";
            CustomNewLastName.Text = "";
            CustomNewBirthday.Text = "";
            CustomNewAddress.Text = "";
            CustomNewDescription.Text = "";
        }

        public void showDetails(Customer cus) {
            NameLabel.Text = cus.FullName;
            BirthdayLabel.Text = cus.Age.ToString();
            AddressLabel.Text = cus.address;
            DescriptionLabel.Text = cus.description;
            IsQualifiedLabel.Text = cus.IsQualified;
        }

        private void CustomerList_CellClick(object sender, DataGridViewCellEventArgs e) {
            string selectedFirstName = (string) CustomerList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in customers) {
                if (cus.firstName == selectedFirstName) {
                    showDetails(cus);
                    break;
                }
            }
            CustomerDetailPanel.Show();
            CustomerNewPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CustomerListPanel.Dock = DockStyle.Fill;
            CustomerDetailPanel.Dock = DockStyle.Right;
            CustomerNewPanel.Dock = DockStyle.Right;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            CustomerNewPanel.Show();
            CustomerDetailPanel.Hide();
        }
    }
}