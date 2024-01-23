using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test_con_composite
{
	//Test --> composto
	//Domande --> composto
	//Risposte --> foglia
	public class Test : Composite
	{
		private List<Composite> _componenti;

		public List<Composite> Composites
		{
			get { return _componenti; }
			set { _componenti = value; }
		}

		public Test()
		{
			Composites= new List<Composite>();
		}
		public Test(Test vtest)
		{
			Composites = vtest.Composites;
		}

		public Test(List<Composite> componenti)
		{
			Composites = componenti;
		}

		

		public override bool Equals(object obj)
		{
			if (!(obj is Test) || obj == null)
			{
				return false;
			}
			Test altro = (Test)obj;
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

		public override void Aggiunta(Composite componente)
		{
			Composites.Add(componente);
		}

		public override void Rimuovi(int indice)
		{
			Composites.RemoveAt(indice);
		}

		public override Composite GetChild(int indice)
		{
			throw new NotImplementedException();
		}
		public override int Punteggio()
		{
			int tot = 0;

			foreach (var component in Composites)
			{
				tot += component.Punteggio();
			}

			return tot;
		}
	}
}
