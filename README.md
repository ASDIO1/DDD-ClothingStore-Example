# DDD-ClothingStore-Example

This is only a university project for studying purposes.

## Objectives

Do a simple OOP based program following DDD and SOLID principles.

The following requirements must be fullfiled:

-  Implement a minimum of 5 classes
-  Implement multiple inheritance (interfaces in the case of C#)
-  Have at least 1 abstract class
-  Implement an example that showcases that the Liskov polimorfism principle is present in this program
-  Make an UML diagram for this program's domain
-  Follow the correct code standards for the programing languaje in use (in this case im using C#)

## Explanation

I made a simple and  dummy program that fullfills all the requirements.
This program is about a regular clothing store where the core products are clothes but there can also be other products like accessories.

### 1. Minimum of 5 classes and use of multiple inheritance

The classes in the program are:
-  Product
-    Clothing
-      Tshirt
-      Shirt
-    Accesorie
-      Necklace
-    IButtonUp interface (to showcase multiple inheritance in C#)

### 2. Minimum of 1 abstract class

Product is the abstract class in this program.
It has the main properties of a clothing store product and the "TryOn" abstract method that is abstract because it douesnt make sense to talk
about trying on a product without specifying the product.

Clothing and Accesorie are the child classes of Product. They have to implement the abstract method "TryOn". They also have their own specific properties
aside of having the Product properties that are inherited.

Tshirt and Shirt are the child classes of Clothing. They inherit the properties  from Clothing and they are able to implement their own version of the
"TryOn" abstract method. They also have their unique properties.

Necklace is the child class of Accesorie and it has its own property and its own implementation for the "TryOn" abstract method.

IButtonUp is an interface used by the classes that refer to products that have buttons and they need to be buttoned up.
The classes that use this interface are the Shirt and Necklace.


### 3. Implement Liskovs polimorfism principle

As explained in the previous point, "TryOn" is an abstract method that can be implemented differently in each Class that inherits from THE Product class.
So in the "program.cs" file I have created a list of products and added to it an object of each class (Clothing, Shirt, Tshirt, Accesorie and Necklace).
Then with a for loop for each product in the products list I made each product to use the "TryOn" method which is implemented differently by each class.
(The Shirt and Necklace classes use the IButtonUp method inside the "TryOn" method implementation each one of these classes has)

The code is very simple and should be self explanatory on how each class implements the "TryOn" method differently.

### 4. UML diagram

The UML class diagram for this project was added as a ".jpg" file.

### 5. Code standards

I have followed the common code good practices and since I have used C#, I used camel case writting.
I have also started every method and class name with an uppercase letter as it is usal in C# programming.

