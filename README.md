# ApiService
C# .NET API service for Bricks vendor.

# Getting Started

Follow the steps below to set up and verify the API service.

## Prerequisites

* Visual Studio
* SQL Server
* Postman

## Setup Instructions

### Step 1: Execute SQL Scripts

Run all SQL scripts located in the **`Script for SQL Server`** folder to create the required database objects.

> **Folder Structure**

```text
Script for SQL Server/
├── 01_Create_Tables.sql
├── 02_Create_StoredProcedures.sql
└── 03_Create_Function
```

---

### Step 2: Configure `Web.config`

Copy the provided **`Web.config`** file and place it in the project root directory, replacing the existing file if necessary.

> **Project Path**

```text
<Project Root>\
    Web.config
```

> **Example**

![Project Structure](docs/images/project-path.png)

---

### Step 3: Run the API Service

1. Open the solution in **Visual Studio**.
2. Build the solution.
3. Set **ApiService** as the Startup Project.
4. Run the project using **IIS Express** or **Local IIS**.

---

### Step 4: Verify the API

Use **Postman** to test the **`IndexAuthen`** endpoint.

**Method**

```http
POST /api/Promotion/IndexAuthen
```

**Request Body**

```json
{
    "keyword": "test"
}
```

**Expected Response**

```json
{
    "Success": true,
    "Message": "FN IndexAuthen Success",
    "Keyword": "test"
}
```

---

