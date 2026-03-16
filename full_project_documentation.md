# 📋 Full Project Documentation: Event Registration System

## 1. Project Overview
The **Event Registration System** is a robust desktop application designed to streamline the process of organizing, managing, and registering for events. It provides a split-role interface: an **Administrative Dashboard** for event organizers and a **User Portal** for participants.

---

## 2. System Architecture

### 🏛️ Base Architecture (Inheritance Pattern)
The project utilizes a custom inheritance model to ensure UI consistency and reduce code duplication.
*   **BaseDashboardForm:** The cornerstone of the architecture. It defines the layout structure (Sidebar, Header, Main Content Area) and provides the `openChildForm()` method.
*   **Inherited Forms:** `DashboardForm` (Admin) and `HomePage` (User) both inherit from `BaseDashboardForm`, allowing them to share the parent's logic while implementing role-specific features.

### 🔄 Dynamic Content Switching (Panel-Based)
Instead of opening multiple independent windows, the application uses a **"Single Window, Multiple Views"** approach.
*   **Mechanism:** When a user navigates (e.g., clicking "Manage Events"), the `openChildForm` method clears the `MainPanel` and injects a new `Form` level-constrained as a control. This provides a web-like "SPA" (Single Page Application) experience in a desktop environment.

---

## 3. Role-Based Features

### 🛠️ Administrative Portal (The Organizer)
Admin tools are focused on data management and oversight:
*   **Dashboard:** High-level summary of system activity.
*   **Event Management:** 
    *   **Add Event:** Form with validation for Title, Date, Location, and Description.
    *   **Edit/Delete:** Full CRUD (Create, Read, Update, Delete) capability for existing events.
*   **Participant Management:** Unified view to manage all registered users, with searching and filtering capabilities.
*   **Reporting:** Section dedicated to viewing registration trends and exporting data.

### 👤 User Portal (The Participant)
A clean, visually appealing interface for public interaction:
*   **Event Browser:** A grid-based or list view showing upcoming events with attractive cards.
*   **Registration System:** 
    *   **Multi-Participant Support:** Allows a user to register multiple people (e.g., a family or group) for the same event in one flow.
    *   **Registration Tracking:** Users can view their own past and upcoming registrations.
*   **Profile Management:** Capability for users to register an account and manage their personal details.

---

## 4. Authentication & Logic Details

### 🔑 Security Implementation
*   **Admin Access:** Hardcoded credentials (`admin@admin.com` / `admin123`) located in `LoginForm.cs` for quick access and prototype demonstration.
*   **User Authentication:** Dynamic session handling. The `HomePage` tracks `_isLoggedIn` to toggle features like the "My Registration" tab.
*   **Session-Aware UI:** Buttons automatically switch between "Login" and "Logout" based on state.

### ✅ Input Validation Suite
Custom logic implemented across all forms to protect data integrity:
*   **Numeric Guards:** `long.TryParse` for phone numbers and IDs.
*   **Format Verification:** Email string analysis (checking for `@` and valid domains).
*   **Business Rules:** Ensuring passwords are at least 8 characters and match the confirmation field.
*   **Mandatory Fields:** Logic-gate checks using `string.IsNullOrWhiteSpace` before allowing database/API commits.

---

## 5. UI/UX Design Principles
*   **Design System:**
    *   **Colors:** Primary (`SteelBlue`), Success (`MediumSeaGreen`), Warning (`OrangeRed`), Background (`AliceBlue`).
    *   **Typography:** Consistent use of "Segoe UI" and "Microsoft Sans Serif" with varied weights (Bold for headers, Regular for inputs).
*   **Visual Polish:**
    *   **Z-Order Management:** Use of `BringToFront()` for interactive elements and error messages to ensure they are never obscured by background containers.
    *   **Hover Effects:** Subtle feedback on buttons to improve interactivity.
    *   **Asset Management:** Dynamic loading of background images from the project's `Assets` folder with fallback paths for design-time and runtime.

---

## 6. Data & Services Structure
*   **Models:** Light POCO (Plain Old CLR Objects) like `Event.cs` and `Participant` used to transport data between forms.
*   **ApiService:** A centralized service class designed to handle communication between the Desktop UI and the backend database/web API.
*   **Program.cs:** The entry point configuration, currently set to launch the `HomePage` as the default view.

---

## 7. Folder Reference
*   📁 **Forms/Admin:** `AddEventForm`, `DashboardForm`, `EventManagementForm`, `ParticipantManagementForm`, `ReportsForm`.
*   📁 **Forms/User:** `EventListForm`, `HomePage`, `ParticipantRegistrationForm`, `UserDashboardForm`, `UserRegistrationForm`, `ViewRegistrationForm`.
*   📁 **Forms/Components:** `BaseDashboardForm`, `LoginForm`.
*   📁 **Models:** Data definitions (`Event.cs`).
*   📁 **Services:** Core logic and data fetching (`ApiService.cs`).
*   📁 **Assets:** Images and icons used throughout the UI.
