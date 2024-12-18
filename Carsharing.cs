using System;
using System.Collections.Generic;

public class Interface
{
    public static void Registration(string[] args)
    {
        Console.WriteLine ("Welcome to your carsharing!");
        
        var client1 = new Client(89, "Pavels Ivanovs", "pivanov@gmail.com");
		
		client1.PrintClients();
    }
}

public class Client
{
	private int _clientId;
	private string _clientNameAndSurname;
	private string _clientEmail;
	
	public int clientId
	{
		get
			{
				return _clientId;
			}
	}
	
	public string clientNameAndSurname
    {
        get
        {
            return _clientNameAndSurname;
        }
    }
	
	public string clientEmail
	{
		get
		{
			return _clientEmail;
		}
	}
	
	public Client(int clientId, string clientNameAndSurname, string clientEmail)
	{
		_clientId = clientId;
		_clientNameAndSurname = clientNameAndSurname;
		_clientEmail = clientEmail;
	}
	
	private List<Client> _clientList = new List<Client>();
	
	public List<Client> ClienttList
	{
		get
		{
			return _clientList;	
		}
	}
	
    public void RequestInfo()
    {
        Console.WriteLine($"{_clientId} {_clientNameAndSurname} {_clientEmail}");
    }
    
	public void AddClient(Client client)
	{
		_clientList.Add(client);
	}
	
	public void PrintClients()
	{
		Console.WriteLine($"Client {_clientId} {_clientNameAndSurname} {_clientEmail}:");
	}
}
	
class Program
{
	static void Main()
	{
		List<Tesla> teslas = new List<Tesla>
		{
			new Tesla("Model S", 0.50m, 0.50m),
			new Tesla("Model X", 0.60m, 0.60m),
			new Tesla("Model Y", 0.40m, 0.40m)
		};
		Console.WriteLine("Sveicināti Tesla īres sistēmā!");
		Console.WriteLine("Pieejamie modeļi:");
		for (int i = 0; i < teslas.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {teslas[i].Model} - {teslas[i].RatePerHour} par stundu un {teslas[i].RatePerKilometer:C} par kilometru");
		}

		Console.Write("Izvēlieties modeļa numuru: ");
		int choice = int.Parse(Console.ReadLine()) - 1;
		if (choice < 0 || choice >= teslas.Count)
		{
			Console.WriteLine("Nepareizs izvēles numurs.");
			return;
		}

		Tesla chosenTesla = teslas[choice];
		Console.WriteLine($"Izvēlētais modelis: {chosenTesla.Model}");
		Console.WriteLine("Ievadiet īres sākuma laiku (YYYY-MM-DD HH:mm): ");
		DateTime startTime = DateTime.Parse(Console.ReadLine());
		Console.WriteLine("Ievadiet īres beigu laiku (YYYY-MM-DD HH:mm): ");
		DateTime endTime = DateTime.Parse(Console.ReadLine());
		Console.WriteLine("Ievadiet nobraukto kilometru skaitu: ");
		decimal kilometers = decimal.Parse(Console.ReadLine());
		decimal cost = kilometers * chosenTesla.RatePerKilometer;
		Console.WriteLine($"Kopējā maksa: {cost:C}");
	}
}

class Tesla
{
	public string Model;
	public decimal RatePerHour;
	public decimal RatePerKilometer;

	public Tesla(string model, decimal ratePerHour, decimal ratePerKilometer)
	{
		Model = model;
		RatePerHour = ratePerHour;
		RatePerKilometer = ratePerKilometer;
	}
}
