## Warning

````csharp
Converting null literal or possible null value into non-nullable type
````

## Lösung

### Option 1: Make the list type nullable

- This warning is due to the changes in C# 8.0 and later, which introduced nullable reference types. This feature helps you avoid null reference exceptions by making you explicitly declare when a reference type can be null.

- In your case, the warning is likely because you're using a non-nullable string type in your List<string>, but you're not guaranteeing that the strings in the list will never be null.

 - To fix this warning, you have a few options:

````csharp
List<string?> menuOptions = new List<string?>
{
    "Option 1: Do something",
    "Option 2: Do something else",
    "Option 3: Exit"
};
````

### Option 2: Initialize the list with non-nullable strings

````csharp
List<string> menuOptions = new List<string>
{
    "Option 1: Do something"?? string.Empty,
    "Option 2: Do something else"?? string.Empty,
    "Option 3: Exit"?? string.Empty
};

````
### Option 3: Disable nullable reference types for the project

````csharp
 #nullable disable
````
