﻿# 🐳 nUnit und der  Unit-Test

#### und die bewerten Muster aus der Praxis:

## 🐬 using / import packages

  - in einem Code Bereich definieren wir eine classe welche von nUnit erkannt werden kann

````csharp


using NUnit.Framework;
namespace nUnit_Calculator_V02;

````


## 🐬 [TestFixture] Attribute setzen

-       


````csharp
[TestFixture] // Attribut funktioniert nur mit dem nUnit Framework und einer classen Definition mit Rückgabewert


public class T000_Calculator
{ ... }

````

## 🐬 [Test] Attribute setzen

-       


````csharp

    [Test] // Attribut funktioniert nur mit dem nUnit Framework
    public void AddTest()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2,3);

        Assert.ReferenceEquals(5, result);
    }




````


## 🐬 Vorbereitung mit Arrange

-       


````csharp


        // Arrange
        var calculator = new Calculator();
        var a = 2;
        var r = 5;

````




## 🐬 Handlung mit Act


````csharp

        // Act
        var result = calculator.Add(a, r);

````



## 🐬 Prüfen mit Assert

### 1 - positiven Fall-Test
### 2 - negativen Fall-Test



````csharp

        // Assert
        Assert.Equals(5, result);

````





