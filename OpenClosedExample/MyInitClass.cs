namespace OpenClosedExample
{
	public class MyInitClass
	{
		private readonly AccomodationCalculationConditioner _accomodationCalculationConditioner;

		public MyInitClass()
		{
			_accomodationCalculationConditioner = new AccomodationCalculationConditioner();
		}

		public void Init(string accomodationType)
		{
			var calculator = _accomodationCalculationConditioner.GetCalculationConditionForType(accomodationType);
			var fare = calculator.Calculate();
		}
	}
}
