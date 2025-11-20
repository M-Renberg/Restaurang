


<div align="center">
  <h3 align="center">Restaurang</h3>

  <p align="center">
    Fun restaurang software. 
    <br />
    <a href="https://github.com/M-Renberg/Restaurang"><strong>Explore the docs »</strong></a>
    <br />

  </p>
</div>

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

---

## 👾 About The Project <a name="about-the-project"></a>

(Text here in Swedish. It's just me to-do list)
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
Why this project exists:
* It saves time.
* DRY: Don't Repeat Yourself.
* It helps developers focus on code.

---

## 🚀 Getting Started <a name="getting-started"></a>

Follow instructions to get the project working on your device.
### Prerequisites <a name="prerequisites"></a>

This is what you need to install the software.
- Bash
- IDE

### Installation <a name="installation"></a>

1. Clone the repo
   ```sh
   git clone https://github.com/M-Renberg/Restaurang
   ```


## 🔧 Usage <a name="usage"></a>

Easy project that could be expanded upon if you want a trading system build i c#

## 🤝 Contributing <a name="contributing"></a>

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📜 License <a name="license"></a>

Distributed under the MIT License.

---

## 👤 Contact <a name="contact"></a>

Mikael Renberg - [LinkedIn](https://www.linkedin.com/in/mikael-renberg-98b062178/) - mikael.k.renberg@hotmail.com

Project Link: [Rastaurang](https://github.com/M-Renberg/Restaurang)