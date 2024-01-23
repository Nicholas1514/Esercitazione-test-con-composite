using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class VeroFalso : Domande
	{
		private string _testovf;

		public string Testovf
		{
			get { return _testovf; }
			set { _testovf = value; }
		}

		public VeroFalso()
		{
			Testovf = "";
		}

		public VeroFalso(string testo)
		{
			Testovf = testo;
		}

		public VeroFalso(VeroFalso vDomanda)
		{
			Testovf = vDomanda.Testovf;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is VeroFalso) || obj == null)
				return false;

			VeroFalso other = (VeroFalso)obj;

			return Testovf == other.Testovf;
		}

		public void Aggiunta(IComponent comp)
		{

		}

		public void Rimuovi(int index)
		{

		}

		public IComponent GetChild(int index)
		{
			return null;
		}

		public override string ToString()
		{
			return $"Testo domanda vero/falso: {Testovf};";
		}

		public double Punteggio()
		{
			return 10;
		}
	}
}
