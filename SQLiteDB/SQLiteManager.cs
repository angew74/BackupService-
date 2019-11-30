using SQLiteDB.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDB
{
    public class SQLiteManager
    {

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public SQLiteManager()
        {
            string cs = ConfigurationManager.AppSettings["sqldb"];
            string connection =   @"URI=file:" +cs;
            sql_con = new SQLiteConnection(connection);
        }

        public List<FileStream> SelectAll()
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            string stm = "SELECT * FROM Files";
            List<FileStream> fileStreams = new List<FileStream>();
            sql_cmd = new SQLiteCommand(stm,sql_con);          
            sql_cmd.CommandText = stm;
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            while (rdr.Read())
            {
                FileStream f = ReadRecord(rdr);
                fileStreams.Add(f);
            }
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
            return fileStreams;
        }

        public void CreateTableFileForced()
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            sql_cmd = new SQLiteCommand(sql_con);
            sql_cmd.CommandText = "DROP TABLE IF EXISTS files";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = @"CREATE TABLE files(id INTEGER PRIMARY KEY,
                    name TEXT, path TEXT, flgcopy INT, dimension INT)";
            sql_cmd.ExecuteNonQuery();
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
        }
        
        public void CreateTable()
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            string cmd = " create table if not exists files(id INTEGER PRIMARY KEY, name TEXT, path TEXT, flgcopy INT, dimension INT)";
            sql_cmd = new SQLiteCommand(cmd, sql_con);
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = @" create table if not exists files(id INTEGER PRIMARY KEY,
                    name TEXT, path TEXT, flgcopy INT, dimension INT)";
            sql_cmd.ExecuteNonQuery();
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
        }

        public void SaveRecord(FileStream fileStream)
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            sql_cmd = new SQLiteCommand(sql_con);
            sql_cmd.CommandText = " INSERT  INTO FILES(name, path, flgcopy, dimension) VALUES('" + fileStream.Name + "' ,'" + fileStream.Path + "'," + fileStream.Flgcopy + ")";
            sql_cmd.ExecuteNonQuery();
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
        }

        public List<FileStream> SelectRecordByFlgCopy(FileStream fileStream)
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            List<FileStream> fileStreams = new List<FileStream>();
            sql_cmd = new SQLiteCommand(sql_con);
            string stm = "SELECT * FROM Files where copy=" + fileStream.Flgcopy;
            sql_cmd.CommandText = stm;
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            while (rdr.Read())
            {
                FileStream f = ReadRecord(rdr);
                fileStreams.Add(f);
            }
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
            return fileStreams;

        }

        public List<FileStream> SelectRecordById(FileStream fileStream)
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            List<FileStream> fileStreams = new List<FileStream>();
            sql_cmd = new SQLiteCommand(sql_con);
            string stm = "SELECT * FROM Files where id=" + fileStream.Id;
            sql_cmd.CommandText = stm;
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            while (rdr.Read())
            {
                FileStream f = ReadRecord(rdr);
                fileStreams.Add(f);
            }
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
            return fileStreams;

        }

        public List<FileStream> SelectRecordByName(FileStream fileStream)
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            List<FileStream> fileStreams = new List<FileStream>();
            sql_cmd = new SQLiteCommand(sql_con);
            string stm = "SELECT * FROM Files where name='" + fileStream.Name+"'";
            sql_cmd.CommandText = stm;
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            while (rdr.Read())
            {
                FileStream f = ReadRecord(rdr);
                fileStreams.Add(f);
            }
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
            return fileStreams;

        }

        public List<FileStream> SelectRecordByPath(FileStream fileStream)
        {
            if (sql_con.State == ConnectionState.Closed)
            { sql_con.Open(); }
            List<FileStream> fileStreams = new List<FileStream>();
            sql_cmd = new SQLiteCommand(sql_con);
            string stm = "SELECT * FROM Files where path='" + fileStream.Path + "'";
            sql_cmd.CommandText = stm;
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            while (rdr.Read())
            {
                FileStream f = ReadRecord(rdr);
                fileStreams.Add(f);
            }
            if (sql_con.State == ConnectionState.Open)
            { sql_con.Close(); }
            return fileStreams;

        }

        private FileStream ReadRecord(SQLiteDataReader rd)

        {
            FileStream fileStream = new FileStream();
            fileStream.Id = rd.GetInt32(0);
            fileStream.Name = rd.GetString(1);
            fileStream.Path = rd.GetString(2);
            fileStream.Flgcopy = rd.GetInt32(3);
            return fileStream;
        }
    }
}
