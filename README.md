# Lernperiode-3

Erjon Hulaj

12.1. bis 23.2.2024

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   Meine Durchschnittsnote in Informatik ist eine 5. Im Modul 319 sowie 431 war ich sehr gut. Im letzten Modul 162 war ich nicht so stark und ich muss mich verbessern. Das war das mit den Datenbanken.
   
3. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   Das ich jetzt mal etwas anderes versuchen will und in Zukunft mehr Programmieren lernen will.
   
4. Was wäre ein geeignetes Projekt würd diese LP3?
Notenrechner

## 12.1.2024

- [ ] Planen wie ich vorgehe
- [ ] Forms design erstellen
- [ ] Die ersten Kästchen programmieren mit den Formeln zum berechnen

19.1.2024

- [ ] Berechnen Knopf programmieren
- [ ] Löschen Knopf berechnen
- [ ] Tests machen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Zwei Noten    | Neue Note (Note3) eingeben   | Gesamtnote wird automatisch aktualisiert, unter Berücksichtigung der Note3 im Durchschnitt    | Ja    |
| 2 | Drei Noten (Note1, Note2, Note3)    | Neue Note (Note4) eingeben    | Gesamtnote wird automatisch aktualisiert, unter Berücksichtigung der Note4 im Durchschnitt    | Ja    |
| 3   | Noten und Gewichtungen sind bereits im System eingetragen    | Eine weitere Note (Note5)   | Gesamtnote wird entsprechend aktualisiert, unter Berücksichtigung der Note5 wird berücksichtigt    | Ja    |


## 26.1.2024

- [ ] Man muss zwei Noten oder mehr eingeben sonst kommt eine Fehlermeldung
- [ ] Forms Design verfeinern
- [ ] Testen
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 4   | Keine Note     | Eine Note    | Fehlermeldung: "Bitte füllen Sie mindestens zwei Textboxen aus."   | Ja    |
| 5   | Forms ist geöffnet, Design vorhanden    | Eingabe von Noten, berechnung und das leeren aller Textboxen    | Forms zeigt keine unerwarteten Fehler, alle Aktionen werden erfolgreich durchgeführt    | Ja    |
| 6   |     |     |     |     |

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 10-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?
