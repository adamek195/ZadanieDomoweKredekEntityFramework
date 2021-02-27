using AdamBednorzZadanieDomowe4.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe4.Forms
{
    public partial class FormCanteen : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą dań
        /// </summary>
        private readonly DishesRepository dishesRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Purchases
        /// </summary>
        private readonly OrdersRepository ordersRepository;
        public FormCanteen()
        {
            //Zainicjalizowanie repozytorium
            dishesRepository = new DishesRepository();
            ordersRepository = new OrdersRepository();

            InitializeComponent();

            // Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormCanteen_Load(object sender, EventArgs e)
        {
            //podczas zaladowania ustaw tła komponentów
            labelMenu.BackColor = Color.Red;
            buttonMenu.BackColor = Color.Red;
            labelDish.BackColor = Color.Red;
            labelFirstName.BackColor = Color.Red;
            labelLastName.BackColor = Color.Red;
            labelOrder.BackColor = Color.Red;
            labelPassword.BackColor = Color.Red;
            buttonOrder.BackColor = Color.Red;

            //odswizaj tablice z zamówieniami
            dataGridViewOrders.DataSource = ordersRepository.GetOrderViewModels();
        }

        /// <summary>
        /// metoda pozwalajaca wyswietlic zamowienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //pobierz wszystkie dania z bazy danych
            dataGridViewDishes.DataSource = dishesRepository.GetDishViewModels();
        }

        /// <summary>
        /// metoda ktora po nacisnieciu pozwala dodac zamowienie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string dishName = textBoxDish.Text;

            if(ordersRepository.AddOrder(firstName, lastName, password, dishName))
            {
                MessageBox.Show("Zamówiłeś danie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie ma takiego dania lub nie masz konta!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //przypisz wszystkie umowione zmówienia do DataGridView
            dataGridViewOrders.DataSource = ordersRepository.GetOrderViewModels();

            //czyszczenie 
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxDish.Text = "";
        }
    }
}
