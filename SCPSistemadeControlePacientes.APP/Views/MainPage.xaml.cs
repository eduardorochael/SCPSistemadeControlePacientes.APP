using MeuAppPacientes.Models;
using MeuAppPacientes.Services;
using Microsoft.Maui.Controls;
using SCPSistemadeControlePacientes.APP;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls;

namespace SCPSistemaDeControlePacientes.APP.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Certifique-se de que este método está sendo chamado
            CarregarPacientes();
        }

        private void CarregarPacientes()
        {
            // Atualiza a lista de pacientes
            PacientesListView.ItemsSource = App.Database.ObterPacientes();
        }

        private void OnCadastrarClicked(object sender, System.EventArgs e)
        {
            // Cria um novo paciente com os dados dos campos de entrada
            var paciente = new Paciente
            {
                Nome = NomeEntry.Text,
                Idade = int.Parse(IdadeEntry.Text),
                Telefone = TelefoneEntry.Text,
                Endereco = EnderecoEntry.Text
            };

            // Insere o paciente no banco de dados
            App.Database.InserirPaciente(paciente);

            // Atualiza a lista de pacientes
            CarregarPacientes();

            // Limpa os campos de entrada
            NomeEntry.Text = string.Empty;
            IdadeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            EnderecoEntry.Text = string.Empty;
        }
    }
}