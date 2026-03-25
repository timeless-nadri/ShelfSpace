using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;

namespace ShelfSpace.Data
{
    public static class DatabaseHelper
    {
        // Name der SQLite-Datei
        private const string DatabaseFileName = "shelfspace.db";

        // Vollständiger Pfad zur Datenbankdatei im App-Ordner
        private static readonly string DatabasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DatabaseFileName);

        // Connection-String für SQLite
        private static readonly string ConnectionString = $"Data Source={DatabasePath}";

        /// <summary>
        /// Erstellt die Datenbankdatei und die benötigten Tabellen, falls sie noch nicht existieren.
        /// Diese Methode soll beim Start der App aufgerufen werden.
        /// </summary>
        public static void InitializeDatabase()
        {
            CreateDatabaseFileIfNeeded();
            CreateUsersTable();
            CreateBooksTable();
        }

        /// <summary>
        /// Gibt eine neue SQLite-Verbindung zurück.
        /// </summary>
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }

        /// <summary>
        /// Erstellt die SQLite-Datei, falls sie noch nicht vorhanden ist.
        /// Bei SQLite reicht es aus, später eine Verbindung auf die Datei zu öffnen.
        /// </summary>
        private static void CreateDatabaseFileIfNeeded()
        {
            if (!File.Exists(DatabasePath))
            {
                using SqliteConnection connection = GetConnection();
                connection.Open();
            }
        }

        /// <summary>
        /// Erstellt die Users-Tabelle, falls sie noch nicht existiert.
        /// </summary>
        private static void CreateUsersTable()
        {
            string commandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserName TEXT NOT NULL
                );
            ";

            using SqliteConnection connection = GetConnection();
            connection.Open();

            using SqliteCommand command = new SqliteCommand(commandText, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Erstellt die Books-Tabelle, falls sie noch nicht existiert.
        /// </summary>
        private static void CreateBooksTable()
        {
            string commandText = @"
                CREATE TABLE IF NOT EXISTS Books (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Author TEXT NOT NULL,
                    SeriesName TEXT,
                    SeriesNumber INTEGER,
                    PublishYear INTEGER
                );
            ";

            using SqliteConnection connection = GetConnection();
            connection.Open();

            using SqliteCommand command = new SqliteCommand(commandText, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Prüft, ob bereits ein Benutzer in der Users-Tabelle existiert.
        /// Wird beim Start der App verwendet, um zu entscheiden,
        /// ob die Namensabfrage angezeigt werden soll.
        /// </summary>
        public static bool UserExists()
        {
            using var connection = GetConnection();
            connection.Open();

            string commandText = "SELECT COUNT (*) FROM Users;";

            using var command = new SqliteCommand(commandText, connection);

            long count = (long)command.ExecuteScalar();

            return count > 0;
        }

        /// <summary>
        /// Erstellt einen neuen Benutzer in der Users-Tabelle.
        /// Wird beim ersten Start nach der Namenseingabe aufgerufen.
        /// </summary>
        public static void CreateUser(string userName)
        {
            using var connection = GetConnection();
            connection.Open();

            string commandText = "INSERT INTO Users (UserName) VALUES (@name);";

            using var command = new SqliteCommand(commandText, connection);

            command.Parameters.AddWithValue("@name", userName);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gibt den gespeicherten Benutzernamen zurück.
        /// Wird für die persönliche Begrüßung im Startfenster verwendet.
        /// </summary>
        public static string? GetUserName()
        {
            using var connection = GetConnection();
            connection.Open();

            string commandText = "SELECT UserName FROM Users LIMIT 1;";

            using var command = new SqliteCommand(commandText, connection);

            var result = command.ExecuteScalar();

            if (result == null)
                return null;

            return result.ToString();

        }
    }
}
