# 🍕 Application de Commande de Pizza en C#

## 📝 Présentation

Cette application Windows Forms développée en C# permet de simuler un système de commande de pizza. Elle offre une interface graphique intuitive permettant aux utilisateurs de personnaliser leur pizza selon différents critères (taille, type de croûte, garnitures) et de visualiser en temps réel le résumé de leur commande ainsi que le prix total.

## ✨ Fonctionnalités

- **Sélection de la taille de pizza** : Petite, Moyenne ou Grande avec tarification dynamique
- **Choix du type de croûte** : Fine ou Épaisse
- **Sélection de garnitures multiples** :
  - Fromage supplémentaire
  - Champignons
  - Tomates
  - Oignons
  - Olives
  - Poivrons verts
- **Option de service** : Sur place ou à emporter
- **Calcul automatique du prix** en fonction des sélections
- **Possibilité de commander plusieurs pizzas identiques** avec mise à jour du prix total
- **Résumé de commande en temps réel**
- **Confirmation de commande** avec messages de validation
- **Réinitialisation du formulaire** pour une nouvelle commande

## 🖥️ Interface utilisateur

L'interface utilisateur est divisée en plusieurs sections :

1. **Panneau de sélection** - Partie gauche permettant de choisir les options de pizza
2. **Résumé de commande** - Partie droite affichant un récapitulatif en temps réel des choix effectués
3. **Actions** - Boutons pour commander ou réinitialiser le formulaire

## 💰 Tarification

Les prix sont définis comme suit :

### Tailles
- Petite : Prix de base inférieur
- Moyenne : Prix intermédiaire
- Grande : Prix plus élevé

### Type de croûte
- Fine : Option standard
- Épaisse : Option avec supplément

### Garnitures
- Chaque garniture sélectionnée ajoute un supplément au prix final

## 🚀 Installation et prérequis

### Prérequis
- Microsoft Windows 7 ou supérieur
- .NET Framework 4.5 ou supérieur
- Microsoft Visual Studio (pour le développement)

### Installation

1. Clonez ou téléchargez ce dépôt sur votre machine locale
2. Ouvrez le fichier solution `Windows Pizza Forms.sln` avec Visual Studio
3. Compilez et exécutez le projet

## 💻 Utilisation

1. Lancez l'application
2. Sélectionnez la taille de pizza désirée
3. Choisissez le type de croûte
4. Cochez les garnitures souhaitées
5. Indiquez si vous souhaitez manger sur place ou à emporter
6. Si nécessaire, ajustez la quantité de pizzas avec le contrôle numérique
7. Vérifiez le résumé de commande et le prix total
8. Cliquez sur "Commander" pour finaliser la commande
9. Confirmez votre commande dans la boîte de dialogue
10. Pour recommencer, cliquez sur "Réinitialiser"

## 🧩 Structure du code

Le projet est organisé selon le modèle standard d'une application Windows Forms :

- **Form1.cs** : Contient la logique métier et les gestionnaires d'événements
- **Form1.Designer.cs** : Définit l'interface utilisateur et les contrôles
- **Program.cs** : Point d'entrée de l'application
- **Resources/** : Contient les images et ressources utilisées dans l'application

## 🛠️ Technologie utilisée

- C# comme langage de programmation
- Windows Forms pour l'interface graphique
- .NET Framework comme plateforme d'exécution

## 🔄 Possibilités d'amélioration

- Ajout d'une base de données pour stocker l'historique des commandes
- Intégration d'un système d'authentification utilisateur
- Ajout de nouvelles options (boissons, desserts, etc.)
- Développement d'une fonctionnalité de livraison avec calcul de frais
- Mise en place d'un système de paiement en ligne

## 👤 Auteur

- **Oussama Souissi** - [GitHub](https://github.com/Oussama-souissi024)

## 📜 Licence

Ce projet est distribué sous licence open source.
Pizza/C#
