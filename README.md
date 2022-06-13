# Sokszog API
**Feladat ismertetése:**

A SokszogAPI projektben nyissa meg a *NegyzetController* osztályt!
Fejezze be a *Terulet* számítás végpontot, a már megírt *Negyzet* metódus alapján.

1. Nyissa meg a **Postman** alkalmazást, importálja be a Postman mappában található export fájlt.
2. Keresse meg *Sokszogek* gyűjteményben (**collection**) a *Negyzet* mappában lévő *Kerulet* kérést (**request**). A Tests fülön látható egy példa a teszt megírásához.
3. Készítsen el a *Negyzet* mappában egy új kérést *Terulet* néven, paraméterezze fel és írjon rá tesztet a *Kerulet* kérés alapján.
4. A Postman kérések és tesztek futtatásához **először mindig indítsa el az ASP .NET Web API projektet**.
 Az új *Terulet* kérést Tests Result fülnél kell ellenőrizni, hogy helyesen futott-e le a megírt teszt.

Összes teszt futtatása egyszerre:
A *Sokszogek* gyűjtemény melletti 3 ponton bal klikk -> Run collection, majd a Run gomb.

**Az elvárás:**
1. Készítsen Controller osztályokat a *Teglalap* és a *Haromszog* osztály kerület-terület metódusaihoz.
2. Bővítse a Postman gyűjteményt a megírt HTTP GET végpontokkal és tesztjeivel, mindegyik teszt '*Pass*' (átment) eredménnyel végződjön. 
3. Az elkészült a Web API mellett, a *Sokszogek* gyűjtemény exportját is pusholja a repositoryba.
