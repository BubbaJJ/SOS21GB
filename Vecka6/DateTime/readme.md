## DateTime

_DateTime_ - objekt som hjälper oss att hantera datum och tid.<br>

TimeSpan - Hjälpobjekt till DateTime som håller koll på tidspannet mellan två tidsperioder.<br>

##

###### Standard formattering
>_År-månad-datum timme:minut:sekund_<br>
**T.ex. 2021-11-12 13:02:57**

---

### Deklarera DateTime

###### Syntax
```csharp
DateTime variabelNamn = new DateTime(indata);
```

###### Exempel
```csharp
// 2021-12-24 00:00:00
DateTime xMas = new DateTime(2021, 12, 14); 

// 2009-08-05 07:35:00
DateTime dateJan = new DateTime(2009, 8, 5, 7, 35);
```

---

### DateTime.Now

_DateTime_ har även en inbyggd funktion som kan hämta aktuellt datum samt klockslag.<br>
Informationen hämtas från systemet, och baseras på den lokala tidszonen.<br>

###### Syntax
```csharp
DateTime.Now
```

###### Exempel (12 November 2021 kl: 13:02:57)
```csharp
DateTime today = DateTime.Now;
```
>**2021-11-12 13:02:57**

---

#### Filtrera DateTime

Med hjälp av DateTime.Now kan man även plocka ut specifik information.<br>
Detta funkar på både lagrade variabler och DateTime.Now


###### Exempel
```csharp
DateTime variabelNamn = new DateTime(2021,11,12,13,2,57):
```
>**Skapar ett DateTime objekt för 11 November 2021 kl 13:02:57**
```csharp
variabelNamn;
```
>**2021-11-12 13:02:57**
```csharp
variabelNamn.Date;
```
>**2021-11-12 00:00:00**
```csharp
variabelNamn.Year;
```
>**2021**
```csharp
variabelNamn.Month;
```
>**11**
```csharp
variabelNamn.Day;
```
>**12**
```csharp
variabelNamn.Hour;
```
>**13**
```csharp
variabelNamn.Minute;
```
>**2**
```csharp
variabelNamn.Second;
```
>**57**
```csharp
variabelNamn.DayOfYear;
```
>**316**
```csharp
variabelNamn.DayOfWeek;
```
>**Friday**
```csharp
variabelNamn.TimeOfDay;
```
>**13:02:57**

---

## Användbara metoder

### AddYears()

***Addera / subtrahera år***<br>
>_**Tar in en integer.**_<br>
>_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddYears(år);
```

##

###### Exempel
```csharp
variabelNamn.AddYears(7);
```
>**Adderar 7 år**<br>

```csharp
variabelNamn.AddYears(-7);
```
>**Subtraherar 7 år**<br>

---

## AddMonths()
***Addera / subtrahera månader***<br>
>_**Tar in en integer.**_<br>
_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddMonths(månader);
```

##

###### Exempel
```csharp
variabelNamn.AddMonths(7);
```
>**Adderar 7 månader**<br>

```csharp
variabelNamn.AddMonths(-7);
```
>**Subtraherar 7 månader**<br>

---

## AddDays()
***Addera / subtrahera dagar***<br>
>_**Tar in en double.**_<br>
_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddDays(dagar);
```

##

###### Exempel
```csharp
variabelNamn.AddDays(7);
```
>**Adderar 7 dagar**<br>
```csharp
variabelNamn.AddDays(4.5);
```
>**Adderar 4.5 dagar (4 dagar, 12 timmar)**<br>
```csharp
variabelNamn.AddDays(-7);
```
>**Subtraherar 7 dagar**<br>
```csharp
variabelNamn.AddDays(-4.5);
```
>**Subtraherar 4.5 dagar (4 dagar, 12 timmar)**<br>

---

## AddHours()
***Addera / subtrahera timmar***<br>
>_**Tar in en double.**_<br>
_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddHours(timmar);
```

##

###### Exempel
```csharp
variabelNamn.AddHours(7);
```
>**Adderar 7 timmar**<br>
```csharp
variabelNamn.AddHours(4.5);
```
>**Adderar 4.5 timmar  (4 timmar, 30 minuter)**<br>
```csharp
variabelNamn.AddHours(-7);
```
>**Subtraherar 7 timmar**<br>
```csharp
variabelNamn.AddHours(-4.5);
```
>**Subtraherar 4.5 timmar  (4 timmar, 30 minuter)**<br>

