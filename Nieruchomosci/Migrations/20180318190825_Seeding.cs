using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Nieruchomosci.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Andrzej','Nowak','123 123 123')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Jan','Kowalski','321 321 321')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Stanisław','Woźniak','231 231 231')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Grunwaldzka','Gdansk')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Przemyska','Gdansk')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Marynarki Polskiej','Gdansk')");

            migrationBuilder.Sql("INSERT INTO Properties (Type, Description,Rooms,Area,Washer,Refrigerator,Iron, AddressId, OwnerId) VALUES (0,'JakisOpis',3,70,1,1,0,1,1)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description,Rooms,Area,Washer,Refrigerator,Iron, AddressId, OwnerId) VALUES (0,'OpisJakis',4,110,1,1,0,2,2)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description,Rooms,Area,Washer,Refrigerator,Iron, AddressId, OwnerId) VALUES (0,'JakisOpis',6,180,1,1,0,3,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
