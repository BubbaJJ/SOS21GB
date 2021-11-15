## Stränghantering

### ToUpper()
Konverterar samtliga tecken i en textsträng till stora bokstäver.

##

###### Syntax
```csharp
variabelNamn.ToUpper();
```

##

###### Exempel
```csharp
string str = "Handelsakademin";

str = str.ToUpper();

Console.WriteLine(str);
```
**Output:** <br>
HANDELSAKADEMIN

---

### ToLower()
Konverterar samtliga tecken i en textsträng till små bokstäver.
##

###### Syntax
```csharp
variabelNamn.ToLower();
```

##

###### Exempel
```csharp
string str = "Handelsakademin";

str = str.ToLower();

Console.WriteLine(str);
```
**Output:** <br>
handelsakademin

---
### Trim()
Tar bort alla mellanrum, eller angivet/angivna tecken, i början och slutet av en textsträng.
>***Kan ta in en character eller en array av characters.***
##

###### Syntax
```csharp
variabelNamn.Trim(ev. indata);
```

##

###### Exempel
```csharp
string str = "   Handelsakademin   ";

str = str.Trim();

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademin

##

```csharp
string str = "   Handelsakademin";

str = str.Trim('n');

Console.WriteLine(str);
```
**Output:** <br>
&nbsp; &nbsp;Handelsakademi

##

```csharp
string str = "   Handelsakademin";

str = str.Trim(new char[]{' ', 'H', 'n'});

Console.WriteLine(str);
```
**Output:** <br>
andelsakademi

##

```csharp
string str = "   Handelsakademin";

char[] charsToTrim = {' ', 'n'};

str = str.Trim(charsToTrim);

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademi

##

#### TrimStart()
Tar bort alla mellanrum, eller angivet/angivna tecken, i början av en textsträng.
>***Kan ta in en character eller en array av characters.***
##

###### Syntax
```csharp
variabelNamn.TrimStart(ev. indata);
```

##

###### Exempel
```csharp
string str = "   Handelsakademin   ";

str = str.TrimStart();

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademin &nbsp;&nbsp;

##

```csharp
string str = "   Handelsakademin";

str = str.TrimStart('n');

Console.WriteLine(str);
```
**Output:** <br>
&nbsp; &nbsp;Handelsakademin

##

```csharp
string str = "   Handelsakademin";

str = str.TrimStart(new char[]{' ', 'H', 'n'});

Console.WriteLine(str);
```
**Output:** <br>
andelsakademin

##

```csharp
string str = "   Handelsakademin";

char[] charsToTrim = {' ', 'n'};

str = str.TrimStart(charsToTrim);

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademin

##

#### TrimEnd()
Tar bort alla mellanrum, eller angivet/angivna tecken, i början och slutet av en textsträng.
>***Kan ta in en character eller en array av characters.***
##

###### Syntax
```csharp
variabelNamn.TrimEnd(ev. indata);
```

##

###### Exempel
```csharp
string str = "   Handelsakademin   ";

str = str.TrimEnd();

Console.WriteLine(str);
```
**Output:** <br>
&nbsp; &nbsp;Handelsakademin

##

```csharp
string str = "   Handelsakademin";

str = str.TrimEnd('n');

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademi

##

```csharp
string str = "   Handelsakademin   ";

str = str.TrimEnd(new char[]{' ', 'H', 'n'});

Console.WriteLine(str);
```
**Output:** <br>
Handelsakademi

##

```csharp
string str = "   Handelsakademin";

char[] charsToTrim = {' ', 'n'};

str = str.TrimEnd(charsToTrim);

Console.WriteLine(str);
```
**Output:** <br>
&nbsp; &nbsp;Handelsakademi

---

### Substring()
Returnerar en del av en textsträng.<br>
>***Tar in en eller två integers.***<br>
>_Det första värdet anger startindex._<br>
>_Det andra värdet anger antal tecken som ska returneras._<br>

>_Om inget andra värde anges returneras resterande del av textsträngen._<br>
>_Om startindex är samma som längden på textsträngen returneras en tom textsträng._

##

###### Syntax
```csharp
varibelNamn.Substring(startIndex, ev antal);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str = str.Substring(3);

Console.WriteLine(str);
```
**Output:**<br>
21GB

##

```csharp
string str = "SOS21GB";

str = str.Substring(3, 2);

Console.WriteLine(str);
```
**Output:**<br>
21

##

```csharp
string str = "SOS21GB";

str = str.Substring(7);

Console.WriteLine(str);
```
**Output:**<br>
<br>

---

### ToCharArray()
Konverterar hela, eller delar av, textsträngen till en array av characters.<br>
>***Kan ta in två integers.***
##

###### Syntax
```csharp
variabelNamn.ToCharArray(startIndex, antalTecken);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

char[] charArr = str.ToCharArray();

foreach(char c in charArr)
{
    Console.WriteLine(c);
}
```
**Output:**<br>
S<br>
O<br>
S<br>
2<br>
1<br>
G<br>
B

##

```csharp
string str = "SOS21GB";

