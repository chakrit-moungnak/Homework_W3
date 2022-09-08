public class Shop{
    public string shopname;
    public string ownername;
    public ulong serialnumber;
    public ulong value;

    public Shop(string shopname, string ownername, ulong serialnumber, ulong value) {
        this.shopname = shopname;
        this.ownername = ownername;
        this.serialnumber = serialnumber;
        this.value = value;
    }
}
