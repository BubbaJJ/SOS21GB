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
_Property behöver inte innehålla både get och set, det går att skapa med endast en av dessa._

_**Använd endast property om data behöver kunna nås utanför klassen.**_

<table>
    <thead>
        <tr>
            <th colspan=2>Accessor</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><b><i>get</td>
            <td>Används för att läsa värdet i en skyddad variabel.</td>
        </tr>
        <tr>
            <td><b><i>set</td>
            <td>Används för att tilldela ett värde till en skyddad variabel.</td>
        </tr>
        <tr>
            <td><b><i>value</td>
            <td>Används för det värde som skickas med till set.</td>
        </tr>
        <tr>
            <th colspan=2>Extra</th>
        </tr>
        <tr>
            <td><b><i>init</td>
            <td>Begränsar så att tilldelning av ett field endast kan ske vid objektets skapande.<br> 
                <i>Används istället för set.</td>
        </tr>
    </tbody>
</table>


###### Syntax
```csharp
accessModifier datatyp Namn {get {return field;} set {field = value;} }
```

##

###### Exempel - get & set
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

###### Exempel - get & init
```csharp
public int Age
{
        get
        {
            return _age;
        }
        init
        {
            _age = value;
        }
}
```

---

#### Auto-implemented Property
Automatic property är ett kortare sätt att skriva sina properties.<br>
Vid användning av automatic properties så behövs inte skyddade fields för samma värde.<br>

_Kan innehålla get **och/eller** set._

###### Syntax
```csharp
accessModifier datatyp Namn {get; set;}
```

##

###### Exempel
```csharp
public int Age {get; set;}
public string Name {get;}
public string Location {get; init;}
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
Samtliga konstruktorer behöver ha samma namn som klassen.<br>


###### Syntax
```csharp
accessModifier KlassNamn(ev. parametrar){}
```

##

###### Exempel
```csharp
// Tom konstruktor
// Skapar ett tomt objekt.
public Person()
{
}

// Konstruktor med två parametrar
// Tilldelar två fields
public Person(string name, int age)
{
    this._name = name;
    this._age = age;
}
```

##

#### This

Ordet **this** används för att peka på det specifika objektet.<br>
I konstruktorn möjliggör detta att field och parameter kan ha samma namn.<br>
_**this** hjälper konstruktorn att skilja på värdena._<br>

###### Exempel - Med 'this'
```csharp
public Person(string name)
{
    this.name = name;
    // this.name  = Objektets name
    // name       = Parametern name 
}
```

###### Exempel - Utan 'this'
```csharp
public Person(string name)
{
    name = name;        
    // Konstruktorn kan inte skilja på värdena.
    // Genererar ett felmeddelande.
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
Dvs. det går inte att skapa objekt av klassen.<br>
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
    protected int _age;
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

## Arv
Arv gör så att vi kan skapa klasser som ärver fields och metoder från en annan klass.<br>
Dvs. vi kan utgå från en befintlig grund och bygga vidare på den.<br>

_Basklass - Klassen vi ärver ifrån._<br>
_Subklass - Den klass som ärver._

##

###### Access modifiers

När arv används är det viktigt att tänka på hur man deklarerar sina fields.<br>
Vill man hantera nå fields i subklasser behöver alltså tänka på tillgängligheten.<br>
_T.ex. private fields ärvs till subklasser, men går inte att hantera i klassen._

| Access modifier       | Tillgänglighet                                        |
| :---                  | :---                                                  |
| **public**            | Överallt                                              |
| **internal**          | Överallt, i samma projekt                             |
| **private**           | Egna klassen                                          |
| **protected**         | Egna klassen samt klasser som ärver, oavsett projekt  |
| **protected private** | Egna klassen samt klasser som ärver, i samma projekt  |

##

###### Implementering

För att implementera arv så används **:** mellan klassnamnen.

###### Syntax
```csharp
class Subklass : Basklass
{
}
```

##

###### Konstruktor
Konstruktorer i subklasser skrivs olika beroende på hur basklassen är uppbyggd.<br>

###### Exempel
>**Ingen eller tom konstruktor i basklassen:**<br>
>Samtliga parametrar som skickas med hanteras av subklassens konstruktor.
>
>```csharp
>public Klassnamn(ev. parametrar)
>{
>}
>```

>**Konstruktor med parametrar i basklassen:**<br>
>Parametrar som är unika för subklassen hanteras av subklassens konstruktor.<br>
>Övriga skickas vidare till basklassens konstruktor för tilldelning.<br>
>**: base** används för att anropa basklassens konstruktor.<br>
>
>_Samtliga parametrar skrivs in i den första parentesen._<br>
>_Parametrar som ska till basklassens konstruktor skrivs igen i den andra parentesen._<br>
>
>```csharp
>public Klassnamn(ev. parametrar) : base (parametrar till basklassens konstruktor)
>{
>}
>```

##

###### Exempel - Basklass
```csharp
class Basklass
{
    // Fields som ärvs till subklasser.
    protected int _field1;
    protected string _field2;

    // Konstruktor för basklassen.
    public Basklass(int field1, string field2)
    {
        this._field1 = field1;
        this._field2 = field2;
    }
}
```

##

###### Exempel - Subklass
```csharp
class Subklass : Basklass
{
    // Fields som tillkommer i Subklass.
    private int _field3;
    private string _field4;

    // Konstruktor för subklassen.
    // Tar in samtliga parametrar som krävs.
    // Subklassens konstruktor sköter tilldelning av värden som är unika för subklassen.
    // field1 & field2 skickas vidare till basklassens konstruktor som sköter tilldelning.
    public Subklass(int field1, string field2, int field3, string field4) : base(field1, field2)
    {
        this._field3 = field3;
        this._field4 = field4;
    }
}
```

##

#### Exempel - Person och Student

###### Person.cs
```csharp
class Person
{
    // Fields som ärvs
    protected string _firstName;
    protected string _lastName;

    // Konstruktor för Person    
    public Person(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }
}
```

##

###### Student.cs
```csharp
class Student : Person
{
    // Fields som tillkommer för Student
    private int _studentId;
    
    // Konstruktor för Student
    // firstName och lastName skickas vidare till konstruktor för Person
    public Student(string firstName, string lastName, int studentId) : base (firstName, lastName)
    {
        this._studentId = studentId;
    }
}
```

##

###### Program.cs
```csharp
static void Main(string[] args)
{
    Person person01 = new Person("Jim", "Kaya");

    Student student01 = new Student("Leo","Möller", 1);
}
```

##

###### Resultat
<table>
    <thead>
        <tr>
            <th colspan=2>person01</th>
            <th colspan=2>student01</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><b>_firstName</td>
            <td>Jim</td>
            <td><b>_firstName</td>
            <td>Leo</td>
        </tr>
        <tr>
            <td><b>_lastName</td>
            <td>Kaya</td>
            <td><b>_lastName</td>
            <td>Möller</td>
        </tr>
        <tr>
            <td colspan=2></td>
            <td><b>_studentId</td>
            <td>1</td>
        </tr>
    </tbody>
</table>

---