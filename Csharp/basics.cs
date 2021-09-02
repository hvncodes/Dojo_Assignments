// for loop iteration
string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
// The 'Length' property tells us how many values are in the Array (4 in our example here). 
// We can use this to determine where the loop ends: Length-1 is the index of the last value. 
for (int idx = 0; idx < myCars.Length; idx++)
{
    Console.WriteLine($"I own a {myCars[idx]}");
}

// foreach loop iteration
// string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}

//Initializing an empty list of Motorcycle Manufacturers
List<string> bikes = new List<string>();
//Use the Add function in a similar fashion to push
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
//Accessing a generic list value is the same as you would an array
Console.WriteLine(bikes[2]); //Prints "BMW"
Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

//Using our array of motorcycle manufacturers from before
//we can easily loop through the list of them with a C-style for loop
//this time, however, Count is the attribute for a number of items.
Console.WriteLine("The current manufacturers we have seen are:");
for (var idx = 0; idx < bikes.Count; idx++)
{
    Console.WriteLine("-" + bikes[idx]);
}
// Insert a new item between a specific index
bikes.Insert(2, "Yamaha");
//Removal from Generic List
//Remove is a lot like Javascript array pop, but searches for a specified value
//In this case we are removing all manufacturers located in Japan
bikes.Remove("Suzuki");
bikes.Remove("Yamaha");
bikes.RemoveAt(0); //RemoveAt has no return value however
//The updated list can then be iterated through using a foreach loop
Console.WriteLine("List of Non-Japanese Manufacturers:");
foreach (string manu in bikes)
{
    Console.WriteLine("-" + manu);
}

Dictionary<string,string> profile = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries
profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);

// foreach (KeyValuePair<string,string> entry in profile)
// {
//     Console.WriteLine(entry.Key + " - " + entry.Value);
// }

// // KeyValuePair<string,string> looks a bit scary, we can clean this up using
// // a technique called type inheritance, the compiler to infer what the type
// // will be based on the very first value assigned to it
// // The var keyword takes the place of a type in type-inference
// foreach (var entry in profile)
// {
//     Console.WriteLine(entry.Key + " - " + entry.Value);
// }