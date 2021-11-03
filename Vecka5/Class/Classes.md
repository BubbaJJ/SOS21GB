## Klasser

**Klassnamn:**<br>
:   Använd singular, t.ex. Person, Vehicle, User, BankAccount
###### Syntax:
>_accessModifier class ClassName_<br>
```csharp
public class Person
```

##

**Field (Variabler):**<br>
:   Egenskaper som ska finnas med. <br>
_Privata variabler inleds med_ _ <br>
_Publika variabler inleds med stor bokstav._<br>
<ins>_Undvik publika variabler._</ins>

_Om ingen accessModifier skriv innan datatypen blir det private._
###### Syntax:
>_accessModifier datatyp namn;_<br>
```csharp
private int _age;
public int Age;
```

##

**Property (Get & Set):**<br>
:   Property är speciella metoder som används för att läsa/skriva skyddade variabler.<br>
Properties använder samma namn som den skyddade variabeln, dock med stor bokstav och utan _<br>
_get - Används för att läsa värdet i en privat variabel._<br>
_set - Används för att tilldela ett värde till en skyddad variabel._
###### Syntax:
>_public datatyp Namn {get; set;}_<br>
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

##

**Metoder:**<br>
:   Isolerad del av koden som kan anropas.<br>
Kan returnera värden och/eller utföra en funktion.
###### Syntax:
>_accessModifier metodTyp MetodNamn(){\};_
```csharp
public void PrintName()
{
    Console.WriteLine(_name);
}
```

##

**Konstruktor:**<br>
:   Metod för att skapa objekt utifrån klassen.<br>
Kan finnas flera i samma klass; med olika antal parametrar.
###### Syntax:
>_public ClassName(){\};_
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

##

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

##

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