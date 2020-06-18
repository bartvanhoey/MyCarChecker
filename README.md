# CarChecker

## Create a new Blazor Webassembly app

`dotnet new blazorwasm -au Individual -ho -n CarChecker`

## Update class ApplicationUser in Server project

```csharp {
   public class ApplicationUser : IdentityUser
   {
      public string FirstName { get; set; }

      public string LastName { get; set; }
    }
}
