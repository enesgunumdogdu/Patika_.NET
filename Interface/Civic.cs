namespace Interface
{
	public class Civic : iAutomobile
	{
		public Marka HangiMarkaninAraci()
		{
			return Marka.Honda;
		}

		public int KacTekerlektenOlusur()
		{
			return 4;
		}

		public Renk StandartRengiNe()
		{
			return Renk.Gri;
		}
	}
}