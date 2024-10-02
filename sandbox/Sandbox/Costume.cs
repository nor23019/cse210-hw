class Costume
{
    //attributes (member variables)
    public string headWear;
    public string handWear;
    public string shoes;
    public string upperGarments;
    public string lowerGarments;
    public string accessory;


    //behaviors (member functions, or 'methods')
    public void ShowWardrobe(){
    string result = "";
    result += "Head gear: " + headWear;
    result += "\nHead gear: " + handWear;
    result += "\nHead gear: " + shoes;
    result += "\nHead gear: " + upperGarments;
    result += "\nHead gear: " + lowerGarments;
    result += "\nHead gear: " + accessory;
    Console.WriteLine(result + "\n");
    }
}