char[] charArr = str.ToCharArray(2, 3);

foreach(char c in charArr)
{
    Console.WriteLine(c);
}
```
**Output:**<br>
S<br>
2<br>
1

---

### Split()
Delar upp en textsträng i flera strängar och returnerar en array.<br>
Delningen sker vid varje mellanslag, eller angivet/angivna tecken.<br>
_Tecken som används för att dela textsträngen raderas från textsträngen._
>***Kan, bland annat, ta in en char eller en array av chars.***
##

###### Syntax
```csharp
variabelNamn.Split(ev. indata);
```

##

###### Exempel
```csharp
string str = "Välkommen till Handelsakademin.";

string[] strs = str.Split();

foreach(string s in strs)
{
    Console.WriteLine(s);
}
```
**Output:** <br>
Välkommen<br>
till<br>
Handelsakademin.

##

```csharp
string str = "Välkommen till Handelsakademin.";

string[] strs = str.Split('l');

foreach(string s in strs)
{
    Console.WriteLine(s);
}
```
**Output:** <br>
Vä<br>
kommen ti<br>
<br>
&nbsp;Hande<br>
sakademin.

##

```csharp
string str = "Välkommen till Handelsakademin.";

char[] charsToSplit = {' ', 'l'};

string[] strs = str.Split(charsToSplit);

foreach(string s in strs)
{
    Console.WriteLine(s);
}
```
**Output:** <br>
Vä<br>
kommen<br>
ti<br>
<br>
<br>
Hande<br>
sakademin.

---

### PadLeft()
Adderar mellanslag, eller ett angivet tecken, i början av en textsträng.<br>
>***Tar in en integer och eventuellt tecken som ska användas.***<br>
>_Integern anger den totala längden, padding + befintlig textsträng._<br>
>_Om inget tecken anges så används mellanslag._<br>
>_Om längden är mindre, eller lika med, längden på den befintliga textsträngen kommer inget att adderas._

##

###### Syntax
```csharp
variabelNamn.PadLeft(antal, ev tecken);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str = str.PadLeft(9);

Console.WriteLine(str);
```
**Output:**<br>
&nbsp; SOS21GB

##

```csharp
string str = "SOS21GB";

str = str.PadLeft(10, '.');

Console.WriteLine(str);
```
**Output:**<br>
...SOS21GB

##

```csharp
string str = "SOS21GB";

str = str.PadLeft(7, '.');

Console.WriteLine(str);
```
**Output:**<br>
SOS21GB

---

### PadRight()
Adderar mellanslag, eller ett angivet tecken, i slutet av en textsträng.<br>
>***Tar in en integer och eventuellt tecken som ska användas.***<br>
>_Integern anger den totala längden, padding + befintlig textsträng._<br>
>_Om inget tecken anges så används mellanslag._<br>
>_Om längden är mindre, eller lika med, längden på den befintliga textsträngen kommer inget att adderas._

##

###### Syntax
```csharp
variabelNamn.PadRight(antal, ev tecken);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str = str.PadLeft(9);

Console.WriteLine(str);
```
**Output:**<br>
SOS21GB &nbsp;

##

```csharp
string str = "SOS21GB";

str = str.PadLeft(10, '.');

Console.WriteLine(str);
```
**Output:**<br>
SOS21GB...

##

```csharp
string str = "SOS21GB";

str = str.PadLeft(7, '.');

Console.WriteLine(str);
```
**Output:**<br>
SOS21GB

---

### Replace()
Ersätter delar av en textsträng med angivet tecken/textsträng.<br>
>***Tar in två characters eller två strings.***<br>
>_Det första värdet anger vad som ska ersättas._<br>
>_Det andra värdet anger vad det ska ersättas med._

##

###### Syntax
```csharp
variabelNamn.Replace(värde, värde);
```

##

###### Exempel
```csharp
string str = "1 2 3 4 5";

str = str.Replace(' ', ',');

Console.WriteLine(str);
```
**Output:**<br>
1,2,3,4,5

##

```csharp
string str = "SOS21GB";

str = str.Replace("21", "22");

Console.WriteLine(str);
```
**Output:**<br>
SOS21GB

---

### Remove()
Raderar en del av textsträngen.<br>
>***Tar in en eller två integers.***<br>
>_Första värdet anger startindex._<br>
>_Det andra värdet anger hur många tecken som ska raderas._<br>
>_Om inget andra värde anges så tas resterande del av textsträngen bort._
##

###### Syntax
```csharp
variabelNamn.Remove(startIndex, ev antal);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str = str.Remove(3);

Console.WriteLine(str);
```
**Output:**<br>
SOS

##

```csharp
string str = "SOS21GB";

str = str.Remove(1, 2);

Console.WriteLine(str);
```
**Output:**<br>
S21GB

---

### StartsWith()
Returnerar en boolean som anger om en textsträng börjar med ett angivet värde.<br>
>***Tar in en character eller string.***
##

###### Syntax
```csharp
variabelNamn.StartsWith(värde);
```

##

###### Exempel
```csharp
string str = "Handelsakademin";

