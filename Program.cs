// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Public class telephone{
    string brand;
    int model;
    int price;

    public Telephone (string brand, int model, int price){
        this.brand = brand;
        this.model = model;
        this.price = price;
    }
    public string Getbrand(){
        return brand;
    }
        public string Getmodel(){
        return model;
    }
        public string Getprice(){
        return price;
    }
}

public class Magazine(){
    List<telephone> telephones;

    public Magazine(){
        this.telephones = new List<telephone>();
    }

    publik void addTelephone(Telephone telephone){
        telephones.Add(telephone);
    }

    public void showTelephones();
}

public class DNS{
    public static void Main()
    {
        telephone firstTelephone = new telephone("Apple", 2022, 100000);
        telephone firstTelephone = new telephone("Samsung", 2022, 90000);
        telephone firstTelephone = new telephone("Honnor", 2022, 13000);
        Magazine fisrstMagazine = new Magazine();
        firstPark.addtelephone(firstTelephone);
    }
} 