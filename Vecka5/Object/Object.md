## Objekt

### Skapa objekt

###### Syntax:
>KlassNamn objektNamn = new KlassNamn();
```csharp
BankAccount account = new BankAccount();    // Utan parametrar

BankAccount account = new BankAccount(123); // Med parametrar
```

##

### Använda metoder i objekt

###### Syntax:
>objektNamn.MetodNamn();
```csharp
account.ShowBalance();
```

##

### Läsa värden i objekt

###### Syntax:
>objektNamn.Property;
```csharp
account.AccountHolderId;
```

##

### Skriva värden till objekt

###### Syntax:
>objektNamn.Property = värde;
```csharp
account.AccountHolderId = 1234;
```