---

## AddMinutes()
***Addera / subtrahera minuter***<br>
>_**Tar in en double.**_<br>
_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddMinutes(minuter);
```

##

###### Exempel
```csharp
variabelNamn.AddMinutes(7);
```
>**Adderar 7 minuter**<br>
```csharp
variabelNamn.AddMinutes(4.5);
```
>**Adderar 4.5 minuter (4 minuter, 30 sekunder)**<br>
```csharp
variabelNamn.AddMinutes(-7);
```
>**Subtraherar 7 minuter**<br>
```csharp
variabelNamn.AddMinutes(-4.5);
```
>**Subtraherar 4.5 minuter (4 minuter, 30 sekunder)**<br>

---

## AddSeconds()
***Addera / subtrahera sekunder***<br>
>_**Tar in en double.**_<br>
_Värdet kan vara både positivt och negativt._<br>
_Ett positivt värde resulterar i att värdet adderas till objektet._<br>
_Ett negativt värde resulterar i att värdet subtraheras från objektet._

##

###### Syntax
```csharp
variabelNamn.AddSeconds(sekunder);
```

##

###### Exempel
```csharp
variabelNamn.AddSeconds(7);
```
>**Adderar 7 sekunder**<br>
```csharp
variabelNamn.AddSeconds(4.5);
```
>**Adderar 4.5 sekunder (4 sekunder, 500 millisekunder)**<br>
```csharp
variabelNamn.AddSeconds(-7);
```
>**Subtraherar 7 sekunder**<br>
```csharp
variabelNamn.AddSeconds(-4.5);
```
>**Subtraherar 4.5 sekunder (4 sekunder, 500 millisekunder)**<br>

---

## IsLeapYear()

**Returnerar en boolean som anger om ett år är ett skottår eller inte.**<br>
>_**Tar in en integer.**_<br>
>_Fungerar med lagrade variabler, DateTime.Now och integers_

## 

###### Syntax
```csharp
DateTime.IsLeapYear(årtal);
```

##

###### Exempel
```csharp
DateTime.IsLeapYear(2004);
```
>**Returnerar om 2004 är ett skottår**

```csharp
DateTime.IsLeapYear(variabelNamn.Year);
```
>**Returnerar om ett lagrat DateTime objekt är ett skottår**

```csharp
DateTime.IsLeapYear(DateTime.Now.Year);
```
>**Returnerar om det aktuella året är ett skottår**

---

## IsDayLightSavingTime
**Returnerar en boolean som anger om ett aktuellt datum är sommartid eller inte.**<br>

###### Syntax
```csharp
variabelNamn.IsDayLightSavingTime();
```

##

###### Exempel
```csharp
variabelNamn.IsDayLightSavingTime();
```
>**Returnerar om ett lagrat DateTime objekts datum är sommartid**

```csharp
DateTime.Now.IsDayLightSavingTime();
```
>**Returnerar om det aktuella datumet är sommartid**

---

## DaysInMonth()
**Returnerar antalet dagar i en månad som en integer, tar hänsyn till skottår.**
>_**Tar in två integers.**_<br>
>_Fungerar med lagrade variabler, DateTime.Now och integers_

##

###### Syntax
```chsarp
DateTime.DaysInMonth(årtal, månad);
```

##

###### Exempel
```csharp
DateTime.DaysInMonth(2004, 10);
```
>**Returnerar antal dagar i den angivna månaden**

```csharp
DateTime.DaysInMonth(variabelNamn.Year, variabelNamn.Month);
```
>**Returnerar antal dagar i ett lagrat DateTime Objekt**

```csharp
DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
```
>**Returnerar antal dagar i den aktuella månaden**

---

## Compare() / CompareTo()
**Jämför två DateTime objekt och returnerar en integer.**<br>
_Jämför hela vägen ner till millisekunder._

>***Möjliga returer***<br>
>
>|Värde  |Beskrivning                                                |
|:---   |:---                                                       |
|**-1** | Det första objektets tid är ***tidigare*** än det andra.|
|**0**  | Objekten är lika.                                         |
|**1**  | Det första objektets tid är ***senare*** än det andra.  |

##

###### Syntax
**Compare()**
```csharp
DateTime.Compare(DateTime, DateTime)
```
**CompareTo()**
```csharp
variabelNamn.CompareTo(DateTime);
```

##

###### Exempel
**Compare()**
```csharp
DateTime.Compare(variabelNamn, DateTime.Now);
```
>**Jämför ett lagrat DateTime objekt med den aktuella tiden**
```csharp
DateTime.Compare(variabelNamn, variabelNamn);
```
>**Jämför två lagrade DateTime objekt**

**CompareTo()**
```csharp
variabelNamn.CompareTo(DateTime.Now);
```
>**Jämför ett lagrat DateTime objekt med den aktuella tiden**

```csharp
variabelNamn.CompareTo(variabelNamn);
```
>**Jämför två lagrade DateTime objekt**
---

## ToString()
Metoden _ToString_ konverterar DateTime objekt till en textsträng, och hjälper till med formattering.<br>
_Eventuell formattering skrivs in som en textsträng._

##

###### Syntax
```csharp
variabelNamn.ToString(ev. formattering);
```

##

###### exempel
```csharp
DateTime variabelNamn = new DateTime(2021,1,12,13,2,57):
```
>**Skapar ett DateTime objekt för 12 Januari 2021 kl 13:02:57**

```csharp
variabelNamn.ToString("yyyy-MM-dd HH:mm");
```
>**2021-01-12 13:02**

```csharp
variabelNamn.ToString("yyyy-MM-dd");
```
>**2021-01-12**

```csharp
variabelNamn.ToString("HH:mm");
```
>**13:02**

```csharp
variabelNamn.ToString("yyMMdd");
```
>**210112**

```csharp
variabelNamn.ToString("dd MMMM yyyy");
```
>**12 januari 2021**

```csharp
variabelNamn.ToString("dddd");
```
>**tisdag**

```csharp
variabelNamn.ToString("dddd dd MMMM yyyy");
```
>**tisdag 12 januari 2021**

```csharp
variabelNamn.ToString("M");
```
>**12 januari**

```csharp
variabelNamn.ToString("D");
```
>**den 12 januari 2021**

---

### Sammanställning

|Kommando   |Resultat                       |Exempel 1      |Exempel 2      |
|:---       |:---                           |:---           |:---           |
|**d**      |Datum 1-31                     |1 januari = 1  |14 april = 14  |
|**dd**     |Datum 01-31                    |1 januari = 01 |14 april = 14  |
|**ddd**    |Veckodag - Förkortning         |Måndag = Mån   |Tisdag = Tis   |
|**dddd**   |Veckodag - Fullständig         |Måndag         |Tisdag         |
|**h**      |12-timmarsklocka - 1-2 siffror |14:00 = 2      |09.00 = 9      |
|**hh**     |12-timmarsklocka - 2 siffror   |14:00 = 02     |09.00 = 09     |
|**H**      |24-timmarsklocka - 1-2 siffror |14.00 = 14     |09.00 = 9      |
|**HH**     |24-timmarsklocka - 2 siffror   |14.00 = 14     |09.00 = 09     |
|**m**      |Minuter - 1-2 siffror          |09:01 = 1      |08:13 = 13     |
|**mm**     |Minuter - 2 siffror            |09:01 = 01     |08:13 = 13     |
|**M**      |Månad - 1-2 siffror            |Januari = 1    |November = 11  |
|**MM**     |Månad - 2 siffror              |Januari = 01   |November = 11  |
|**MMM**    |Månad - Förkortning            |Januari = Jan  |Mars = Mar     |
|**MMMM**   |Månad - Fullständig            |Januari        |Mars           |
|**s**      |Sekunder - 1-2 siffror         |13:57:01 = 1   |12:45:13 = 13  |
|**ss**     |Sekunder - 2 siffror           |13:57:01 = 01  |12:45:13 = 13  |
|**yyyy**   |Årtal - 4 siffror              |2001           |2015           |
|**yy**     |Årtal - 2 siffror              |2001 = 01      |2015 = 15      |       
