## Objekt

### Skapa objekt

###### Syntax:
>KlassNamn objektNamn = new KlassNamn();
```csharp
BankAccount account = new BankAccount();    // Utan parametrar

BankAccount account = new BankAccount(123); // Med parametrar
```

##

### Anv�nda metoder i objekt

###### Syntax:
>objektNamn.MetodNamn();
```csharp
account.ShowBalance();
```

##

### L�sa v�rden i objekt

###### Syntax:
>objektNamn.Property;
```csharp
account.AccountHolderId;
```

##

### Skriva v�rden till objekt

###### Syntax:
>objektNamn.Property = v�rde;
```csharp
account.AccountHolderId = 1234;
```
