🍽️ Restaurang – Kravlista (uppdaterad med bord)
🔹 Klasser

Maträtt
Egenskaper:
Namn (string)
Pris (double)

Meny
Fält: lista av maträtter (List<Maträtt>).
Metoder:
LäggTillMaträtt(Maträtt m)
VisaMeny()

Bord
Egenskaper:
Bordsnummer (int)
AntalPlatser (int)
Upptaget (bool)

Metoder:
BokaBord()
FrigörBord()
Beställning

Fält:
Lista<Maträtt> (vad som beställs)
Bord (vilket bord som beställt)
Ordernummer (unikt ID för beställningen)
Status (t.ex. “Pågående”, “Klar”, “Serverad”)

Metoder:
LäggTillBeställning(Maträtt m)
VisaBeställning()
BeräknaTotal()
Kök
Fält: lista av beställningar (List<Beställning>).
Metoder:
TaEmotBeställning(Beställning b)
VisaAllaBeställningar() (visa per bord!)
MarkeraKlar(int ordernummer)
Restaurang
Fält:
Meny
Kök

Lista<Bord>
Metoder:
VisaMeny()
TaBeställning(int bordsnummer)
SkickaTillKök(Beställning b)
SkrivUtKvitto(Beställning b)

🔹 Funktionalitet

När gäster kommer:
Ett bord bokas.
Gästerna gör en beställning (kopplad till just det bordet).
Beställningen skickas till köket.
Köket kan visa vilka bord som har beställningar.
När en order är klar kan köket markera den som färdig.
Restaurangen skriver ut kvitto till gästerna när de är klara.
Bordet frigörs.