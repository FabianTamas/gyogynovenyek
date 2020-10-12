
# Megoldás

# Osztály létrehozása
 - Kétféle mód közül bármelyik
   - Ctrl + .
   - Adjunk hozzá egy osztályt
 - 5 tulajdonság
   - public get
   - private set 
   - 1 konstruktor
 - 1 konstruktor
   - 1 paraméter --> string
   - például: "Acsalapu;levél;6;8"
   - ;-vel vannak elválasztva
   - 4 darab adat --> 5 tulajdonság?
   - átadott, fájlból beolvasott sort:
     - ';' mentén tagoljuk
     - [0] --> Nev
     - [1] --> Resz
     - [2] --> Kezd
     - [3] --> Veg
     - Idotartam --> számolás (lásd következő pont)
 - 5-dik tulajdonság --> Időtartam
     - Konstruktorban számoljuk
     - számolása: Vég - Kezdet HA! Vég > Kezdet
     - Vég > Kezdet --> Vég - Kezdet + 1
     - Egyébként --> 12 - Kezdet + Vég + 1

## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be:
  - System.IO
  - StreamReader
  - while ciklussal --> amíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)

## 1. Feladat
- Hány növény van (lista Count tulajdonság)

## 2. Feladat
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?
- Adatszerk: Dictionary<string, int>
- 1 Milyen gyűjthető részek
  - Foreach "noveny"
  - Ha a rész nem kulcs --> adjuk hozzá 0-val
- 2 Hány darab van ezekből
  - Foreach "noveny"
  - Ha "Resz" == Key --> Value++

## 3. Feladat
- Maximum keresés --> Időtartam alapján
  - maximum változo = 0
  - foreach "noveny"
  - ha max < Idotartam --> max = Idotartam
- Növény(ek) amely(ek) a legtöbb ideig szedtek
  - foreach noveny
  - Kiírni ha Időtartam == max

## 4. Feladat
- Időtartam átlag számítás (Összegzés)