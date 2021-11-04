## Klasser

#### Klassnamn
Använd singular, t.ex. Person, Vehicle, User, BankAccount

###### Syntax
```csharp
accessModifier class KlassNamn{}
```

##

###### Exempel
```csharp
public class Person
{
}
```

---

#### Field (Variabler)
Egenskaper som ska finnas med. <br>
_Privata fields inleds med_ _ _och liten bokstav._ <br>
_Publika fields inleds med stor bokstav._<br>
<ins>_Undvik publika fields._</ins>

_Om ingen accessModifier skriv innan datatypen blir det private._
###### Syntax
```csharp
accessModifier datatyp namn;
```

##

###### Exempel
```csharp
private int _age;
public int Age;
```

---

#### Property (Get & Set)
Property är speciella metoder som används för att läsa/skriva skyddade variabler utanför klassen.<br>
Properties använder samma namn som den skyddade variabeln, dock med stor bokstav och utan _<br>
Property behöver inte innehålla både get och set, det går att skapa med endast en av dessa.

_get - Används för att läsa värdet i en skyddad variabel._<br>
_set - Används för att tilldela ett värde till en skyddad variabel._<br>

_**Använd endast property om data behöver kunna nås utanför klassen.**_
###### Syntax
```csharp
accessModifier datatyp Namn {get {return namn;} set {namn = value;} }
```

##

###### Exempel
```csharp
public int Age
{
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
}
```

---

#### Automatic Property
Automatic property är ett kortare sätt att skriva sina properties.<br>
Vid användning av automatic properties så behöver man inte skapa skyddade fields för samma värde.<br>

###### Syntax
```csharp
accessModifier datatyp Namn {get; set;}
```

##

###### Exempel
```csharp
public int Age {get, set;}
public string Name {get; set;}
```

---

#### Metod
Isolerad del av koden som kan anropas och återanvändas.<br>
Kan returnera värden och/eller utföra en funktion.<br>

_void - Ingen retur från metoden._<br>
_datatyp - Retur från metoden, samma datatyp som angivet i metodtyp._

###### Syntax
```csharp
accessModifier metodtyp MetodNamn(ev. indata){}
```

##

###### Exempel
```csharp
// Skriver ut _name.
public void PrintName()
{
    Console.WriteLine("name: {0}", _name);
}

// Returnerar en boolean.
// true eller false, baserat på om age är större än 18.
public bool VerifyUser(int age)
{
    return age > 18;
}
```

---

#### Konstruktor
Metod för att skapa objekt utifrån klassen.<br>
Kan finnas flera i samma klass; med olika antal parametrar.<br>
Samtliga konstruktorer behöver ha samma namn som klassen.

###### Syntax
```csharp
accessModifier KlassNamn(ev. parametrar)
{
}
```

##

###### Exempel
```csharp
public Person()
{
}

public Person(string name, int age)
{
    this._name = name;
    this._age = age;
}
```

---

#### Exempel - Person

```csharp
public class Person
{
    // Fields
    private int _age;
    private string _name;

    // Properties
    public string Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    // Metoder
    public void PrintInfo()
    {
        Console.WriteLine("Name: {0}",_name);
        Console.WriteLine("Age: {0}",_age);
    }

    // Konstruktorer
    public Person()
    {
    }

    public Person(string name, int age)
    {
        this._name = name;
        this._age = age;
    }
}
```

---

#### Exempel - BankAccount

```csharp
public class BankAccount
{
    // Fields
    private int _accountId;
    private int _accountHolderId;
    private double _balance;

    // Properties
    public string AccountId
    {
        get
        {
            return _accountId;
        }
        set
        {
            _accountId = value;
        }
    }

    public string AccountHolderId
    {
        get
        {
            return _accountHolderId;
        }
        set
        {
            _accountHolderId = value;
        }
    }

    public double Balance
    {
        get
        {
            return _balance;
        }
    }

    // Metod
    public void ShowBalance()
    {
        Console.WriteLine("Current balance: {0}",_balance);
    }

    public void DepositMoney(double amount)
    {
        _balance += amount;
    }

    // Konstruktor
    public BankAccount(int accountHolderId)
    {
        this._accountHolderId = accountHolderId;
        this._balance = 0;
    }
}
```

---

## Static

#### Klass
En statisk klass går inte att instansiera.<br>
Dvs. det går inte att skapa objekt av klassen.

_Samtliga fields och metoder i klassen måste även dessa vara static._<br>
_Statiska klasser används t.ex. som en basklass som andra klasser ärver ifrån._

###### Syntax
```csharp
accessModifier static class KlassNamn
{
}
```

##

###### Exempel
```csharp
public static class Person
{
}
```

---

#### Metod
En statisk metod tillhör klassen istället för varje objekt.<br>
För att anropa metoden behöver man gå via klassnamnet.<br>

###### Syntax
```csharp
accessModifier static metodtyp MetodNamn(ev. indata)
{
    // Kod här
}
```

##

###### Exempel - Skapa en statisk metod
```csharp
public static void PrintSomething()
{
    Console.Write("Something");
}
```

##

###### Exempel - Anropa en statisk metod
```csharp
KlassNamn objektNamn = new KlassNamn();

// Korrekt anrop
KlassNamn.PrintSomething();

// Felaktigt anrop
objektNamn.PrintSomething();
```

---

#### Exempel - Converter
```csharp
static class Converter
{
    public static decimal ConvertSEKToUSD(decimal amountSEK)
    {
        return (amountSEK / _currentValueUSD);
    }
}
```

##

```csharp
static void Main(string[] args)
{
    Converter.ConvertSEKToUSD(100);
}
```

---

## Abstract

#### Klass
En abstrakt klass går, likt en statisk klass, inte att instansiera.<br>
Dvs. det går att att skapa objekt av klassen.<br>
En abstrakt klass kan dock innehålla fields och metoder som INTE är static.

_Abstrakta klasser används för basklasser som andra klasser ärver ifrån._


###### Syntax
```csharp
accessModifier abstract class KlassNamn
{
}
```

##

###### Exempel
```csharp
abstract class BaseClass
{
}
```

---

#### Metod
En abstrakt metod saknar kodblock och är automatiskt polymorfisk.<br>
Kodblocket läggs till i ärvande klasser vid implementering.<br>
En abstrakt klass kan ha både in- & utdata.

###### Syntax
```csharp
accessModifier abstract metodtyp MetodNamn(ev. indata);
```

##

###### Exempel
```csharp
// Varken in- eller utdata
public abstract void MakeNoise();

// Endast indata
public abstract void PrintName(string name);

// Endast utdata
public abstract int GetMinimumAge();

// In- & utdata
public abstract string ReverseName(string name);
```

---

#### Exempel - Animal
```csharp
abstract class Animal
{
    protected string _species;
    protected string _name;
    protected bool _flying;

    public abstract void PrintInfo();
    public abstract string PrintSpecies();
}
```

---
