using MySqlConnector;
using System;

Console.WriteLine("Hello, World!");
string Databasename = "company";
string Username = "schoolofzo";
string Password = "kali123";
string Server = "192.168.30.128";
string Port = "3306";
string ConnectionString = $"Server={Server};Port={Port};Database={Databasename};Uid={Username};Pwd={Password};";
MySqlConnection conn = new MySqlConnection(ConnectionString);
conn.Open();
string sql = "SELECT name, description FROM department;";
using (MySqlCommand cmd = new MySqlCommand(sql, conn))
{
    MySqlDataReader reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        string name = reader.GetString("name");
        string description = reader.GetString("description");
        Console.WriteLine("{0} = {1}", name, description);
    }
    reader.Close();
}

conn.Close();
