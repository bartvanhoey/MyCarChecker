# CarChecker Set-By-Step

1. Create a new Blazor Webassembly app

`dotnet new blazorwasm -au Individual -ho -n CarChecker`

2. Update class ApplicationUser in Server project

```csharp {
   public class ApplicationUser : IdentityUser
   {
      public string FirstName { get; set; }

      public string LastName { get; set; }
    }
}
