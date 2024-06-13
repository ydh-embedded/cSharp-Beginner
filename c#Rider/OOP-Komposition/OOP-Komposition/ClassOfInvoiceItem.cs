namespace OOP_Komposition;

public class ClassOfInvoiceItem
{
    public string SofName { get; init; }
    public int IofQuantity { get; init; }
    public double DofPricePerUnit { get; init; }

    public ClassOfInvoiceItem(string sofName, int iofQuantity, double dofPricePerUnit)
    {
        SofName = sofName;
        IofQuantity = iofQuantity;
        DofPricePerUnit = dofPricePerUnit;
    }
}