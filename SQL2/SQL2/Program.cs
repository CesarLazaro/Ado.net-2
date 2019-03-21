using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQL2
{
    class Program
    {
        static void Main(string[] args)
        {

            string comando = "SELECT * FROM SONG";
            string comando2 = "EXECUTE MOSTRAR @ID=4;"; 
            string comando3 ="INSERT INTO SONG VALUES ('CANCIONEJEMPLO',180,'EJEMPLO',1)";
            SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database=SPOTIFY2 ; integrated security = true");
            conexion.Open();
            SqlCommand command = new SqlCommand(comando, conexion);
            command.ExecuteNonQuery();
            SqlCommand comman2 = new SqlCommand(comando3, conexion);
            comman2.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            int c = 0;
            while (reader.Read())
            {
                
                while (c<reader.FieldCount)
                {
                    Console.Write(reader.GetValue(c) + "   " );
                    c++;
                }
                Console.Write("\n");
                c = 0;
            }
            conexion.Close();
            Console.ReadKey();

        }
    }
}
