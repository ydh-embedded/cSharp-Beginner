




Unit Test: Ein automatisierter Test, der eine Unit prüft.
Unit: Kleine Einheiten wie Methoden, Klassen, Funktionen (manchmal auch Softwarekomponente)
Gute Unit Tests folgen den F.I.R.S.T Prinzipien:
F(ast): Schnelle Ausführbarkeit
I(ndependence)/I(solated):
- Die Reihenfolge der Ausführung von Tests darf/sollte keine Rolle spielen. (Unabhängigkeit)
- Abhängigkeiten zu anderen Komponenten (z.B. Datenbank, Serververbindung) sollen "gefaked" werden,
  um Seiteneffekte durch andere Komponenten zu vermeiden (Isolation).
  R(epeatable): Test sollte beliebig oft nacheinander ausführbar sein und dieselben Ergebnisse liefern.
  S(elf-Validating): Der Test muss selbst entscheiden können, ob er erfolgreich war oder fehlgeschlagen ist. (Binäres Ergebnis)
  Eine manuelle Auswertung durch einen Entwickler darf nicht notwendig sein.
  T(imely)/T(horough):
    - Tests sollten regelmäßig und rechtzeitig (am besten während der Entwicklung) entwickelt und durchgeführt werden.
- Ein Test sollte wirksam sein, also Grenzwerte testen (z.B. ab 100€ 5% Rabatt, ansonsten nur 2% Rabatt)
- Wie wird mit fehlerhaften Daten umgegangen? Stürzt das Programm ab?
- Nicht nur Erfolgspfade, sondern auch Fehlerpfade abdecken.