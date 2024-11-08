int yourPoints = 0;

do {
    //RESTORE POINTS IF FAILURE
    yourPoints = 0; 
    Console.WriteLine("I det här spelet kommer du få svara på fem gåtor. Du får 3 chanser att svara på varje gåta. ");
    Console.WriteLine("Tryck på Enter för att börja...");
    Console.ReadLine();  // Väntar på att användaren trycker Enter

    //GÅTA NR 1
    System.Console.WriteLine("GÅTA 1");
    System.Console.WriteLine("Jag kan inte ses, men jag finns överallt. Jag är ofta blå, men ibland grå. Vad är jag?");
    int numberofGuesses = 3;
    while (numberofGuesses > 0)
    {
      var guess = Console.ReadLine().Trim().ToLower();  
      if (guess == "himlen")
        {
            System.Console.WriteLine("Rätt svar!");
            yourPoints++;
            break;
        } else {
            numberofGuesses--;
            System.Console.WriteLine("Fel svar dumbom, försök igen!");
            System.Console.WriteLine($);
        }
    }
}