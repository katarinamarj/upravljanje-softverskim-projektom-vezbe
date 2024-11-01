using Ardalis.SmartEnum;
using MongoDB.Driver.Core.Operations;

namespace USP.Domain.Enums;

public abstract class Category(string name, int value) : SmartEnum<Category>(name,value)

{
    
    public abstract string NameOfCategory { get;  }
    public abstract string DescriptionOfCategory { get; }
    
    public static Category Sport = new SportCategory();
    public static Category Muzika = new MuzikaCategory();


    public abstract string CheckSubcategories();
    
    private class SportCategory() : Category(nameof(Sport), 0)
    {
        public override string NameOfCategory => "Sport";
        public override string DescriptionOfCategory => "Opis";
        public override string CheckSubcategories()
        {
            throw new NotImplementedException();
        }
    }
    private class MuzikaCategory() : Category(nameof(Muzika), 0)
    {
        public override string NameOfCategory => "Muzika";
        public override string DescriptionOfCategory => "Opis";
        public override string CheckSubcategories()
        {
            throw new NotImplementedException();
        }
    }



}