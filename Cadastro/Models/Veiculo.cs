using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models
{
	public class Veiculo
	{
		public int Veiculoid { get; set; }

		public string Placa { get; set; }

		public string Renavan { get; set; }

		public string NomeProprietario { get; set; }

		public string CPF { get; set; }

		public byte[] CarregarImagens { get; set; }

		
	}
}
