using Microsoft.AspNetCore.Mvc;
using ProjectBancoValentim.Models;
using ProjectBancoValentim.Models.SQL;
using System.Data.SqlClient;
using System.Net;

namespace ProjectBancoValentim.Controllers
{
    [ApiController]
    [Route("api/viniboy")]
    public class BankController : ControllerBase
    {
        [HttpPost("exemplo1/{beterraba}")]
        public string Post([FromBody] Person person, string beterraba, [FromQuery] int batata)
        {
            Database dataBase = new Database();

            SqlConnection connectionSql = new SqlConnection(dataBase.ConnectionString());    // parametro necessario para SqlConnection é uma string
            SqlCommand commandSql = new SqlCommand();                                              //criando uma variavel para fazer comandos do sql                                                                                          // que identifica o caminho de conexão com o banco
            connectionSql.Open(); //Abrindo conexão sql
            string commandInsert = $"INSERT INTO Person (Name, Id) VALUES ('{person.Name}','{person.Id}')";

            commandSql = new SqlCommand(commandInsert, connectionSql);
            commandSql.ExecuteNonQuery();
            connectionSql.Close(); //fecha conexão sql

            return HttpStatusCode.OK.ToString();
        } 
    }
}