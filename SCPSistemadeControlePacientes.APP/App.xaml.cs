using System;
using MeuAppPacientes.Services;
using MeuAppPacientes.Models;
using SCPSistemaDeControlePacientes.APP.Views;



namespace SCPSistemaDeControlePacientes.APP
{
    public partial class App : Application
    {
        // Defina a propriedade Database como estática
        public static DatabaseService Database { get; private set; } 

        public App()
        {
            InitializeComponent();

            // Configura o caminho do banco de dados
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "pacientes.db3");
            Database = new DatabaseService(dbPath); // Inicialize o Database

            MainPage = new Views.MainPage(); // Certifique-se de que está referenciando a página correta
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}