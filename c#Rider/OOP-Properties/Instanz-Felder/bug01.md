#  💩 bug

## 🐬 Beispiel



````csharp

The accessibility modifier of the accessor must be
    more restrictive than the property 'Instanz_Felder.Pro.TypeOfEnumOfCurrentv3'
    
````

````csharp

    
    // Variante 2
    private EnumOfCurrent TypeOfEnumOfCurrentv3 { public get; set; }

````

## 🐞 Grund 
-   ``{ public get; set; }`` ist eine höhere Sichtbarkeit als ``private EnumOfCurrent``

## 🦊 Lösung 

-   Die Sichtbarkeit eindeutig definieren wie in V1 oder V3

