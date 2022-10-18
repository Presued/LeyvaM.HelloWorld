//Manuel Leyva
//10-17-22
//Hello World
//You will be able to interact with the code
//Peer Review:

string uInput = "";
do{

Console.Clear();
Console.WriteLine("Hello World, Whats your Name");
string yourName = Console.ReadLine();
Console.WriteLine("Nice to meet you " + yourName );

do
{
    Console.WriteLine("Do you want to continue: Yes or No?");
    uInput = Console.ReadLine().ToUpper();
    if(uInput != "YES" && uInput != "NO")
    {
        Console.WriteLine("That's not correct, pLease say Yes or No");
    }
}while (uInput !="YES" && uInput != "NO");
}while(uInput == "YES");
