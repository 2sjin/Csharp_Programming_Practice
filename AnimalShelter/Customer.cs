using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter {
    public class Customer {

        // =============================================================

        // 멤버: 필드
        public string firstName;
        public string lastName;
        private DateTime _birthday;
        private bool _isQualified;
        public string address;
        public string description;
        private List<Pet> _MyPets = new List<Pet>();

        // =============================================================

        // 생성자
        public Customer(string firstName, string lastName, DateTime birthday) {
            this.firstName = firstName;
            this.lastName = lastName;
            this._birthday = birthday;
            this._isQualified = (DateTime.Now.Year - _birthday.Year >= 18);
        }

        // =============================================================

        // 멤버: 속성
        public string FullName {
            get { return firstName + " " + lastName; }
        }

        public DateTime Birthday {
            get { return _birthday; }
            set {
                this._birthday = value;
                this._isQualified = (DateTime.Now.Year - _birthday.Year >= 18);
            }
        }

        public int Age {
            get { return DateTime.Now.Year - _birthday.Year; }
        }


        public string IsQualified {
            get {
                if (_isQualified)
                    return "분양 가능";
                else
                    return "분양 불가능";
            }
        }

        public List<Pet> MyPets {
            get { return _MyPets; }
        }

        // =============================================================

        // 멤버: 메소드
        public bool Adopt(Pet pet) {
            if (_isQualified) {
                _MyPets.Add(pet);
                return true;
            }
            else {
                return false;
            }
        }

        // =============================================================

    }
}
