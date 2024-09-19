
# protected 

Bis zu diesem Punkt haben wir ausschließlich mit **public** und **private** Zugriffsmodifikatoren gearbeitet.

Öffentliche Mitglieder können von überall außerhalb der Klasse zugegriffen werden, während der Zugriff auf private Mitglieder auf ihre Klasse beschränkt ist. 

Der Zugriffsmodifikator **protected** ähnelt sehr dem **private**, mit einem Unterschied; er kann in den abgeleiteten Klassen zugegriffen werden. Ein **protected** Mitglied ist also nur von abgeleiteten Klassen aus zugänglich.

**Zum Beispiel:**

```cs
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

  

namespace SoloLearn

{

    class Program

    {

        class Person {

            protected int Age {get; set;}

            protected string Name {get; set;}

        }

        class Student : Person {

            public Student(string nm) {

                Name = nm;

            }

            public void Speak() {

                Console.Write("Name: "+Name);

            }

        }

        static void Main(string[] args)

        {

            Student s = new Student("David");

            s.Speak();

        }

    }

}
```


# sealed 

Eine Klasse kann verhindern, dass andere Klassen sie oder eines ihrer Mitglieder erben, indem sie den **sealed** Modifikator verwendet.

**Zum Beispiel:**


```cs
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

  

namespace SoloLearn

{

    class Program

    {

        sealed class Animal {

            //some code

        }

        class Dog : Animal { } //Error

        static void Main(string[] args)

        {

        }

    }

}
```

In diesem Fall können wir die Dog-Klasse nicht von der Animal-Klasse ableiten, weil Animal **sealed** ist.

Das **sealed** Schlüsselwort bietet einen Schutzlevel für Ihre Klasse, so dass andere Klassen nicht davon erben können.