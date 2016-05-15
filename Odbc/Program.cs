using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc
{
	class CriaBaseDeDadosLivraria
	{
		static void Main(string[] args)
		{
			string stringDeConexao = @"driver={SQL Server};
			server=.\SQLEXPRESS;Trusted_Connection=Yes";
 
			using (OdbcConnection conexao = new OdbcConnection ( stringDeConexao ))
			{
				conexao.Open();

				string sql = @"IF EXISTS
				(SELECT name FROM master.dbo.sysdatabases WHERE name = 'livraria')
				DROP DATABASE livraria";
				OdbcCommand command = new OdbcCommand(sql, conexao);
				command.ExecuteNonQuery();

				sql = @"CREATE DATABASE livraria";
				command = new OdbcCommand(sql, conexao);
				command.ExecuteNonQuery();


			}
		}
	}
}
