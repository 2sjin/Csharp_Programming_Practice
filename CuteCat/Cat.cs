using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat {
    public class Cat {
        private string name;
        private int age;
        private int happiness = 50;

        public Cat(String name, int age) {
            this.name = name;
            this.age = age;
        }

        public void Play() {
            happiness += 10;
            if (happiness > 100)
                happiness = 100;
        }

        public void Eat() {
            happiness += 20;
            if (happiness > 100)
                happiness = 100;
        }

        public string Express() {
            string message = "";
            
            if (happiness >= 80)
                message = "I'm very happy.";
            else if (happiness >= 60)
                message = "I'm happy.";
            else if (happiness >= 40)
                message = "I'm so so.";
            else if (happiness >= 20)
                message = "I'm glommy.";
            else
                message = "I'm sad.";

            return this.name + ": " + message;
        }

        public void GetBored() {
            happiness -= 1;
            if (happiness < 0)
                happiness = 0;
        }

        public int getHappiness() {
            return happiness;
        }

    }
}
