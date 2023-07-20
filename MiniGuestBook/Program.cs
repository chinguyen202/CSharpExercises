using MiniGuestBook;

ConsoleMessages.WelcomeMessage();
var (guests, totalGuest) = ConsoleMessages.GetAllGuests();
ConsoleMessages.DisplayGuestList(guests);
Console.WriteLine($"Total guests are: {totalGuest}");
