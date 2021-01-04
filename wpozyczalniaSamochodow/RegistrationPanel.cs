﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalniaSamochodow
{
    public partial class RegistrationPanel : UserControl
    {
        public App parent;

        public RegistrationPanel()
        {
            InitializeComponent();
            Hide();
        }

        public void setParent(App parent)
        {
            this.parent = parent;
        }


        public bool checkCorrectness(string firstName, string lastName, string city, string address, string houseNumber, string apartmentNumber, string email, string password, string password2)
        {
            //var firstName = firstNameTextBox.Text;
            //var lastName = lastNameTextBox.Text;
            //var city = cityTextBox.Text;
            //var address = adressTextBox.Text;
            //var houseNoumber = Convert.ToInt32(houseNumberTextBox.Text);
            //var apartmentNumber = Convert.ToInt32(apartmentNumberTextBox.Text);
            //var email = emailTextBox.Text;
            //var password = passwordTextBox.Text;
            //var password2 = passwordTextBox2.Text;

            if (firstName == "")
            {
                firstNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wprowadzonego imienia");
                return false;
            }
            if (lastName == "")
            {
                lastNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wprowadzonego nazwiska");
                return false;
            }
            if (city == "")
            {
                cityTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wprowadzoengo miasta");
                return false;
            }
            if (address == "")
            {
                addressTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wproawdzonej ulicy");
                return false;
            }
            if (houseNumber == "")
            {
                houseNumberTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wprowadzoengo numeru mieszkania");
                return false;
            }
            
            if (email == "")
            {
                emailTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak wprowadzonego adresu email");
                return false;
            }
            if (password == "")
            {
                passwordTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak hasla");
                return false;
            }

            if (firstName.Any(char.IsDigit))
            {
                firstNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Imie nie moze zawierac cyfr");
                return false;
            }

            if (lastName.Any(char.IsDigit))
            {
                lastNameTextBox.BackColor = Color.Red;
                MessageBox.Show("Nazwisko nie moze zawierac cyfr");
                return false;
            }

            if (city.Any(char.IsDigit))
            {
                cityTextBox.BackColor = Color.Red;
                MessageBox.Show("Nazwa miasta nie moze zawierac cyfr");
                return false;
            }

            if (address.Any(char.IsDigit))
            {
                addressTextBox.BackColor = Color.Red;
                MessageBox.Show("Nazwa ulicy nie moze zawierac cyfr");
                return false;
            }

            if (!houseNumber.All(char.IsDigit))
            {
                houseNumberTextBox.BackColor = Color.Red;
                MessageBox.Show("Numer domu musi skladac sie z samych cyfr");
                return false;
            }

            if(apartmentNumber != "")
            {
                if (!apartmentNumber.All(char.IsDigit))
                {
                    apartmentNumberTextBox.BackColor = Color.Red;
                    MessageBox.Show("Numer mieszkania nie może zawierac liter");
                    return false;
                }
            }

            if (password != password2)
            {
                MessageBox.Show("Rozne hasla");
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox2.BackColor = Color.Red;
                return false;
            }

            if(password.Length < 6)
            {
                MessageBox.Show("Haslo zbyt krotkie");
                passwordTextBox.BackColor = Color.Red;
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Niepoprawny adres email");
                emailTextBox.BackColor = Color.Red;
                return false;
            }

            if(!email.Contains("."))
            {
                MessageBox.Show("Niepoprawny adres email");
                emailTextBox.BackColor = Color.Red;
                return false;
            }

            

            return true;

            // TODO: Skonczyc sprawdzanie bledow
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var city = cityTextBox.Text;
            var address = addressTextBox.Text;
            var houseNoumber = houseNumberTextBox.Text;
            var apartmentNumber = apartmentNumberTextBox.Text;
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var password2 = passwordTextBox2.Text;

            if (checkCorrectness(firstName, lastName, city, address, houseNoumber, apartmentNumber,email, password,password2))
            {
                //TODO: Podłączenie do bazy danych


                MessageBox.Show("Rejestracja przebiegła pomyślnie");
                Hide();
            }

            
            //else
            //{
            //    MessageBox.Show("Niepoprawne dane");
            //}
        }

        //Metoda wizualna
        private void emailTextBox_Click(object sender, EventArgs e)
        {
            emailTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White;
            passwordTextBox2.BackColor = Color.White;
        }

        //Metoda wizualna
        private void passwordTextBox2_Click(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White;
            passwordTextBox2.BackColor = Color.White;
        }

        //Metoda wizualna
        private void firstNameTextBox_Click(object sender, EventArgs e)
        {
            firstNameTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void lastNameTextBox_Click(object sender, EventArgs e)
        {
            lastNameTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void cityTextBox_Click(object sender, EventArgs e)
        {
            cityTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void addressTextBox_Click(object sender, EventArgs e)
        {
            addressTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void houseNumberTextBox_Click(object sender, EventArgs e)
        {
            houseNumberTextBox.BackColor = Color.White;
        }

        //Metoda wizualna
        private void apartmentNumberTextBox_Click(object sender, EventArgs e)
        {
            apartmentNumberTextBox.BackColor = Color.White;
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
