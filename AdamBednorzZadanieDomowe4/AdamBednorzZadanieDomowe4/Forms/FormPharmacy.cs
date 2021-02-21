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
    public partial class FormPharmacy : Form
    {
        // <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Medicines
        /// </summary>
        private readonly MedicinesRepository medicinesRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Purchases
        /// </summary>
        private readonly PurchasesRepository purchasesRepository;
        public FormPharmacy()
        {
            ////Zainicjalizowanie repozytorium
            medicinesRepository = new MedicinesRepository();
            purchasesRepository = new PurchasesRepository();

            InitializeComponent();

            //Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormPharmacy_Load(object sender, EventArgs e)
        {
            //ustaw tła komponentów podczas ladowania
            labelPharmacy.BackColor = Color.DarkGreen;
            buttonPharmacy.BackColor = Color.DarkGreen;
            labelFirstName.BackColor = Color.DarkGreen;
            labelLastName.BackColor = Color.DarkGreen;
            labelMedicine.BackColor = Color.DarkGreen;
            labelPurchase.BackColor = Color.DarkGreen;
            labelPassword.BackColor = Color.DarkGreen;
            buttonPurchase.BackColor = Color.DarkGreen;


            //laduj tabele z zamówieniami lekarstw
            dataGridViewPurchases.DataSource = purchasesRepository.GetPurchaseViewModels();
        }

        /// <summary>
        /// metoda która po kliknięciu pozwala zobaczyć lekarstwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            //pobierz wszystkie lekarstwa z bazy danych
            dataGridViewPharmacies.DataSource = medicinesRepository.GetMedicineViewModels();
        }
        /// <summary>
        /// metoda pozwalajaca zamówic lekarstwo przez pacjenta po kliknieciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string medicineName = textBoxMedicine.Text;

            if (purchasesRepository.AddPurchase(firstName, lastName, password, medicineName))
            {
                MessageBox.Show("Zamówiłeś lekarstwo!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie ma takiego lekarstwa lub nie masz konta!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //przypisz wszystkie umowione zmówienia do DataGridView
            dataGridViewPurchases.DataSource = purchasesRepository.GetPurchaseViewModels();

            //czyszczenie 
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxMedicine.Text = "";
        }
    }
}
