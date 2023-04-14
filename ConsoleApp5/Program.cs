//deklarujemy funkcje zwracajaca string i przyjmujaca stringa jako argument
string toAsciiCesar(string clearText)
{
    //zamieniamy na wielkie litery
    clearText = clearText.ToUpper();
    //iteruj przez caly tekst litera po literze
    //deklarujemy string wynikowy
    string encryptedText = "";
    foreach (char c in clearText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu lacinskiego
        if (c >= 65 && c <= 90)
        {
            // wyciągamy kod ascii danej litery
            //w jezyku c# rzutowanie jawne z char na int powoduje pobranie wartosci ascii
            int asciiCode = (int)c;
            //dodajemyt wartosc klucza
            asciiCode += 3;
            //sprawdzamy czy nie przekroczylismy ostatniego znaku (z,90)
            if (asciiCode > 90)
                //jesli przekroczylo to cofnij  o dlugosc alfabetu
                asciiCode -= 26;
            //zamieniamy kod z powrotem na znak
            char encryptedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptedText += encryptedChar;
        }

    }
    //zwroc zakodowany string
    return encryptedText;
}

string fromAsciiCesar(string encryptedText)
{
    string clearText = "";
    foreach (char c in encryptedText)
    {
        if (c >= 65 && c <= 90)
        {
            
            int asciiCode = (int)c;
           
            asciiCode -= 3;
            
            if (asciiCode > 90)
               
                asciiCode -= 26;
            
            char encryptedChar = (char)asciiCode;
           
            encryptedText += encryptedChar;
        }
        string uncryptedText = "";
    }
    return encryptedText;
}

//zdefiniuj string do zaszyfrowania
string clearText = "Ala ma kota, a kot ma Ale, a sierotka ma rysia";

Console.WriteLine("odszyfrowany tekst: " + fromAsciiCesar(clearText));
Console.WriteLine("zaszyfrowany tekst: " + toAsciiCesar(clearText));
//koniec szyfru