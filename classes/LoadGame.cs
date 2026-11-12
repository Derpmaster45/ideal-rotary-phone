namespace TextadventureFramework
{
using System.Runtime.Serialization;
using System.Text.Json;
using System.Collections;
using System.Security.Cryptography;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Drawing;
	class LoadGame
	{
		public static void SaveGame(string SaveName)
		{
			SaveName="YOURGAMENAMEHERE";
			string JsonObjectString=File.ReadAllText(SaveName);
			Character characterToLoad=JsonSerializer.Deserialize<Character>(JsonObjectString);
			/*
			 * I plan on adding more fuctionality but also want to have more
			 * of an idea of how to do load game functionality properly the functionality will come in a future update.
			 *  - Jay
			 */ 
			
		}
	}
}
