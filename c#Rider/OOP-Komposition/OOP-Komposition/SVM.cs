namespace OOP_Komposition;

class SVM
{
    static void Main(string[] args)
    {
        ClassOfInvoice invoice = new ClassOfInvoice();
        invoice.AddItem(new ClassOfInvoiceItem("Apple", 10, 0.8));
        invoice.AddItem(new ClassOfInvoiceItem("Orange", 1, 1.8));
        // (... )
    }
}