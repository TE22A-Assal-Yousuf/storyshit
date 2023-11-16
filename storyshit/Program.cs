string unkownvoice = "(???)";
string god = "uriu";

Console.WriteLine($"{unkownvoice} Hello, Traveler you seem to be lost and ahve stumbled into a forrest. What's your name?");
string name = Console.ReadLine().ToLower();


Console.WriteLine($"{unkownvoice} Well {name} You Seem to be in quite the pickle!");

Console.WriteLine($"{name} Wait who are you?");
Console.WriteLine($"{unkownvoice} I am {god} i am the watcher of this forrest");

Console.WriteLine($"{god} do you chooose to go deeperin?");

string godeeper = Console.ReadLine().ToLower();

if(godeeper == "yes"){
    Console.WriteLine($"(???) {name} You keep walking deeper into the forrest and you hapen opon two pathways one to the left and the other to the right, which do you choose?");
}
else if(godeeper == "no"){
    Console.WriteLine($"()");
}
string direction = Console.ReadLine().ToLower();

if (direction == "right" || direction == "right"){
    Console.WriteLine($"You pick the {direction} path and continue to Wonder around");
}
else{
    Console.WriteLine("You acted stupidly and didn't pick any one of them and died X_X");

}
 
string check = Console.ReadLine().ToLower();

 if (check == "yes"){
    Console.WriteLine($"you check to see how long its been");
    Console.WriteLine($"3 Hours have passed you start to wonder if {direction} really was the right choise.");

}
else if (check == "no"){
    Console.WriteLine($"you dont check how long its been and continue to follow the {direction} path");
}
else{
Console.WriteLine($"since you decided to be stupid you dont check how long its been and continue to follow the {direction} path");
}

Console.WriteLine("You happen oppon a cabin, do you enter?");

string enter = Console.ReadLine().ToLower();

if (enter == "yes"){
    Console.WriteLine($"What a brave soul, you enter but what i didn't tell you was that the cabin is haunted and you are trapped here forever!");
}
else if (enter == "no"){
    Console.WriteLine($"Smart choise, you do not enter the cabin and continue to follow the {direction} path");
}
else{
Console.WriteLine("since you decided to be stupid and didn't pick any one of them and died X_X ");
}

Console.ReadLine();