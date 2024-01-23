using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class RispostaMultipla
	{
		string _testomultipla;
		public string Testomultipla
		{
			get { return _testomultipla;}
			set { _testomultipla = value;}
		}
		public RispostaMultipla()
		{
			Testomultipla = string.Empty;
		}

		public RispostaMultipla(string testomultipla)
		{
			Testomultipla = testomultipla;
		}

		public RispostaMultipla(RispostaMultipla vrispostamultipla)
		{
			Testomultipla = vrispostamultipla.Testomultipla;
		}

		public override string ToString()
		{
			return $"Risposta multipla: {Testomultipla}";
		}
	}
}
