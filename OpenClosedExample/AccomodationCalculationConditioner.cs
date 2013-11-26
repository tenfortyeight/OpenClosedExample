using System;
using System.Collections.Generic;

namespace OpenClosedExample
{
	public class AccomodationCalculationConditioner
	{
		private readonly Dictionary<string, IAccomodationsFareConditions> _conditions;

		public AccomodationCalculationConditioner()
		{
			_conditions = new Dictionary<string, IAccomodationsFareConditions>
				{
					{"apartment", new ApartmentCalculator()},
					{"house", new HouseCalculator()},
					{"room", new RoomCalculator()}
				};
		}

		public IAccomodationsFareConditions GetCalculationConditionForType(string accomodationType)
		{
			if (_conditions.ContainsKey(accomodationType))
			{
				return _conditions[accomodationType];
			}
			throw new ArgumentOutOfRangeException("accomodationType", "Invalid accomodation type provided");
		}
	}
}