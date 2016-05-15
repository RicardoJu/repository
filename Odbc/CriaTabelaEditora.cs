﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc
{
	class CriaTabelaEditora
	{
		static void Main(string[] args)
		{
			string stringDeConexao = @"driver={SQL Server};
			server=.\SQLEXPRESS; database=livraria; Trusted_Connection=Yes";

			using (OdbcConnection conexao = new OdbcConnection(stringDeConexao))
			{
				conexao.Open();

				string sql =
					"CREATE TABLE Editoras(" +
					"id BIGINT IDENTITY (1,1)," +
					"nome VARCHAR (255) NOT NULL," +
					"email VARCHAR (255) NOT NULL," +
					"CONSTRAINT PK_Editoras PRIMARY KEY CLUSTERED (id asc)" +
					")";
				OdbcCommand command = new OdbcCommand(sql, conexao);
				command.ExecuteNonQuery();
			}
		}
	}
}
