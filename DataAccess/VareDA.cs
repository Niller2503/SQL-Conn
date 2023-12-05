
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class VareDA
    {
        string connString;
        public VareDA()
        {
            connString = ConfigurationManager
                .ConnectionStrings["Niklas"]
                .ToString();
        }
        public List<Vare> Get()
        {
            List<Vare> VareListe= new List<Vare> ();
            string command = "SELECT * FROM VARE";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand=new SqlCommand(command, dbConn);
            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                Vare vare = new Vare();
                vare.ID = (int)reader["ID"];
                vare.Varenavn = (string)reader["Varenavn"];
                if (reader["Varebeskrivelse"]!= null)
                {
                    vare.VareBeskrivelse = (string)reader["VareBeskrivelse"];
                }
                vare.Antal = (int)reader["Antal"];
                vare.Indkøbspris = (decimal)reader["Indkøbspris"];
                vare.Fortjeneste = (decimal)reader["Fortjeneste"];
                vare.Udsalgspris = (decimal)reader["Udsalgspris"];
                VareListe.Add(vare); 
            }
            dbConn.Close();
            return VareListe;
        }
        public Vare Get(int id)
        {
            Vare vare = null;
            string command = "SELECT * FROM VARE WHERE ID=@ID";

            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", id);

            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                vare = new Vare
                {
                    ID = (int)reader["ID"],
                    Varenavn = (string)reader["Varenavn"],
                    VareBeskrivelse = reader["VareBeskrivelse"] != DBNull.Value ? (string)reader["VareBeskrivelse"] : null,
                    Antal = (int)reader["Antal"],
                    Indkøbspris = (decimal)reader["Indkøbspris"],
                    Fortjeneste = (decimal)reader["Fortjeneste"],
                    Udsalgspris = (decimal)reader["Udsalgspris"]
                };
            }

            dbConn.Close();
            return vare;
        }

        public bool Create(Vare vare)
        {
            string command = "INSERT INTO VARE (Varenavn, VareBeskrivelse, Antal, Indkøbspris, Fortjeneste) VALUES (@Varenavn, @VareBeskrivelse, @Antal, @Indkøbspris, @Fortjeneste)";

            using SqlConnection dbConn = new SqlConnection(connString);
            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Varenavn",vare.Varenavn);
            sqlCommand.Parameters.AddWithValue("@VareBeskrivelse", vare.VareBeskrivelse);
            sqlCommand.Parameters.AddWithValue("@Antal", vare.Antal);
            sqlCommand.Parameters.AddWithValue("@Indkøbspris", vare.Indkøbspris);
            sqlCommand.Parameters.AddWithValue("@Fortjeneste", vare.Fortjeneste);

            int res;
            try
            {
                dbConn.Open();
                res = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                dbConn.Close();
            }
            if (res == 0)
                return false;
            return true;
        }
        public bool Update(Vare vare)
        {
            string Command = "UPDATE VARE SET VARENAVN = @Varenavn, VAREBESKRIVELSE = @VareBeskrivelse, ANTAL = @Antal, INDKØBSPRIS = @Indkøbspris,FORTJENSTE = @Fortjeste ";
            using SqlConnection dbConn = new SqlConnection(connString);
            using SqlCommand sqlCommand = new SqlCommand(Command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Varenavn",vare.Varenavn);
            sqlCommand.Parameters.AddWithValue("@VareBeskrivelse", vare.VareBeskrivelse);
            sqlCommand.Parameters.AddWithValue("@Antal", vare.Antal);
            sqlCommand.Parameters.AddWithValue("@Indkøbspris", vare.Indkøbspris);
            sqlCommand.Parameters.AddWithValue("@Fortjenste", vare.Fortjeneste);
            int res;
            try
            {
                dbConn.Open();
                res = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                dbConn.Close();
            }
            if (res == 0)
                return false;
            return true;
        }
        public bool Delete(int id)
        {
            string command = "DELETE FROM VARE WHERE ID=@ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            int res;
            try
            {
                dbConn.Open();
                res = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                dbConn.Close();
            }
            if (res == 0)
                return false;
            return true;
        }
    }
}