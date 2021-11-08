## Try-Catch


### Try
Sektion av kod som ska testas för fel/exception medan den exekveras

###### Syntax
```csharp
try
{
    // Kod som ska köras - "Skyddad kod".
}
```

###### Exempel

```csharp
try
{
    result = num1 / num2;
}
```

##

### Catch

Sektion av kod som ska köras ifall det uppstår fel/exception i try-blocket.<br>
Flera kan användas för att specificera baserat på typ av exception.

###### Syntax
```csharp
catch (Exceptiontyp)
{
    // Kod som ska köras vid fel/exception.
}
```

###### Exempel
```csharp
catch (Exception e)
{
    Console.Write(e.message);
}
```

##

### Finally

Finally kan läggas till sist i ett try-block.<br>
Körs alltid, oavsett om fel/exception uppstår eller inte.

###### Syntax
```csharp
finally
{
    // Kod som alltid körs.
}
```

###### Exempel
```csharp
finally
{
    Console.Write("Try-Catch finished.");
}
```

---

### Exempel


```csharp
int num1 = 3;
int num2 = 0;
double result;

try                             // Försök köra koden.
{   
    result = num1 / num2;       // Försök att dela num1 (3) med num2 (0)
}
catch (Exception e)             // Kod som utförs vid fel/exception.
{
    Console.Write(e.Message);   // Skriv ut felmeddelandet
}
finally                         // Kod som körs oavsett.
{
    Console.Write("Finally!");  // Skriv ut Finally!
}

```

**Output:**<br>
Attempted to divide by zero.<br>
Finally!

_Catch körs pga DivideByZeroException._<br>
_Går inte att dividera med 0._