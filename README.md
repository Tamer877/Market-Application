# 🛒 Market Management System (Desktop Application)

A desktop-based retail and inventory management application developed with **C# (.NET Windows Forms)** and **Microsoft SQL Server**. The system implements a layered architectural approach to manage user credentials, role-based authorization, inventory records, and point-of-sale operations.

> ⚠️ **Note:** This project is currently in a prototype / work-in-progress state. It serves as a practical demonstration of multi-tier architecture, ADO.NET database operations, and desktop UI workflows.

---

## ✨ Features

- **Role-Based Authentication & Authorization:**
  - Distinct access workflows for `Admin` and `Cashier` roles.
  - Security question/answer authentication for password recovery.
- **Product & Inventory Management:**
  - Full CRUD operations for product catalogs.
  - Barcode and product code identification support.
  - Tracking attributes: weight, unit pricing, turnover rates, and timestamps (creation & updates).
- **User Management (Admin Dashboard):**
  - Create, update, and manage employee accounts, regional assignments, and access privileges.
- **Cashier POS Interface:**
  - Quick barcode-based product lookup for checkout handling.
- **Dedicated Categories:**
  - Specialized module/screen for fresh produce (Fruits & Vegetables).

---

## 🏛️ Architecture

The solution uses a **N-Tier / Layered Architecture** pattern to separate concerns cleanly:

- **Presentation Layer (UI):** Windows Forms (`Form1`, `AdminScreen`, `CashierScreen`, `ProductScreen`, `UserScreen`, `FruitAndVegetables`, `ChangePassword`).
- **Business Logic Layer (BLL):** `Controller.cs` orchestrates requests and validates business constraints.
- **Data Access Layer (DAL):** `Repository.cs` handles all ADO.NET SQL commands and Stored Procedures.
- **Entities & Models:** `User`, `Product`, and `LoginTable` data objects.
- **Enums:** Custom status codes (e.g., `loginStatus`) for clear error propagation.

---

## 🛠️ Tech Stack

- **Language:** C# (.NET Framework)
- **UI Framework:** Windows Forms (WinForms)
- **Database:** Microsoft SQL Server
- **Data Access:** ADO.NET (Raw SQL & Stored Procedures)
- **IDE:** Visual Studio

---

