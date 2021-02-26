// Put your code here
//an array to hold this list of names
const names = ["Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

// Print some output to the terminal (aka. "Console");
console.log("All Place Names")

// Iterate over each "name" in the "names" list
for (let name of names) {
    console.log(name)
}

//add /n to seperate the two list
console.log("")

// Filter the list to create a new list that only has 
//  place names that start with the word "The".
let filteredArray = names.filter(name => name.startsWith("The"))

console.log("'The' Place Names")
for (let name of filteredArray) {
    console.log(name)
}