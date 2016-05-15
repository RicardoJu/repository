using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc
{
	class ListaEditoras
	{
		static void Main(string[] args)
		{
			
			
			using (OdbcConnection conexao = ConnectionFactory.CreateConnection())
			{
				string sql = "SELECT * FROM Editoras";
				OdbcCommand command = new OdbcCommand(sql, conexao);
				conexao.Open();
				OdbcDataReader resultado = command.ExecuteReader();

				List<Editora> Lista = new List<Editora>();

				while (resultado.Read())
				{
					Editora e = new Editora();

					e.Id = resultado["Id"] as long?;
					e.Nome = resultado["Nome"] as string;
					e.Email = resultado["Email"] as string;

					Lista.Add(e);

				}

				foreach( Editora e in Lista)
				{
					System.Console.WriteLine("{0} : {1} - {2}\n", e.Id, e.Nome, e.Email);
				}


			}
		}
	}
}
