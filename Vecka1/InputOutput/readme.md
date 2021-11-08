### Input & Output

### Input 

**Console.Read();**<br>
_Läser in ett tecken, konverterar till ASCII._

**Console.ReadKey();**<br>
_Läser in nästkommande knapptryck._

**Console.ReadLine();**<br>
_Läser in en textsträng._<br>
_Fortsätter läsa in tills att användaren trycker på ENTER_


#### Exempel: Input
```csharp
int x = Console.Read();
```
_Läser in ett tecken, konverterar till ASCII och tilldelar värdet till variabel x_
```csharp
ConsoleKeyInfo key = Console.ReadKey();
```
_Läser in nästkommande knapptryck, tilldelar värdet till variabel key_
```csharp
string name = Console.ReadLine();
```
_Läser in en textsträng, tilldelar värdet till variabel name_

----

### Konvertering av input

**Convert.ToInt32();**<br>
_Konverterar till int._

**Convert.ToDouble();**<br>
_Konverterar till double._

**Convert.ToDecimal();**<br>
_Konverterar till decimal_

**Convert.ToChar();**<br>
_Konverterar till char._

#### Exempel: Konvertering av input
```csharp
Convert.ToInt32(Console.ReadLine());
```
_Konverterar inmatning från användaren till int._
```csharp
int nameInt = Convert.ToInt32(name);

int inputInt = Convert.ToInt32(Console.ReadLine());
```

_Konverterar till int, och tilldelar._
```csharp
Convert.ToDouble(name);
```

_Konverterar en variabel till double._
```csharp
Convert.ToDouble(Console.ReadLine());
```
_Konverterar inmatning från användaren till double._
```csharp
double nameDouble = Convert.ToDouble(name);

double inputDouble = Convert.ToDouble(Console.ReadLine());
```
_Konverterar till int, och tilldelar._

---

### Output

**Console.Write();**<br>
_Skriver ut i konsolen; utan radbrytning efter._

**Console.WriteLine();**<br>
_Skriver ut i konsolen; med radbrytning efter._

#### Exempel: Output
```csharp
Console.Write("Hej");
```
_Skriver ut Hej i konsolen; utan radbrytning efter._
```csharp
Console.WriteLine("Hej");
```
_Skriver ut Hej i konsolen; med radbrytning efter._
```csharp
Console.Write(name);
```
_Skriver ut ett lagrat värde i konsolen; utan radbrytning efter._
```csharp
Console.WriteLine(name);
```
_Skriver ut ett lagrat värde i konsolen; med radbrytning efter._

----

### Formattering av output

**Console.Write("{0} {1} {2}", 0, 1, 2);**<br>
_Index enligt ordningen inom parentesen._


#### Exempel: Formattering av output

```csharp
Console.WriteLine("{0} {1} {2}",name, nameInt, inputDouble);
```
0 = Värde lagrat i variabeln name<br>
1 = Värde lagrat i variabeln nameInt<br>
2 = Värde lagrat i variabeln inputDouble<br>
**Output:** name nameInt InputDouble
```csharp
Console.WriteLine("{1} {2} {0}", name, nameInt, inputDouble);
```
0 = name<br>
1 = nameInt <br>
2 = inputDouble<br>
**Output:** nameInt inputDouble name
```csharp
Console.WriteLine("Namn:{0} Ålder:{1}", "Kalle", 32);
```
Index 0 = Kalle<br>
index 1 = 32<br>
**Output:** Namn:Kalle Ålder:32
