using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class RispostaSingola : Domande
	{
		string _testosingola;
		public string Testosingola
		{
			get { return _testosingola; }
			set { _testosingola = value; }
		}

		public RispostaSingola()
		{
			Testosingola = string.Empty;
		}

		public RispostaSingola(string testo)
		{
			Testosingola = testo;
		}

		public RispostaSingola(RispostaSingola vrispostasingola)
		{
			Testosingola = vrispostasingola.Testosingola;
		}

		public void Aggiunta()
		{

		}
		public double Punteggio()
		{
			return 10;
		}
		public IComponent GetChild(int indice)
		{
			return null;
		}
		public override string ToString()
		{
			return $"Risposta singola: {Testosingola}";
		}
		public override bool Equals(object obj)
		{
			if (!(obj is RispostaSingola) || obj == null)
				return false;

			RispostaSingola other = (RispostaSingola)obj;

			return Testosingola == other.Testosingola;
		}
	}
}
