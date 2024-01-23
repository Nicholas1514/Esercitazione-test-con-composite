using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	public class Domande : Composite
	{
		private List<Composite> _componenti;

		public List<Composite> Composites
		{
			get { return _componenti; }
			set { _componenti = value; }
		}

		public Domande()
		{
			Composites = new List<Composite>();
		}
		public Domande(Domande vtest)
		{
			Composites = vtest.Composites;
		}

		public Domande(List<Composite> componenti)
		{
			Composites = componenti;
		}




		public override void Aggiunta(Composite componente)
		{
			Composites.Add(componente);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Domande) || obj == null)
			{
				return false;
			}
			Domande altro = (Domande)obj;
			if (Composites.Count != altro.Composites.Count)
			{
				return false;
			}

			for (int i = 0; i < Composites.Count; i++)
			{
				if (!Composites[i].Equals(altro.Composites[i]))
				{
					return false;
				}
			}

			return true;
		}

		public override Composite GetChild(int indice)
		{
			throw new NotImplementedException();
		}

		public override int Punteggio()
		{
			return 0;
		}

		public override void Rimuovi(int indice)
		{
			Composites.RemoveAt(indice);	
		}
	}
}
