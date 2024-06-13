## 💩 bug

## 🐞 
````csharp
namespace OOP_Komposition;

public class ClassOfInvoice
{
    private List<ClassOfInvoiceItem> items;

    public void MofAddItem(ClassOfInvoiceItem item)
    {
        this.items.Add(new ClassOfInvoiceItem(Sof));
    }
}
````
## 🐞
````csharp
namespace OOP_Komposition;

public class ClassOfInvoiceItem
{
    public string SofName { get; init; }
    public int IofQuantity { get; init; }
    public double DofPricePerUnit { get; init; }
}
````
## 🐞
````csharp
namespace OOP_Komposition;

using ClassOfInvoice;
public string SofName { get; init; }
public int IofQuantity { get; init; }
public double DofPricePerUnit { get; init; }

public class SVM
{
    static void Main(string[] args)
    {
        ClassOfInvoice invoice = new(vat: 19);
        invoice.MofAddItem("Apple" , 10 , 0.8 );
        invoice.MofAddItem("Orange" , 1 , 1.8 );
        // ( ... )
    }
}
````


## 🦊 Lösung

### Changes I made:

- In ClassOfInvoice, I added a constructor to initialize the items list.
- In ClassOfInvoice, I changed the MofAddItem method to simply add the ClassOfInvoiceItem object to the list. You were trying to create a new ClassOfInvoiceItem object with Sof (which is not defined), but instead, you should pass the ClassOfInvoiceItem object as a parameter.
- In ClassOfInvoiceItem, I added a constructor to initialize the properties.
- In SVM, I removed the using ClassOfInvoice; directive, as it's not necessary. I also removed the vat: 19 parameter from the ClassOfInvoice constructor, as it's not defined in your example.

