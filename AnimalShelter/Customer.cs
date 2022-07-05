using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter {
    internal class Customer {
        public string firstName;
        public string lastName;
        private DateTime _birthday;
        private bool _isQualified;
        public string address;
        public string description;

        public Customer(string firstName, string lastName, DateTime birthday) {
            this.firstName = firstName;
            this.lastName = lastName;
            this._birthday = birthday;

            this._isQualified = (DateTime.Now.Year - _birthday.Year >= 18);
        }

        public DateTime Birthday {
            get { return _birthday; }
            set {
                this._birthday = value;
                this._isQualified = (DateTime.Now.Year - _birthday.Year >= 18);
            }
        }

        public bool IsQualified {
            get { return _isQualified; }
        }

        public string FullName {
            get { return firstName + " " + lastName; }
        }
    }
}
