using AdamBednorzZadanieDomowe4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe4.Forms
{
    public partial class FormSurgery : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Doctors
        /// </summary>
        private readonly DoctorsRepository doctorsRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Visits
        /// </summary>
        private readonly VisitsRepository visitsRepository;


        public FormSurgery()
        {
            //Zainicjalizowanie repozytorium
            doctorsRepository = new DoctorsRepository();
            visitsRepository = new VisitsRepository();

            InitializeComponent();

            // Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSurgery_Load(object sender, EventArgs e)
        {
            //podczas ładowania ustawienie tła komponentów
            labelDoctors.BackColor = Color.Aqua;
            buttonDoctors.BackColor = Color.Aqua;
            labelFirstName.BackColor = Color.Aqua;
            labelLastName.BackColor = Color.Aqua;
            labelPassword.BackColor = Color.Aqua;
            labelTypeDoctor.BackColor = Color.Aqua;
            labelVisits.BackColor = Color.Aqua;
            buttonVisits.BackColor = Color.Aqua;

            //pokaz umowione juz wizyty
            dataGridViewVisits.DataSource = visitsRepository.GetVisitViewModels();
        }

        /// <summary>
        /// metoda ktora pozwala pokazac tabele z lekarzami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            //pobierz wszystkich lekarzy z bazy danych
            dataGridViewDoctors.DataSource = doctorsRepository.GetDoctorViewModels();
        }

        /// <summary>
        /// metoda pozwalajaca sie umowic na wizyte lekarska gdzie zostanie dodany rekord do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVisits_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string typeDoctor = textBoxTypeDoctor.Text;

            if(visitsRepository.AddVisit(firstName, lastName, password, typeDoctor))
            {
                MessageBox.Show("Umówiłeś się na wizytę!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie masz konta lub nie ma takiego lekarza!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //przypisz wszystkie umowione wizyty do DataGridView
            dataGridViewVisits.DataSource = visitsRepository.GetVisitViewModels();

            //czyszczenie
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxTypeDoctor.Text = "";
        }
    }
}
