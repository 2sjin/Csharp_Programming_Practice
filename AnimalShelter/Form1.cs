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

            PetInfoLabel.Text = "";
            foreach (Pet pet in cus.MyPets) {
                PetInfoLabel.Text += pet.name + " (";
                PetInfoLabel.Text += pet.MakeSound() + ", ";
                if (pet is Cat)
                    PetInfoLabel.Text += (pet as Cat).Scratch() + ", ";
                else if (pet is Dog) {
                    PetInfoLabel.Text += (pet as Dog).Bite() + ", ";
                    PetInfoLabel.Text += (pet as Dog).breed + ", ";
                }

                PetInfoLabel.Text += pet.gender + ", " + pet.color + ")";

                PetInfoLabel.Text += Environment.NewLine;
            }
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

            // 초기 회원 및 반려동물 정보
            Customer cus = new Customer("Richet", "Barton", new DateTime(2000, 1, 1));
            Pet cat = new Cat(1, "Lucas", "White", "male");
            cus.Adopt(cat);
            Pet cat2 = new Cat(1, "Ruby", "Brown", "Female");
            cus.Adopt(cat2);

            Pet dog = new Dog(2, "Happy", "Black", "Male", DogBreed.Jindo);
            cus.Adopt(dog);

            customers.Add(cus);
            CustomerList.Rows.Add(cus.firstName, cus.Age, cus.IsQualified);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            CustomerNewPanel.Show();
            CustomerDetailPanel.Hide();
        }
    }
}