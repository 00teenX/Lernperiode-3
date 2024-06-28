# Lernperiode-3

Erjon Hulaj

12.1. bis 23.2.2024

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   Meine Durchschnittsnote in Informatik ist eine 5. Im Modul 319 sowie 431 war ich sehr gut. Im letzten Modul 162 war ich nicht so stark und ich muss mich
   verbessern. Das war das mit den Datenbanken.
   
3. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   Das ich jetzt mal etwas anderes versuchen will und in Zukunft mehr Programmieren lernen will.
   
4. Was wäre ein geeignetes Projekt würd diese LP3?
Notenrechner

## 12.1.2024

- [x] Planen wie ich vorgehe
- [x] Forms design erstellen
- [x] Die ersten Kästchen programmieren mit den Formeln zum berechnen

19.1.2024

- [x] Berechnen Knopf programmieren
- [x] Löschen Knopf berechnen
- [x] Tests machen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Zwei Noten    | Neue Note (Note3) eingeben   | Gesamtnote wird automatisch aktualisiert, unter Berücksichtigung der Note3 im Durchschnitt    | Ja    |
| 2 | Drei Noten (Note1, Note2, Note3)    | Neue Note (Note4) eingeben    | Gesamtnote wird automatisch aktualisiert, unter Berücksichtigung der Note4 im 
Durchschnitt    | Ja    |
| 3   | Noten und Gewichtungen sind bereits im System eingetragen    | Eine weitere Note (Note5)   | Gesamtnote wird entsprechend aktualisiert, unter 
Berücksichtigung der Note5 wird berücksichtigt    | Ja    |


## 26.1.2024

- [x] Man muss zwei Noten oder mehr eingeben sonst kommt eine Fehlermeldung
- [x] Forms Design verfeinern
- [x] Testen
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 4   | Keine Note     | Eine Note    | Fehlermeldung: "Bitte füllen Sie mindestens zwei Textboxen aus."   | Ja    |
| 5   | Forms ist geöffnet, Design vorhanden    | Eingabe von Noten, berechnung und das leeren aller Textboxen    | Forms zeigt keine unerwarteten Fehler, alle 
Aktionen werden erfolgreich durchgeführt    | Ja    |
| 6   |     |     |     |     |

## Reflexion

In den letzten Wochen habe ich daran gearbeitet, ein Programm zu entwickeln, das Noten berechnen kann.

Zuerst habe ich das Aussehen des Programms geplant und entworfen. Dann habe ich angefangen, die Funktionen zu programmieren, die die Noten berechnen und 
löschen können. Beim Berechnen habe ich gemerkt, dass wenn man eine Note mit Komma eingegeben hat, es falsch ausgerechnet wurde. Ich habe es so programmiert, 
sodass die Kommas zu Punkten werden und dann hats funktioniert. Glücklicherweise lief der Rest reibungslos und ich konnte alles rechtzeitig fertigstellen.

Ein anderes Problem, auf das ich gestossen bin, war, dass ich herausfinden musste, wie ich sicherstellen kann, dass mindestens zwei Noten eingegeben werden, bevor das Programm arbeiten kann. Das hat etwas länger gedauert, aber schlussendlich habe ich eine Lösung gefunden.

Alles in allem bin ich zufrieden mit meiner Arbeit. Das Programm funktioniert, wie es soll, und ich habe dabei auch noch einiges gelernt. 

