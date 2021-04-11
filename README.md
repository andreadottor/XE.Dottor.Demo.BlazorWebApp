# BlazorWebApp

Codice dell'evento "*XE Online Meeting* - **SPA Framework a confronto**" del 2020.10.16

Codice dell'evento "*Blazor Conf 2021* - **Blazor per uno sviluppatore WebForm**" del 2021.03.18

Codice dell'evento "*Blazor Conferenze 2021* - **Dal RenderFragment ai Generics, tips for Blazor developers**" del 2021.04.13

## XE.Dottor.BlazorWebApp

Applicazione Blazor WebAssembly che visualizza una lista di post recuperata da https://jsonplaceholder.typicode.com/posts .
Logica dell'applicazione nel progetto XE.Dottor.ApplicationCore.<br>
L'aggiunta ai post di tag e dell numero di like iniziale viene fatto da una funzione JavaScript (solo per simulare un'altra sorgente dati).

- Applicazione SPA
- Uso di Componenti
  - Post, Tags, Loading, ...
  - Creazione di codice dinamicamente (titolo dei post con dimensione in base ai like)
- Autenticazione custom (verifica esistenza utente)
  - Richiesto login per apertura dettagllio
- Esempio form (form di login)
- Utilizzo di Gravatar per immagine utente che ha commentato
- Interazione con JavaScript
  - Salvataggio dati temporanei nel localStorage del browser

## XE.Dottor.RazorPagesApp

Esempio di utilizzo di Blazor Server in un'applicazione ASP.NET Core che utilizza le Razor Pages.

## BlazorConference2021

Tricks per generazione di codice html e componenti dinamicamente.

Utilizzo di *Generics* ed *ereditarietà*
