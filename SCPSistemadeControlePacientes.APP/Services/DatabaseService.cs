using SQLite;
using MeuAppPacientes.Models;
using System.Collections.Generic;

namespace MeuAppPacientes.Services
{
    public class DatabaseService
    {
        private SQLiteConnection _connection;

        public DatabaseService(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<Paciente>(); // Cria a tabela se não existir
        }

        public void InserirPaciente(Paciente paciente)
        {
            _connection.Insert(paciente);
        }

        public List<Paciente> ObterPacientes()
        {
            return _connection.Table<Paciente>().ToList();
        }
    }
}