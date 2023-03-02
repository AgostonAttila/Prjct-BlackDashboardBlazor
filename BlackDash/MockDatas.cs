using BlackDash.Models;

namespace BlackDash
{




	public class MockDatas
	{

		private static MockDatas _mockDatas;

		public List<AppUser> _appUserList;
		public List<TableHeader> _headerList;

		public string[] chartDatasShipment;
		public string[] chartLabelsShipment;
		public string[] chartColorsShipment;

		public string[] chartDatasCountry;
		public string[] chartLabelsCountry;
		public string[] chartColorsCountry;


		public string[] chartDatasSales;
		public string[] chartLabelsSales;
		public string[] chartColorsSales;


		public string[] chartDatas;
		public string[] chartLabels;
		public string[] chartColors;
		protected MockDatas()
		{

			_appUserList = new List<AppUser>
			{
			 new AppUser{LastName = "Rice",FirstName = "Dakota",Country ="Niger",City = "Oud-Turnhout",  Salary =36738  },
			 new AppUser{LastName = "Hooper",FirstName = "Minerva",Country ="Curacao", City = "Sinaai-Waas",Salary =23789  },
			 new AppUser { LastName = "Rodriguez", FirstName = "Sage", Country = "Netherlands", City = "Baileux", Salary = 56142 },
			 new AppUser { LastName = "Chaney", FirstName = "Philip", Country = "Korea, South", City = "Overland Park", Salary = 38735 },
			 new AppUser { LastName = "Greene", FirstName = "Doris", Country = "Malawi", City = "Feldkirchen in Karnten", Salary = 63542 } ,
			 new AppUser { LastName = "Porter", FirstName = "Mason", Country = "Chile", City = "Gloucester", Salary = 78615 },
			 new AppUser { LastName = "Porter", FirstName = "Jon", Country = "Portugal", City = "Gloucester", Salary = 98615 }
			};

			_headerList = new List<TableHeader>
			{
			new TableHeader{ Text = "Name" },
			new TableHeader{ Text = "Country" },
			new TableHeader{ Text = "City" },
			new TableHeader{ Text = "Salary"  ,Class=" text-center"}
			};

			chartDatasShipment = new[] { "80", "100", "70", "80", "120", "80" };
			chartLabelsShipment = new[] { "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
			chartColorsShipment = new[] { "#ec250d" };

			chartDatasCountry = new[] { "53", "20", "10", "80", "100", "45" };
			chartLabelsCountry = new[] { "USA", "GER", "AUS", "UK", "RO", "BR" };
			chartColorsCountry = new[] { "#1f8ef1" };


			chartDatasSales = new[] { "90", "27", "60", "12", "80" };
			chartLabelsSales = new[] { "JUL", "AUG", "SEP", "OCT", "NOV" };
			chartColorsSales = new[] { "#00d6b4" };


			chartDatas = new[] { "60", "80", "65", "130", "80", "105", "90", "130", "70", "115", "60", "130" };
			chartLabels = new[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
			chartColors = new[] { "#ec250d" };

		}
		public static MockDatas Instance
		{
			get
			{
				if (_mockDatas == null) _mockDatas = new MockDatas();
				return _mockDatas;
			}
		}





	}
}
