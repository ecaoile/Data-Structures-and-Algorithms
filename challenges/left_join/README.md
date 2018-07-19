# Whiteboard Challenge 33: Implement a simplified LEFT JOIN for 2 Hashmaps
This program emulates a left join on two tables using
two hash maps.

Example:	
        
    Input
    First hash map: 
    [
        ["fond", "enamored"]
        ["wrath", "anger"]
        ["diligent", "employed"]
        ["outfit", "garb"]
        ["guide", "usher"]
    ]

    Second hashmap: 
    [
        ["fond", "averse"]
        ["wrath", "delight"]
        ["diligent", "idle"]
        ["guide", "follow"]
        ["flow", "jam"]
    ]

    Output:
    [
        ["fond", "enamored", "averse"]
        ["wrath", "anger", "delight"]
        ["diligent", "employed", "idle"]
        ["outfit", "garb", NULL]
        ["guide", "usher", "follow"]
    ]

## Challenge
Write a function that LEFT JOINs two hashmaps into a single data structure. 
The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values. 
The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values. 
Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic. 
LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row. 
The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic. 
Avoid utilizing any of the library methods available to your language.

## Solution
![whiteboard 33 image](../../assets/left_join.jpg "Whiteboard Challenge 33 Solution")
