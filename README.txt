*********************************************************************************************** 

* 

*                                           DOKUMENTACJA

* 

*********************************************************************************************** 

 
NAZWA PROJEKTU: calculatorApp
AUTOR: Wojciech Szymański
WERSJA: 3.0


[0] OPIS PROJEKTU 

Ta dokumentacja zawiera przegląd aplikacji desktopowej kalkulatora napisanej w języku C# i Windows Forms. Aplikacja umożliwia użytkownikom wykonywanie podstawowych obliczeń matematycznych, takich jak dodawanie, odejmowanie, mnożenie i dzielenie. Obsługuje również liczby dziesiętne oraz nawiasy do bardziej skomplikowanych wyrażeń matematycznych.  
  

[1] PLIKI 

Aplikacja kalkulatora składa się z dwóch głównych plików: 
- Form1.cs: Ten plik zawiera kod głównego formularza kalkulatora, w tym obsługę zdarzeń i logikę obliczeniową. 
- Form1.Designer.cs: Ten plik zawiera projekt formularza kalkulatora, w tym układ przycisków i ich właściwości. 
  

[2] FUNKCJONALNOŚĆ 

[2.1] Przyciski i Elementy Interfejsu Użytkownika

    - resultTextBox: Pole tekstowe tylko do odczytu wyświetla bieżące wyrażenie lub wynik. 

    -  clearButton:  Przycisk, którego zadaniem jest czyszczenie bieżącego wyrażenia lub wyniku. 

    - backspaceButton: Przycisk, który odpowiada za usuwanie ostatniego znaku (FILO) 

    - openingBracketButton: Przycisk dodający nawias otwierający "(" do wyrażenia. 

    - closingBracketButton: Dodaje nawias zamykający ")" do wyrażenia. 

    - digitButton_0 do digitButton_9: Przyciski dla cyfr od 0 do 9, umożliwiające wprowadzanie liczb. 

    - separatorButton: Dodaje kropkę dziesiętną "." do wyrażenia. 

    - operationButton_add: Dodaje operator dodawania "+" do wyrażenia. 

    - operationButton_substract: Dodaje operator odejmowania "-" do wyrażenia. 

    - operationButton_multiply: Dodaje operator mnożenia "*" do wyrażenia. 

    - operationButton_divide: Dodaje operator dzielenia "/" do wyrażenia. 

    - showResultButton: Oblicza i wyświetla wynik wprowadzonego wyrażenia. 
  

[2.2[ Obsługa Zdarzeń 

    - wireUpEventHandlers(): Łączy obsługę zdarzeń dla kliknięć przycisków z metodą Button_Click. Brak zwracanego typu.

    - button_Click(object? sender, EventArgs e): Obsługuje kliknięcia przycisków i aktualizuje wyrażenie, w tym obsługę kropek dziesiętnych i rozpoczynanie od poprzedniego wyniku, gdy jest to odpowiednie. Brak zwracanego typu

    - clearButton_Click(object? sender, EventArgs e): Czyści wyrażenie i wynik. Brak zwracanego typu

    - backspaceButton_Click(object? sender, EventArgs e): Usuwa ostatni znak z wyrażenia. Brak zwracanego typu

    - showResultButton_Clicked(object? sender, EventArgs e): Oblicza i wyświetla wynik wyrażenia. Brak zwracanego typu

    - Calculate(string expression): Oblicza podane wyrażenie. Wykorzystuje DataTable do obliczenia wyniku i obsługuje błędy dzielenia przez zero. Zwraca wynik typu double.
  

[2.3] Użycie

     - Uruchom aplikację kalkulatora. 

     - Użyj przycisków numerycznych (0-9), aby wprowadzać liczby. 

     - Użyj przycisków operacyjnych (+, -, *, /), aby wprowadzać operatory. 

     - Użyj przycisków nawiasów, aby grupować wyrażenia. 

     - Użyj przycisku z kropką dziesiętną, aby wprowadzić liczby dziesiętne. 

     - Naciśnij przycisk "=", aby obliczyć i wyświetlić wynik. 

     - Użyj przycisku "C", aby wyczyścić wprowadzenie i wynik. 

     - Użyj przycisku "←", aby usunąć ostatni znak z wprowadzenia. 
  

[2.4] Obsługa Błędów 

     - Kalkulator obsługuje błędy dzielenia przez zero i wyświetla okno dialogowe z komunikatem o błędzie w przypadku ich wystąpienia. 
     - Aplikacja obsługuje błędy wprowadzenia niepoprawnego dzielenia - wyświetla wówczas informację o wyniku nieliczbowym (NaN - Not a Number).


[3] UWAGI

     - Ta dokumentacja stanowi przegląd funkcji i sposobu użytkowania kalkulatora. Projekt jest we wczesnym etapie rozwoju i nie zawiera wszystkich docelowych funkcji, a niektóre funkcje są wciąż rozwijane. Stay updated!



