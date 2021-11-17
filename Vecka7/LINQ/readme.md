# LINQ - Language Integrated Query

## Vad är LINQ?

LINQ är en funktion i C# / .NET som gör det möjligt att hämta data genom att skriva queries mot en databas, lista eller annan samling av data.<br>

#

## Vad är en query?

Query är en samling av instruktioner som beskriver vilken data som ska hämtas från en angiven datakälla. Den beskriver även hur datan som returneras ska se ut; t.ex. sortering och/eller gruppering.

#

## Programbibliotek

För att kunna använda LINQ behöver vi lägga till programbiblioteket i vår kod.<br>

Det gör vi genom att längst upp i den aktuella filen lägga till:
```csharp
using System.Linq;
```

#

## IEnumerable

Datan som returneras med hjälp av LINQ lagras med hjälp av något som kallas IEnumerable.<br>
IEnumerable är ett interface som används för att iterera elementen i en samling.

---

# Olika typer av syntax

Det finns två olika syntaxer för hur man använder LINQ.<br>

**Lambda Syntax** - En kortare, mer komprimerad syntax.<br>
**Query Syntax** - Tydligare, och mer utförlig syntax. Väldigt likt SQL.

#

## Lambda

Lambda syntaxen är en kortare och mer komprimerad syntax.<br>
Den använder sig, som namnet antyder, av lambda uttryck.

### Exempel på syntax
```csharp
[datakälla].Where([namn] => [namn].[värde] [logiskt uttryck] []);
```

### Exempel - Namn med längd över 4
```csharp
string[] names = {"Jim", "Arasto", "Alexis", "Leo", "Carl"};

var results = names.Where(name => name.Length > 4);

foreach(string name in results)
{
    Console.WriteLine(name);
}
```
**Output:**<br>
Arasto<br>
Alexis

---

## Query syntax

Query syntaxen är en längre och mer tydlig syntax.<br>
Den är väldigt lik syntaxen för SQL.

### Exempel på syntax
```csharp
from [namn] in [datakälla] where [logiskt uttryck] select [namn];
```

### Exempel - Namn med längd över 4
```csharp
string[] names = {"Jim", "Arasto", "Alexis", "Leo", "Carl"};

var results = from name in names where name.Length > 4 select name;

foreach(string name in results)
{
    Console.WriteLine(name);
}
```

**Output:**<br>
Arasto<br>
Alexis

---

# Exempel - Utan LINQ vs med LINQ

## Skriv ut alla namn som börjar med A

### Utan LINQ
```csharp
List<string> names = new List<string> { "Jim", "Leo", "Arasto", "Alexis", "Eva" };
List<string> initialA = new List<string>();

foreach (string name in names)
{
    if (name.StartsWith('A'))
    {
        initialA.Add(name);
    }
}

foreach (string name in initialA)
{
    Console.WriteLine(name);
}
```

#

### Med LINQ - Query syntax
```csharp
List<string> names = new List<string> { "Jim", "Leo", "Arasto", "Alexis", "Eva" };

var initialA = from name in names where name.StartsWith('A') select name;

foreach (string name in initialA)
{
    Console.WriteLine(name);
}
```

#

### Med LINQ - Lamdba syntax
```csharp
List<string> names = new List<string> { "Jim", "Leo", "Arasto", "Alexis", "Eva" };

var initialA = names.Where(name => name.StartsWith('A'));

foreach (string name in initialA)
{
    Console.WriteLine(name);
}
```

---

# Några användbara funktioner i LINQ

## Where
Returnerar element som uppfyller ett angivet villkor

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 35),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

var studentsByAge = students.Where(x => x.age > 30);

foreach (Student s in studentsByAge)
{
    Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
}
```
**Output:**<br>
Age: 32 Name: Jim Kaya<br>
Age: 34 Name: Alexis Flach<br>
Age: 35 Name: Leo Möller<br>

#

## OrderBy
Sorterar element enligt ett angivet villkor, stigande ordning

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 34),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

var studentsByAge = students.OrderBy(x => x.age);

foreach (Student s in studentsByAge)
{
    Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
}
```
**Output:**<br>
Age: 26 Name: Carl Jendle<br>
Age: 28 Name: Arasto Sahbaei<br>
Age: 32 Name: Jim Kaya<br>
Age: 34 Name: Alexis Flach<br>
Age: 34 Name: Leo Möller<br>

#

## OrderByDescending
Sorterar element enligt ett angivet villkor, fallande ordning

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 34),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

var studentsByAge = students.OrderByDescending(x => x.age);

