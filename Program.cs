class Program {
    public static void Main(string[] args){
        Inventory inventory = new Inventory(initializeInventory());
        Guitar guitar = new Guitar("000004",8254.52,"Ning","Stratocaster","Alder");
        Guitar searchGuitar = inventory.Search(guitar);

        if (searchGuitar != null){
            PrintGuitarInformation(guitar);
        } else {
            Console.WriteLine("Sorry not Found!");
        }
    }
    public static void PrintGuitarInformation(Guitar guitar){
        Console.WriteLine("*****************");
        Console.WriteLine("Guitar serial number: {0}",guitar.GetSerialNumber());
        Console.WriteLine("Guitar price: {0}",guitar.GetPrice());
        Console.WriteLine("Guitar Builder: {0}",guitar.GetBuilder());
        Console.WriteLine("Guitar Model : {0}",guitar.GetModel());
        Console.WriteLine("Guitar Wood : {0}",guitar.GetWood());
    }
        public static Guitar[] initializeInventory() {
        Guitar[] guitars = {new Guitar("000001",5000.52,"Nhong","Stratocaster","Alder"),
        new Guitar("000002",7412.52,"Jame","Stratocaster","Alder"),
        new Guitar("000003",3917.52,"Jo","Stratocaster","Alder"),
        new Guitar("000004",8254.52,"Ning","Stratocaster","Alder"),
        new Guitar("000005",1234.52,"Nut","Stratocaster","Alder"),
        };
        return guitars;
    }
}