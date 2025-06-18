using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    class ArabicPerson
    {
        string? Affiliation;
        string? ContactNumber;
        string? FavoriteWeapon;
        string? FirstName;
        string? LastName;
        int Id;
        bool IsExposed;
        string? Location;
        string? SecretPhrase;


        public static ArabicPerson FormaterPerson(MySqlDataReader reader)
        {
            ArabicPerson ArabicPerson = new();
            if (reader.Read())
            {
                ArabicPerson = new ArabicPerson
                {
                    Id = reader.GetInt32("id"),
                    Affiliation = reader.GetString("affiliation"),
                    FirstName = reader.GetString("first_name"),
                    LastName = reader.GetString("last_name"),
                    FavoriteWeapon = reader.GetString("favorite_weapon"),
                    ContactNumber = reader.GetString("contact_number"),
                    Location = reader.GetString("location"),
                    SecretPhrase = reader.GetString("secret_phrase"),
                    IsExposed = reader.GetBoolean("is_exposed")
                };
            }
            return ArabicPerson;
        }
    }
}
