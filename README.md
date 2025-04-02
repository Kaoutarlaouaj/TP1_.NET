# TP .NET - Gestion de Système Scolaire 📚

Bienvenue dans mon projet de gestion d'un système scolaire ! Ce projet a été réalisé avec **.NET**, en utilisant **PostgreSQL** comme base de données. J'ai implémenté des principes de design tels que **Repository** et **Unit of Work** pour une gestion propre des données et une séparation claire des responsabilités.

## Technologies utilisées ⚙️

- **.NET 9**
- **PostgreSQL** 🐘
- **Entity Framework Core** 💻
- **Repository Pattern** 📦
- **Unit of Work** 🔄

## Objectif du projet 🎯

Ce projet vise à gérer les informations des étudiants, enseignants, et des cours dans un système scolaire. Il permet de réaliser des opérations basiques comme :

- Ajouter des étudiants 👨‍🎓
- Ajouter des enseignants 👩‍🏫
- Créer des classes 📚
- Enregistrer des étudiants dans des cours 📅

## Installation 🚀

1. **Clonez le repository**

   Clonez ce projet sur votre machine locale :

   ```bash
   git clone https://github.com/votre-utilisateur/TP1-.Net.git

Après avoir créé le SchoolContext et ajouté les entités, j'ai généré la migration initiale en utilisant la commande suivante :
dotnet ef migrations add InitialCreate

Ensuite, j'ai appliqué cette migration à la base de données avec la commande :
dotnet ef database update
Cela a permis de créer les relations et de mettre à jour la structure de la base de données en fonction des entités définies. Enfin, j'ai testé les API REST que j'avais développées pour m'assurer que tout fonctionnait correctement.
