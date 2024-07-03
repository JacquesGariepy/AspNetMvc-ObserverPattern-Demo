
# AspNetMvc-ObserverPattern-Demo

## Description
Implémentation du pattern Observer en ASP.NET MVC pour la gestion dynamique des éléments avec notification des actions (ajout, mise à jour, suppression) via des ViewComponents. Chaque section de la page est stylisée avec des couleurs distinctes pour une meilleure visualisation. Ce projet démontre comment reproduire le comportement réactif typique des applications Angular en utilisant des techniques natives d'ASP.NET MVC.

## Instructions de Déploiement

1. **Cloner le dépôt :**

   ```bash
   git clone https://github.com/JacquesGariepy/AspNetMvc-ObserverPattern-Demo.git
   cd AspNetMvc-ObserverPattern-Demo
   ```

2. **Restaurer les packages NuGet :**

   ```bash
   dotnet restore
   ```

3. **Construire le projet :**

   ```bash
   dotnet build
   ```

4. **Exécuter l'application :**

   ```bash
   dotnet run
   ```

## Structure du Projet

- **ViewComponents/MessageViewComponent.cs :** Affiche un message indiquant l'action effectuée (ajout, mise à jour, suppression).
- **ViewComponents/ChildComponent.cs :** Formulaire pour ajouter des éléments à la liste.
- **Controllers/HomeController.cs :** Gère les actions d'ajout, de mise à jour et de suppression d'éléments.
- **Services/DataService.cs :** Gère les notifications aux observateurs.
- **Views/Home/Index.cshtml :** Vue principale avec la liste des éléments et les formulaires pour ajouter et mettre à jour des éléments.
- **Views/Shared/Components/Message/Default.cshtml :** Vue pour afficher le message.
- **Views/Shared/Components/Child/Default.cshtml :** Vue pour le formulaire d'ajout d'éléments.
- **wwwroot/css/site.css :** Styles CSS pour distinguer chaque section de la page avec des couleurs.

## Fonctionnalités

- **Ajout d'Éléments :** Ajouter un nouvel élément à la liste.
- **Mise à Jour d'Éléments :** Mettre à jour un élément existant dans la liste.
- **Suppression d'Éléments :** Supprimer un élément de la liste.
- **Notification des Actions :** Afficher un message indiquant l'action effectuée via un ViewComponent.
- **Stylisation :** Chaque section de la page est stylisée avec des couleurs distinctes pour une meilleure visualisation.

## Comparaison avec le Pattern Angular

### ASP.NET MVC

- **Pattern Observer :** Implémenté en utilisant des interfaces `IObservable` et `IObserver`, avec un `DataService` pour gérer les notifications.
- **ViewComponents :** Utilisés pour encapsuler la logique de présentation réutilisable.
- **Contrôleur :** Utilisé pour gérer les actions d'ajout, de mise à jour et de suppression d'éléments.
- **Notifications :** Les messages sont mis à jour dynamiquement via des ViewComponents.

### Angular

- **Pattern Observer :** Souvent implémenté en utilisant `RxJS` (Reactive Extensions for JavaScript) pour gérer les flux de données asynchrones.
- **Components :** Les composants Angular encapsulent la logique de présentation et peuvent communiquer via des services partagés.
- **Services :** Utilisés pour gérer les données et les interactions avec les API, souvent avec `HttpClient`.
- **Notifications :** Utilisation de `Subjects` et `Observables` pour émettre et écouter des événements de manière réactive.

### Comparaison Générale

Cette preuve de concept permet de reproduire le comportement réactif typique des applications Angular dans un environnement ASP.NET MVC. Tandis qu'Angular utilise `RxJS` pour les opérations asynchrones et réactives, cette implémentation utilise des interfaces et des classes pour gérer les notifications de manière similaire. Le projet montre comment structurer et organiser une application ASP.NET MVC pour tirer parti des patterns de conception modernes et des composants réutilisables, tout en fournissant une expérience utilisateur interactive et réactive.
