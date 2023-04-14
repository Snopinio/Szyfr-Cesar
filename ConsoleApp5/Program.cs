//zdefiniuj string do zaszyfrowania
string clearText = "Ala ma kota, a kot ma Ale, a sierotka ma rysia";
//zamieniamy na wielkie litery
clearText = clearText.ToUpper();
//iteruj przez caly tekst litera po literze
//deklarujemy string wynikowy
string encryptedText = "";
foreach (char c in clearText)
{
    // wyciągamy kod ascii danej litery
    //w jezyku c# rzutowanie jawne z char na int powoduje pobranie wartosci ascii
    int asciiCode = (int)c;
    //dodajemyt wartosc klucza
    asciiCode += 3;
    //zamieniamy kod z powrotem na znak
    char encryptedChar = (char)asciiCode;
    //dopisujemy do szyfru
    encryptedText += encryptedChar;
}

Console.WriteLine("Zaszyfrowany tekst: " + encryptedText);