str.StartsWith('H');
```
**Returnerar true**

##

```csharp
string str = "Handelsakademin";

str.StartsWith('G');
```
**Returnerar false**

##

```csharp
string str = "Handelsakademin";

str.StartsWith("Handel");
```
**Returnerar true**

##

```csharp
string str = "Handelsakademin";

str.StartsWith("Akademi");
```
**Returnerar false**

---

### EndsWith()
Returnerar en boolean som anger om en textsträng avslutas med ett angivet värde.<br>
>***Tar in en character eller string.***
##

###### Syntax
```csharp
variabelNamn.EndsWith(värde);
```

##

###### Exempel
```csharp
string str = "Handelsakademin";

str.EndsWith('n');
```
**Returnerar true**

##

```csharp
string str = "Handelsakademin";

str.EndsWith('G');
```
**Returnerar false**

##

```csharp
string str = "Handelsakademin";

str.EndsWith('akademin');
```
**Returnerar true**

##

```csharp
string str = "Handelsakademin";

str.EndsWith("Akademi");
```
**Returnerar false**

---

### IsNullOrEmpty()
Returnerar en boolean som anger om en textsträng är tom eller null.<br>
_**null** innebär att textsträngen inte ännu har tilldelats ett värde, alternativt blivit tilldelad värdet null._
##

###### Syntax
```csharp
String.IsNullOrEmpty(variabelNamn);
```

##

###### Exempel
```csharp
string str = "";

Console.WriteLine(String.IsNullOrEmpty(str));
```
**Returnerar true**

##

```csharp
string str = null;

Console.WriteLine(String.IsNullOrEmpty(str));
```
**Returnerar true**

##

```csharp
string str = " ";

Console.WriteLine(String.IsNullOrEmpty(str));
```
**Returnerar false**

##

```csharp
string str = "SOS21GB";

Console.WriteLine(String.IsNullOrEmpty(str));
```
**Returnerar false**

---

### IsNullOrWhiteSpace()
Returnerar en boolean som anger om en textsträng är tom, null eller består av endast mellanslag.<br>
##

###### Syntax
```csharp
String.IsNullOrWhiteSpace(variabelNamn);
```

##

###### Exempel
```csharp
string str = null;

Console.WriteLine(String.IsNullOrWhiteSpace(str));
```
**Returnerar true**

##

```csharp
string str = " ";

Console.WriteLine(String.IsNullOrWhiteSpace(str));
```
**Returnerar true**

##

```csharp
string str = "    ";

Console.WriteLine(String.IsNullOrWhiteSpace(str));
```
**Returnerar true**

##

```csharp
string str = "";

Console.WriteLine(String.IsNullOrWhiteSpace(str));
```
**Returnerar true**

##

```csharp
string str = "SOS21GB";

Console.WriteLine(String.IsNullOrWhiteSpace(str));
```
**Returnerar false**

---

### Insert()
Adderar en textsträng i en befintlig textsträng vid ett angivet index.<br>
>***Tar in en integer och en string.***
##

###### Syntax
```csharp
variabelNamnInsert(startIndex, värde);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str = str.Insert(2, "aaa");

Console.WriteLine(str);
```
**Output:**<br>
SOaaaS21GB

##

```csharp
string str = "SOS21GB";

str = str.Insert(3, " ");

Console.WriteLine(str);
```
**Output:**<br>
SOS 21GB

---

### Contains
Returnerar en boolean som anger om en textsträng innehåller ett angivet värde.<br>
>***Tar in en character eller en integer.***
##

###### Syntax
```csharp
variabelNamn.Contains(värde);
```

##

###### Exempel
```csharp
string str = "SOS21GB";

str.Contains('O');
```
**Returnerar true**

##

```csharp
string str = "SOS21GB";

str.Contains('w');
```
**Returnerar false**

##

```csharp
string str = "SOS21GB";

str.Contains("21");
```
**Returnerar true**

##

```csharp
string str = "SOS21GB";

str.Contains("21S");
```
**Returnerar false**

---

### Equals()
Jämför två textsträngar.<br>
>***Tar in en eller två textsträngar.***
##

###### Syntax
```csharp
variabelNamn.Equals(variabelNamn);

String.Equals(variabelNamn, variabelNamn);
```

##

###### Exempel
```csharp
string str = "SOS21GB";
string str2 = "SOS21GB";

str.Equals(str2);
```
**Returnerar true**

##

```csharp
string str = "SOS21GB";
string str2 = "SOS22GB";

str.Equals(str2);
```
**Returnerar false**

##

```csharp
string str = "SOS21GB";
string str2 = "SOS21GB";

String.Equals(str, str2);
```
**Returnerar true**

##

```csharp
string str = "SOS21GB";
string str2 = "SOS22GB";

String.Equals(str, str2);
```
**Returnerar false**

---