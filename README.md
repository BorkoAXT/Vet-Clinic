#  Vet Clinic Manager

A **Windows Forms desktop application** built with **C# and .NET 8**, designed to manage pets in a veterinary clinic.  
This project was developed as a practical assignment for the **Programming Fundamentals** course at **SoftUni**.

The application allows users to register pets, browse them in a list, view detailed profiles, and mark pets as adopted.

---

## Project Overview

Vet Clinic Manager provides a simple and intuitive way to keep track of pets currently registered in a veterinary clinic.

The system supports:
- Creating pet profiles (Cats and Dogs)
- Viewing detailed information for each pet
- Managing adoption status
- Working with images and form validation

The project demonstrates core programming concepts such as **OOP**, **event-driven programming**, and **Windows Forms UI development**.

---

## Main Objectives

- Maintain a collection of pets with complete profile information
- Add new pets through a dedicated input form
- Display pet details on a separate screen
- Update and track adoption status
- Provide a user-friendly and responsive desktop interface

---

## Technologies Used

- **C#**
- **.NET 8**
- **Windows Forms**
- **Visual Studio 2022**
- **Git & GitHub**

---

## Application Structure

The application consists of three main forms:

### MainForm
- Entry point of the application
- Displays all pets in a `ListView`
- Uses different icons for cats and dogs
- Allows selecting a pet to open its details
- Provides access to the form for adding new pets

### AddPetForm
- Used to create new pet entries
- Supported input fields:
  - Name
  - Breed
  - Birth date
  - Medical history
  - Color
  - Weight
  - Image upload
  - Favorite toy (cats only)
- Includes input validation and error handling
- UI elements change dynamically based on pet type

### PetDetailsForm
- Displays full information about a selected pet
- Shows pet image and adoption status
- Includes an **Adopt** button to update the pet’s state

---

## Features

- Add new pets (Cats and Dogs)
- View all registered pets in a list
- Open detailed pet profiles
- Mark pets as adopted
- Input validation for all required fields
- Upload and display images
- Conditional UI behavior based on pet type

---