foreach (Student s in studentsByAge)
{
    Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
}
```
**Output:**<br>
Age: 34 Name: Alexis Flach<br>
Age: 34 Name: Leo Möller<br>
Age: 32 Name: Jim Kaya<br>
Age: 28 Name: Arasto Sahbaei<br>
Age: 26 Name: Carl Jendle<br>

#

## ThenBy
Sorterar element ytterligare en gång enligt ett angivet villkor, stigande ordning

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 34),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

// Sorterar först baserat på ålder, därefter baserat på efternamn.
var studentsByAge = students.OrderBy(x => x.age).ThenBy(x => x.lastName);

foreach (Student s in studentsByAge)
{
    Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
}
```
**Output:**<br>
Age: 26 Name: Carl Jendle<br>
Age: 28 Name: Arasto Sahbaei<br>
Age: 32 Name: Jim Kaya<br>
Age: 34 Name: Alexis Flach<br>
Age: 35 Name: Leo Möller<br>

#

## ThenByDescending
Sorterar element ytterligare en gång enligt ett angivet villkor, stigande ordning

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 34),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

// Sorterar först baserat på ålder, därefter baserat på efternamn.
var studentsByAge = students.OrderBy(x => x.age).ThenByDescending(x => x.lastname);

foreach (Student s in studentsByAge)
{
    Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
}
```
**Output:**<br>
Age: 26 Name: Carl Jendle<br>
Age: 28 Name: Arasto Sahbaei<br>
Age: 32 Name: Jim Kaya<br>
Age: 35 Name: Leo Möller<br>
Age: 34 Name: Alexis Flach<br>

#

## GroupBy
Grupperar element baserat på ett angivet villkor.

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 34),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

// Sorterar baserat på efternamn, grupperar därefter baserat på ålder.
var studentsByAge = students.OrderBy(x => x.lastName).GroupBy(x => x.age);

// Loopar igenom varje gruppering som skapats.
foreach (var group in studentsByAge)
{
    // Skriver ut värdet objekten grupperats på.
    Console.WriteLine(group.Key);

    // Loopar igenom varje objekt i aktuell gruppering.
    foreach (Student s in group)
    {
        Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
    }
}
```

**Output:**<br>
34<br>
Age: 34 Name: Alexis Flach<br>
Age: 34 Name: Leo Möller<br>
26<br>
Age: 26 Name: Carl Jendle<br>
32<br>
Age: 32 Name: Jim Kaya<br>
28<br>
Age: 28 Name: Arasto Sahbaei<br>

#

## Any
Returnerar en boolean som anger om något element i en samling av data uppfyller ett angivet villkor.

```csharp
List<Student> students = new List<Student>()
{
    new Student(firstName: "Jim", lastName: "Kaya", age: 32),
    new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
    new Student(firstName: "Alexis", lastName: "Flach", age: 34),
    new Student(firstName: "Leo", lastName: "Möller", age: 35),
    new Student(firstName: "Carl", lastName: "Jendle", age: 26),
};

var studentsOver30 = students.Where(x => x.age > 30).Any();

Console.WriteLine(studentsOver30);
```

**Output:**<br>
True

#

## Take
Returnerar ett angivet antal element i början av en samling

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

var takeNumbers = numbers.Take(5);

foreach (int number in takeNumbers)
{
    Console.WriteLine(number);
}
```
**Output:**<br>
1<br>
2<br>
3<br>
56<br>
23<br>

#

## Skip
Hoppar över ett angivet antal element i början av en samling och returnerar resterande

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

var skipNumbers = numbers.Skip(5);

foreach (int number in skipNumbers)
{
    Console.WriteLine(number);
}
```
**Output:**<br>
57<br>
76<br>
34

#

## First
Returnerar det första elementet
_Om inget värde finns så kastas ett exception._

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int firstNumber = numbers.First();

Console.WriteLine(firstNumber);
```
**Output:**<br>
1

#

## FirstOrDefault
Returnerar det första elementet
_Om inget värde finns returneras ett default värde._

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int firstNumber = numbers.First();

Console.WriteLine(firstNumber);
```
**Output:**<br>
1

#

## Last
Returnerar det sista elementet
_Om inget värde finns så kastas ett exception._

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int lastNumber = numbers.Last();

Console.WriteLine(lastNumber);
```
**Output:**<br>
34

#

## LastOrDefault
Returnerar det sista elementet
_Om inget värde finns returneras ett default värde._ 

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int lastNumber = numbers.LastOrDefault();

Console.WriteLine(lastNumber);
```
**Output:**<br>
34

#

## Max
Returnerar det största elementet

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int highestNumber = numbers.Max();

Console.WriteLine(highestNumber);
```
**Output:**<br>
76

#

## Min
Returnerar det minsta elementet

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int lowestNumber = numbers.Min();

Console.WriteLine(lowestNumber);
```
**Output:**<br>
1

#

## Sum
Returnerar summan av alla element

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

int sumOfNumbers = numbers.Sum();

Console.WriteLine(sumOfNumbers);
```
**Output:**<br>
252

#

## Average
Returnerar medelvärdet av alla element

```csharp
int[] numbers = {1, 2, 3, 56, 23, 57, 76, 34};

double averageOfNumbers = numbers.Average();

Console.WriteLine(averageOfNumbers);
```
**Output:**<br>
31.5

