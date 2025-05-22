//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza.Describe());

//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce()
};

foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}



public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => 
        $"This is pizza with {string.Join(", ", _ingredients)}";
}



public class Ingredient
{
    public virtual string Name { get; } = "some ingredient";
    public string PublicMethod() => "This is Public in the ingredient class";

    protected string ProtectedMethod() => "This is Protected in the ingredient class";

    private string PrivateMethod() => "This is Private in the ingredient class";
}

public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public override string Name => "Cheddar cheese";
    public bool IsLight { get; }
}