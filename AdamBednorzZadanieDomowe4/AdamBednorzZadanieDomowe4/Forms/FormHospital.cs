using System;
using System.Drawing;
using System.Windows.Forms;
using AdamBednorzZadanieDomowe4.Forms;
using AdamBednorzZadanieDomowe4.Repositories;

namespace AdamBednorzZadanieDomowe4
{
    public partial class FormHospital : Form
    {
        // <summary>
        /// Klasa do przetwarzania danych związanych z tabelą InformationHospital
        /// </summary>
        private readonly InformationHospitalRepository informationHospitalRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Patients
        /// </summary>
        private readonly PatientsRepository patientsRepository;

        public FormHospital()
        {
            //Zainicjalizowanie repozytorium
            informationHospitalRepository = new InformationHospitalRepository();
            patientsRepository = new PatientsRepository();

            InitializeComponent();

            //Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            //dodawanie tła komponentów podczas ładowania
            labelReception.BackColor = Color.Red;
            labelFirstName.BackColor = Color.Aqua;
            labelLastName.BackColor = Color.Aqua;
            labelPassword.BackColor = Color.Aqua;
            labelNewPassword.BackColor = Color.Aqua;
            labelPhoneNumber.BackColor = Color.Aqua;
            labelHospitalName.BackColor = Color.Aqua;
            labelStreet.BackColor = Color.Aqua;
            buttonSignIn.BackColor = Color.Aqua;
            buttonAddPatient.BackColor = Color.Aqua;
            buttonDeletePatient.BackColor = Color.Aqua;
            buttonChangePassword.BackColor = Color.Aqua;
            buttonCanteen.BackColor = Color.Red;
            buttonPharmacy.BackColor = Color.DarkGreen;

            //zaladowanie informacji o szpitalu
            textBoxStreet.Text = informationHospitalRepository.GetStreetById(1);
            textBoxHospitalName.Text = informationHospitalRepository.GetHospitalNameById(1);
            textBoxPhoneNumber.Text = informationHospitalRepository.GetPhoneNumberById(1).ToString();
        }

        /// <summary>
        /// metoda pozwalajaca sie zalogowac po kliknieciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //zczytujemy dane z textBoxow
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;

            //zmienna sprawdzajaca czy istnieje taki pacjent w bazie
            bool logged = patientsRepository.SignIn(firstName, lastName, password);

            //jezeli udało się zalogować
            if (logged)
            {
                MessageBox.Show("Udalo Ci sie zalogowac");
                //tworzymy okno
                FormSurgery formSurgery = new FormSurgery();
                //pokazujemy okno
                formSurgery.Show();
                //czyscimy dane
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                //Czyscimy dane
                MessageBox.Show("Niepoprawny login lub hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }
        }
        /// <summary>
        /// metoda pozwalajaca dodac nowe konto do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            //wczytujemy dane
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;

            //dodajemy pacjentów do bazy
            if(patientsRepository.Register(firstName, lastName, password))
            {
                MessageBox.Show("Stowrzyłeś nowe konto w systemie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Takie konto już istnieje, nie udało się utworzyć konta!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //czyścimy dane
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// metoda pozwalajaca usunac konto pacjenta z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            //wczytujemy dane z textboxow
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            //usuwamy pacjentów z bazy
            if (patientsRepository.DeletePatient(firstName, lastName, password))
            {
                MessageBox.Show("Usunąłeś konto!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Takie konto nie istnieje, nie udało się usunąć konta!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //czyścimy dane
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// metoda pozwalajaca zmienic hasło pacjenta w systemie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string newPassword = textBoxNewPassword.Text;

            if(patientsRepository.ChangePassword(firstName, lastName, password, newPassword))
            {
                MessageBox.Show("Zmieniłeś hasło!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Nie ma takiego użytkownika w bazie!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //czyscimy dane
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxNewPassword.Text = "";
        }

        /// <summary>
        /// przycisk przekierowujacy nas do kantyny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCanteen_Click(object sender, EventArgs e)
        {
            //tworzymy okno
            FormCanteen formCanteen = new FormCanteen();
            //pokazujemy okno
            formCanteen.Show();
        }

        /// <summary>
        /// przyciks przekierewujacy nas do apteki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            //tworzymy okno
            FormPharmacy formPharmacy = new FormPharmacy();
            //pokazujemy okno
            formPharmacy.Show();
        }
    }
}
