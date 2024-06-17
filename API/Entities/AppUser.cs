namespace API.Entities;

public class AppUser{

    public int Id {get; set;}

    //in C# all strings by default are optional, if you want them to be required then you have to explicitly tell it
    //Disables Nullable in csproj settings otherwise we get warnings
    public string UserName {get; set;}

}