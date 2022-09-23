public class Inventory {
    private Guitar[] guitars;

    public Inventory(Guitar[] guitars){
        this.guitars = guitars;
    }

    public Guitar GetGuitar(string serialNumber){
        foreach(Guitar guitar in this.guitars){
            if(guitar.GetSerialNumber().Equals(serialNumber)){
                return guitar;
            }
        }
        return null;
    }
    public Guitar GetGuitar(double Price){
            foreach(Guitar guitar in this.guitars){
            if(guitar.GetPrice().Equals(Price)){
                return guitar;
            }
        }
        return null;
    }
    public Guitar Search(Guitar searchGuitar){
        foreach (Guitar guitar in this.guitars){
        string serialNumber = searchGuitar.GetSerialNumber();
        double Price = searchGuitar.GetPrice();

        if (guitar.GetSerialNumber().Equals(serialNumber)&&guitar.GetPrice().Equals(Price)){
            return guitar;
        }
        }
        return null;
    }
}