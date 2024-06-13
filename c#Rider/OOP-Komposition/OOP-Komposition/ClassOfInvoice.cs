
namespace OOP_Komposition;

public class ClassOfInvoice
{
    private List<ClassOfInvoiceItem> items;

    public ClassOfInvoice()
    {
        items = new List<ClassOfInvoiceItem>();
    }

    public void AddItem(ClassOfInvoiceItem item)
    {
        items.Add(item);
    }
}