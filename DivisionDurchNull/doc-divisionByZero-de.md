# Beschreibung

- Überprüfen Sie, ob der Benutzer genau zwei Argumente angegeben hat.
    - Wenn nicht, wird eine hilfreiche Meldung angezeigt und zurückgegeben.


- Parsen der angegebenen Argumente als Ganzzahlen unter 
    - Verwendung der TryParse-Methode, um Ausnahmen zu vermeiden
    - Wenn der Parser fehlschlägt, wird eine hilfreiche Meldung angezeigt und zurückgegeben.

- Prüfen Sie, ob die zweite Zahl nicht Null ist.
    - Ist dies der Fall, wird eine hilfreiche Meldung angezeigt und zurückgesprungen, um eine "Division durch Null"-Ausnahme zu vermeiden.

- Führen Sie die Division durch und geben Sie das Ergebnis aus.
    - Wandeln Sie ```secondNumber``` in einen double um, um eine Gleitkommadivision durchzuführen, die der ```int-Division``` und der double-Konvertierung des Java-Codes entspricht.