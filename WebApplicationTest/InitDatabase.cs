using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Microsoft.VisualBasic;

namespace WebApplicationTest
{
    public class InitDatabase
    {
       protected internal static void Init()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=DatabaseTTT.dat");
            con.Open();
            
            SQLiteCommand command = new SQLiteCommand(con);
           
           // command.CommandText = $"create table User (ID integer not null primary key autoincrement," +
                                   //           "Name varchar(100)not null)";
            command.ExecuteNonQuery();
            con.Close();
        }

       protected internal static void Insert()
       {
           SQLiteConnection con = new SQLiteConnection("Data Source=DatabaseTTT.dat");
           con.Open();
            
           SQLiteCommand command = new SQLiteCommand(con);
           //command.CommandText = $"insert into User (loginName,salt,hash,inGameName,email,color)values('MaxMuster','1','2','Gamer','Hallo@gmx.de','Black')";
         
           command.CommandText = $"insert into Replay (date,statusWinLos,lobbyOptions,moves)values('{new DateTime(2020,12,21)}','Win','Winning','one two')";

           command.ExecuteNonQuery();
            
            
         
           con.Close();

       }
        
    }
    
}