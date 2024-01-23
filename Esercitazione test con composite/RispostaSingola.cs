using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class RispostaSingola : Domande
	{
		string _testo;
		public string Testo
		{
			get { return _testo; }
			set { _testo = value; }
		}

		public RispostaSingola()
		{
			Testo = string.Empty;
		}

		public RispostaSingola(string testo)
		{
			Testo = testo;
		}

		public RispostaSingola(RispostaSingola vrispostasingola)
		{
			Testo = vrispostasingola.Testo;
		}

		public void Aggiunta()
		{

		}
		public double Punteggio()
		{
			return 0;
		}
		public IComponent GetChile(int indice)
		{
			return null;
		}
		public override string ToString()
		{
			return $"Risposta singola: {Testo}";
		}

	}
}
