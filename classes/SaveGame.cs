namespace TextadventureFramework
{
	//using Character;
	class SaveGame
	{
		public static void SaveCharacter(Character playertosave)
		{
			Character saveslot=new Character();
			saveslot.playername=playertosave.playername;
			saveslot.playerhealth=playertosave.playerhealth;
			saveslot.playerlevel=playertosave.playerlevel;
			saveslot.playerdefensebase=playertosave.playerdefensebase;
			saveslot.playerexp=playertosave.playerexp;
			saveslot.exptonextlevel=playertosave.exptonextlevel;
			saveslot.playerclass=playertosave.playerclass;
			saveslot.playertextcolor=playertosave.playertextcolor;
			return saveslot;
		}
	}
}
