using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models
{
	public class Contexto : DbContext
	{
		public DbSet<Veiculo> Veiculos { get; set; }

		public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
		{

		}
	}
}
