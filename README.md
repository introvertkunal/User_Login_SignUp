# 🌐 HTTP Methods in Web APIs

This document explains how HTTP methods are used in RESTful APIs to perform operations on resources. Each method represents a specific type of action a client can request from the server.

---

## 🔧 What Are HTTP Methods?

HTTP methods are verbs that describe the action the client wants to perform on the server's resources. Common methods include `GET`, `POST`, `PUT`, `PATCH`, and `DELETE`.

---

## Working of Clean Architecture
<img width="1024" height="1024" alt="ChatGPT Image Aug 1, 2025, 03_34_22 PM" src="https://github.com/user-attachments/assets/6865d505-ad96-43e9-8a31-ebc3e9e1d3d6" />


## ✅ Common HTTP Methods

### 🔹 GET – Retrieve Data

- **Purpose:** Fetch data from the server.
- **Use Case:** Safe and idempotent (does not change state).
- **Example:**

Fetches a list of all users.

---


### 🔹 POST – Create New Data

- **Purpose:** Add a new resource to the server.
- **Use Case:** Sends a JSON body with data to be saved.
- **Example:**
```json
POST /api/users
{
  "name": "John",
  "email": "john@example.com"
}

PUT /api/users/123
{
  "name": "John Updated",
  "email": "john.updated@example.com"
}

Purpose: Delete a resource from the server.
DELETE /api/users/123




