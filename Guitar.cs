public class Guitar {
    private string SecialNumber;
    private double Price;
    private string Builder;
    private string Model;
    private string Wood;

    public Guitar(string SecialNumber,double Price,string Builder,string Model,string Wood){
        this.SecialNumber = SecialNumber;
        this.Price = Price;
        this.Builder = Builder;
        this.Model = Model;
        this.Wood = Wood;
    }
    
    public string GetSerialNumber(){
        return this.SecialNumber;
    }
        public double GetPrice(){
        return this.Price;
    }
        public string GetBuilder(){
        return this.Builder;
    }
        public string GetModel(){
        return this.Model;
    }
        public string GetWood(){
        return this.Wood;
    }
    
}