using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class RispostaMultipla : Domande
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
		public void Aggiungi()
		{

		}
		public void Rimuovi()
		{

		}
		public IComponent GetChild(int indice)
		{
			return null;
		}
		public double Punteggio()
		{
			return 10;
		}
		public override string ToString()
		{
			return $"Risposta multipla: {Testomultipla}";
		}
	}
}
