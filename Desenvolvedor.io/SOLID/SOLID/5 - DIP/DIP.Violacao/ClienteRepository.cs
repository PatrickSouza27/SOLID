
using System.Data.SqlClient;


namespace SOLID.DIP.Violacao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [Cliente] (Nome, Email, Cpf, DataCadastro) VALUES (@Nome, @Email, @Cpf, @DataCadast)";

                cmd.Parameters.AddWithValue("Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("Email", cliente.Email);
                cmd.Parameters.AddWithValue("Cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("DataCadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
